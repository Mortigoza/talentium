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
            for (int i = 0; i < DTEntrevistas.Rows.Count; i++)
            {
                TabPage tabPage = CloneTabPage(plantillaTab);
                string nombreEtapa = $"{DTEntrevistas.Rows[i]["etapa"]}-{DTEntrevistas.Rows[i]["entrevista"]}";
                tabPage.Text = nombreEtapa;
                tabEtapas.TabPages.Add(tabPage);
                tabPage.Enabled = true;
            }
            plantillaTab.Visible = false;

            lblNombreApellido.Text = $"{nombre} {apellido}";
            lblPuesto.Text = puesto;
            ////this.idCandidato = idCandidatoSeleccionado;
            //lblNombreApellidoP.Text = $"{nombre} {apellido}";
            //lblPuestoP.Text = puesto;
            dtpEntrevista.MinDate = DateTime.Today;
            DataTable datosEtapa = proceso.ObtenerDatosEtapas(id);
        }
        private TabPage CloneTabPage(TabPage sourceTabPage)
        {
            TabPage newTabPage = new TabPage();
            foreach (Control control in sourceTabPage.Controls)
            {
                Control newControl = CloneControl(control);
                newTabPage.Controls.Add(newControl);
            }
            newTabPage.Enabled = true;
            return newTabPage;
        }
        private Control CloneControl(Control control)
        {
            Control newControl = (Control)Activator.CreateInstance(control.GetType());
            if (control is TextBox)
            {
                ((TextBox)newControl).Text = ((TextBox)control).Text;
            }
            else if (control is ComboBox)
            {
                ((ComboBox)newControl).SelectedIndex = ((ComboBox)control).SelectedIndex;
            }
            else if (control is Label)
            {
                ((Label)newControl).Text = ((Label)control).Text;
            }
            newControl.Location = control.Location;
            newControl.Size = control.Size;
            newControl.Enabled = control.Enabled;

            foreach (Control childControl in control.Controls)
            {
                Control newChildControl = CloneControl(childControl);
                newControl.Controls.Add(newChildControl);
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
            if ((e.TabPageIndex == 1 && !tabPreocupacional.Enabled))
            {
                e.Cancel = true;
            }

            if (e.TabPage == tabSegundaEntrevista)
            {
                if (!string.IsNullOrEmpty(cmbEstadoPreocupacional.Text))
                {
                    e.Cancel = true;
                    tabPreocupacional.Enabled = true;
                }
            }
        }

        private void frmEntrevistaPreocupacionalCapacitacion_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbEstadoPreocupacional.Text))
            {
                tabPreocupacional.Enabled = true;
            } else
            {
                tabPreocupacional.Enabled = false;
            }
            
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
