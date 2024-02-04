using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio;
using LogicaNegocio.Accesibilidad;
using Vista.Lenguajes;

namespace Vista.Gestion_de_Talento
{
    public partial class frmEntrevistaPreocupacionalCapacitacion : Form
    {
        CN_LogicaProcesoSeleccion proceso = new CN_LogicaProcesoSeleccion();
        CN_LogicaEntrevista logicaEntrevista = new CN_LogicaEntrevista();
        private int idCandidato;
        List<string> estados = new List<string>() { "APTO", "NO APTO" };
        private bool seleccionarTab = true;

        public int IdCandidato
        {
            get { return idCandidato; }
            set { idCandidato = value; }
        }
        public frmEntrevistaPreocupacionalCapacitacion(string nombre, string apellido, string puesto, int id)
        {
            InitializeComponent();
            //int cantidadRegistros = logicaEntrevista.CantidadEntrevista();
            DataTable DTEntrevistas = logicaEntrevista.ConsultarEntrevistas();
            TabPage plantillaTab = tabEtapas.TabPages[0];
            DataTable datosArea = proceso.ObtenerAreas();
            cmbAreas.DataSource = datosArea;
            cmbAreas.DisplayMember = "area";
            cmbAreas.ValueMember = "id_area";
            cmbEstadoEntrevista.DataSource = estados;
            for (int i = 0; i < DTEntrevistas.Rows.Count; i++)
            {
                TabPage tabPage = CloneTabPage(plantillaTab, nombre, apellido, puesto, id);
                string nombreEtapa = $"{DTEntrevistas.Rows[i]["etapa"]}-{DTEntrevistas.Rows[i]["entrevista"]}";
                tabPage.Text = nombreEtapa;
                tabEtapas.TabPages.Add(tabPage);
                tabEtapas.TabPages.Remove(plantillaTab);
                tabEtapas.TabPages.Remove(tabPreocupacional);
                tabEtapas.TabPages.Add(tabPreocupacional);
                
            }
            //plantillaTab.Visible = false;
            //tabEtapas.Enabled = true;
            //lblNombreApellido.Text = $"{nombre} {apellido}";
            //lblPuesto.Text = puesto;
            ////this.idCandidato = idCandidatoSeleccionado;
            lblNombreApellidoP.Text = $"{nombre} {apellido}";
            lblPuestoP.Text = puesto;
            dtpEntrevista.MinDate = DateTime.Today;
            

        }
        private TabPage CloneTabPage(TabPage sourceTabPage, string nombre, string apellido, string puesto, int id)
        {
            TabPage newTabPage = new TabPage();
            foreach (Control control in sourceTabPage.Controls)
            {
                Control newControl = CloneControl(control, control.Name == "cmbEstadoEntrevista");
                newTabPage.Controls.Add(newControl);
                lblNombreApellido.Text = $"{nombre} {apellido}";
                lblPuesto.Text = puesto;

                

                //DataTable datosEtapa = proceso.ObtenerDatosEtapas(id);
                //DataTable datosArea = proceso.ObtenerAreas();
                //cmbAreas.DataSource = datosArea;
                //cmbAreas.DisplayMember = "area";
                //cmbAreas.ValueMember = "id_area";
                //if (datosEtapa.Rows.Count > 0)
                //{
                //    DataRow row = datosEtapa.Rows[0];
                //    dtpEntrevista.Value = Convert.ToDateTime(row["fecha_entrevista"]);
                //    cmbAreas.Text = row["area"].ToString();
                //    cmbEmpleados.Text = row["entrevistador"].ToString();
                //    cmbEstadoEntrevista.Text = row["estado_entrevista"].ToString();
                //}
            }

            newTabPage.Enabled = true;
            newTabPage.BackColor = Color.White;

            // Asegurémonos de que los datos del área sean únicos para cada ComboBox
            foreach (Control control in newTabPage.Controls)
            {
                if (control is ComboBox cmb && cmb.Name == "cmbAreas")
                {
                    cmb.DataSource = proceso.ObtenerAreas().Copy();
                }
            }

            // Asegurémonos de que los datos de la etapa se carguen correctamente
            DataTable datosEtapa = proceso.ObtenerDatosEtapas(id);
            if (datosEtapa.Rows.Count > 0)
            {
                DataRow row = datosEtapa.Rows[0];
                DateTimePicker dtpEntrevista = newTabPage.Controls["dtpEntrevista"] as DateTimePicker;
                dtpEntrevista.Value = Convert.ToDateTime(row["fecha_entrevista"]);
                ComboBox cmbAreas = newTabPage.Controls["cmbAreas"] as ComboBox;
                cmbAreas.Text = row["area"].ToString();
                ComboBox cmbEmpleados = newTabPage.Controls["cmbEmpleados"] as ComboBox;
                cmbEmpleados.Text = row["entrevistador"].ToString();
                ComboBox cmbEstadoEntrevista = newTabPage.Controls["cmbEstadoEntrevista"] as ComboBox;
                cmbEstadoEntrevista.Text = row["estado_entrevista"].ToString();
            }

            return newTabPage;
        }
        private Control CloneControl(Control control,bool isEstadoComboBox = false)
        {
            Control newControl = (Control)Activator.CreateInstance(control.GetType());

            if (control is ComboBox)
            {
                ComboBox originalComboBox = (ComboBox)control;
                ComboBox newComboBox = (ComboBox)newControl;

                // Clonar el objeto DataSource si es DataTable
                if (originalComboBox.DataSource is DataTable)
                {
                    DataTable originalDataSource = (DataTable)originalComboBox.DataSource;
                    DataTable clonedDataSource = originalDataSource.Copy();
                    newComboBox.DataSource = clonedDataSource;
                }
                else
                {
                    newComboBox.DataSource = originalComboBox.DataSource;
                }

                newComboBox.DisplayMember = originalComboBox.DisplayMember;
                newComboBox.ValueMember = originalComboBox.ValueMember;
                newComboBox.SelectedItem = originalComboBox.SelectedItem;

                // Manejar ComboBox de estado
                if (isEstadoComboBox)
                {
                    newComboBox.SelectedValueChanged += (sender, e) =>
                    {
                        // Evitar propagar cambios a otros ComboBox de estado
                        if (newComboBox.Focused)
                        {
                            foreach (Control tabPageControl in newComboBox.Parent.Controls)
                            {
                                if (tabPageControl is ComboBox otherComboBox && otherComboBox.Name == "cmbEstadoEntrevista" && !otherComboBox.Equals(newComboBox))
                                {
                                    otherComboBox.Text = newComboBox.Text;
                                }
                            }
                        }
                    };
                }
            }
            else
            {
                // Resto del código para otros tipos de controles
                newControl.Text = control.Text;
            }

            newControl.Location = control.Location;
            newControl.Size = control.Size;
            newControl.Enabled = true;

            foreach (Control childControl in control.Controls)
            {
                Control newChildControl = CloneControl(childControl, isEstadoComboBox);
                newControl.Controls.Add(newChildControl);
                newControl.Enabled = true;
            }

            return newControl;
        }

        private void cmbEstadoEntrevista_DropDown(object sender, EventArgs e)
        {
            cmbEstadoEntrevista.DataSource = estados;
        }

        private void cmbEmpleados_DropDown(object sender, EventArgs e)
        {
            
        }

        private void cmbAreas_DropDown(object sender, EventArgs e)
        {
            cmbAreas.DataSource = proceso.ObtenerAreas();
            cmbAreas.DisplayMember = "area";
            cmbAreas.ValueMember = "id_area";
        }

        private void cmbAreas_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedArea = cmbAreas.SelectedItem as DataRowView;
            int idAreaSeleccionada = Convert.ToInt32(selectedArea["id_area"]);
            DataTable DTEmpleados = proceso.ObtenerEmpleados(idAreaSeleccionada);
            DTEmpleados.Columns.Add("NombreCompleto", typeof(string), "APELLIDOS + ', ' + NOMBRES");

            if (DTEmpleados != null && DTEmpleados.Rows.Count > 0)
            {
                cmbEmpleados.DataSource = DTEmpleados;
                cmbEmpleados.DisplayMember = "NombreCompleto";
            }
            else
            {
                cmbEmpleados.DataSource = null;
                cmbEmpleados.Items.Clear();
            }
        }

        private void dtpEntrevista_ValueChanged(object sender, EventArgs e)
        {
            FechaSeleccionadaSegundaEntrevista();
        }
        private void cmbEstadoEntrevista_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarHabilitacionPestanas();
        }
        private void ActualizarHabilitacionPestanas()
        {
            // Recorre las pestañas y actualiza la habilitación según la selección en el ComboBox de estado
            for (int i = 0; i < tabEtapas.TabPages.Count; i++)
            {
                TabPage tabPage = tabEtapas.TabPages[i];

                if (i == tabEtapas.SelectedIndex)
                {
                    // Si es la pestaña actual, actualiza según el ComboBox de estado
                    ComboBox cmbEstado = tabPage.Controls["cmbEstadoEntrevista"] as ComboBox;

                    if (cmbEstado != null && cmbEstado.SelectedItem != null)
                    {
                        string estado = cmbEstado.Text;

                        if (estado == "APTO")
                        {
                            // Habilitar la siguiente pestaña
                            int nextIndex = i + 1;
                            if (nextIndex < tabEtapas.TabPages.Count)
                            {
                                tabEtapas.TabPages[nextIndex].Enabled = true;
                            }
                        }
                    }
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int idCandidato = IdCandidato;
            if (cmbEstadoEntrevista.Enabled)
            {
                
                if (cmbEstadoEntrevista.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un estado.");
                    return;
                }
                
                string estado = cmbEstadoEntrevista.Text;
                proceso.ModificarEstado(idCandidato, estado, null);
                MessageBox.Show("Los datos han sido guardados correctamente.");
                if (estado == "APTO")
                {
                    tabPreocupacional.Enabled = true;
                } else
                {
                    tabPreocupacional.Enabled = false;
                }
            }
            else
            {
                DateTime fecha_etapa = dtpEntrevista.Value;
                string area = cmbAreas.Text;
                string entrevistador = cmbEmpleados.Text;
                proceso.InsertarEtapa(idCandidato, fecha_etapa, area, entrevistador);
                MessageBox.Show("Los datos han sido guardados correctamente.");
                tabPreocupacional.Enabled = false;
            }
        }

        private void tabEtapas_Selecting(object sender, TabControlCancelEventArgs e)
        {
            //if ((e.TabPageIndex == 1 && !tabPreocupacional.Enabled))
            //{
            //    e.Cancel = true;
            //}

            //if (e.TabPage == tabSegundaEntrevista)
            //{
            //    if (!string.IsNullOrEmpty(cmbEstadoPreocupacional.Text))
            //    {
            //        e.Cancel = true;
            //        tabPreocupacional.Enabled = true;
            //    }
            //}
        }
        private void HabilitarPestanaInicial()
        {
            // Determina cuál es la pestaña inicial a habilitar según tus criterios
            // Puedes personalizar esta lógica según tus necesidades

            int indexToEnable = 0;

            for (int i = 0; i < tabEtapas.TabPages.Count; i++)
            {
                TabPage tabPage = tabEtapas.TabPages[i];
                ComboBox cmbEstado = tabPage.Controls["cmbEstadoEntrevista"] as ComboBox;

                if (cmbEstado != null && cmbEstado.SelectedItem != null)
                {
                    string estado = cmbEstado.Text;

                    if (estado != "APTO")
                    {
                        // La pestaña no tiene estado "APTO", así que es la inicial
                        indexToEnable = i;
                        break;
                    }
                }
            }

            tabEtapas.TabPages[indexToEnable].Enabled = true;
        }

        private void frmEntrevistaPreocupacionalCapacitacion_Load(object sender, EventArgs e)
        {
            foreach (TabPage tabPage in tabEtapas.TabPages)
            {
                tabPage.Enabled = false;
            }
            HabilitarPestanaInicial();

        }

        public void FechaSeleccionadaSegundaEntrevista()
        {
            lblEtiqueta.Visible = false;
            DateTime fechaSeleccionada = dtpEntrevista.Value;
            if (fechaSeleccionada < DateTime.Now)
            {
                cmbEstadoEntrevista.Enabled = true;
                cmbEmpleados.Enabled = false;
                cmbAreas.Enabled = false;
            }
            else
            {
                cmbEstadoEntrevista.Enabled = false;
                cmbEstadoEntrevista.Text = "PROGRAMADA";
                cmbEmpleados.Enabled = true;
                cmbAreas.Enabled = true;
            }
        }

        // *************** Preocupacional **************** 

        private void dtpPreocupacional_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = dtpPreocupacional.Value;

            if (fechaSeleccionada < DateTime.Now)
            {
                cmbEstadoPreocupacional.Enabled = true;
                rchPatologias.Enabled = true;
            }
            else
            {
                cmbEstadoPreocupacional.Enabled = false;
                cmbEstadoPreocupacional.Text = "PROGRAMADA";
                rchPatologias.Enabled = false;
            }
        }

        private void cmbEstadoPreocupacional_DropDown(object sender, EventArgs e)
        {
            cmbEstadoPreocupacional.DataSource = estados;
        }

        private void btnGuardarP_Click(object sender, EventArgs e)
        {
            int idCandidato = IdCandidato;
            if (cmbEstadoPreocupacional.Enabled)
            {

                if (cmbEstadoPreocupacional.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un estado.");
                    return;
                }

                string estado = cmbEstadoPreocupacional.Text;
                string patologias = rchPatologias.Text;
                proceso.ModificarEstado(idCandidato, estado, patologias);
                MessageBox.Show("Los datos han sido guardados correctamente.");
                
            }
            else
            {
                DateTime fecha_etapa = dtpPreocupacional.Value;
                proceso.InsertarEtapa(idCandidato, fecha_etapa, null, null);
                MessageBox.Show("Los datos han sido guardados correctamente.");
            }
        }
        

        private void tabEtapas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!seleccionarTab)
            {
                tabEtapas.SelectedTab = null;
            }
            Idioma.CargarIdioma(this.Controls, this); //Asigno los nombres a los controles del formulario
        }
    }
}
