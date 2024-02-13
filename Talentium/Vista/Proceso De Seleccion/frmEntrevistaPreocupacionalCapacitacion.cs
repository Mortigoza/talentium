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
        private bool seleccionarTab = true;
        public frmEntrevistaPreocupacionalCapacitacion()
        {
            InitializeComponent();
            DataTable DTEntrevistas = logicaEntrevista.ConsultarEntrevistas();
            tabEtapas.TabPages.Add(tabPreocupacional);
        }
        public int AgregarControlesEnTab(string nombreEtapa, string nombre, string apellido, string puesto,
            string estado, DateTime fecha, string entrevistador, TabPage nuevaPestana, int id_persona)
        {
            this.idCandidato= id_persona;
            nuevaPestana.Text = nombreEtapa;

            nuevaPestana.BackColor = Color.White;
            GroupBox groupBox = new GroupBox();
            groupBox.Text = "Datos del candidato";
            groupBox.Size = new Size(500, 60);
            groupBox.Location = new Point(20, 15);

            Label lblNombre = new Label();
            lblNombre.Location = new Point(40, 30);
            lblNombre.Text = "Nombre y Apellido: ";
            Label lblNombreApellido = new Label();
            lblNombreApellido.Location = new Point(150, 30);
            lblNombreApellido.Text = $"{nombre} {apellido}";
            Label lblPuestoT = new Label();
            lblPuestoT.Location = new Point(340, 30);
            lblPuestoT.Size = new Size(50, 20);
            lblPuestoT.Text = "Puesto: ";
            Label lblPuesto = new Label();
            lblPuesto.Location = new Point(400, 30);
            lblPuesto.Text = puesto;

            groupBox.Controls.Add(lblNombre);
            groupBox.Controls.Add(lblNombreApellido);
            groupBox.Controls.Add(lblPuestoT);
            groupBox.Controls.Add(lblPuesto);

            nuevaPestana.Controls.Add(groupBox);

            GroupBox groupBox2 = new GroupBox();
            groupBox2.Text = "Entrevista";
            groupBox2.Size = new Size(400, 200);
            groupBox2.Location = new Point(70, 95);

            Label lblFecha = new Label();
            lblFecha.Text = "Fecha:";
            lblFecha.Location = new Point(20, 30);

            DateTimePicker dtpFecha = new DateTimePicker();
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(150, 30);
            dtpFecha.Tag = "FechaEntrevista";
            dtpFecha.Value = fecha; // Establecer el valor de la fecha

            Label lblArea = new Label();
            lblArea.Text = "Área:";
            lblArea.Size = new Size(50, 20);
            lblArea.Location = new Point(20, 70);

            ComboBox cmbArea = new ComboBox();
            DataTable datosArea = proceso.ObtenerAreas();
            cmbArea.DataSource = datosArea;
            cmbArea.DisplayMember = "area";
            cmbArea.ValueMember = "id_area";
            cmbArea.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbArea.Location = new Point(150, 70);
            cmbArea.Size = new Size(200, 20);

            Label lblEntrevistador = new Label();
            lblEntrevistador.Text = "Entrevistador:";
            lblEntrevistador.Location = new Point(20, 110);

            ComboBox cmbEntrevistador = new ComboBox();
            cmbEntrevistador.Location = new Point(150, 110);
            cmbEntrevistador.Size = new Size(200, 20);
            cmbEntrevistador.Enabled = false;
            cmbEntrevistador.Tag = "Entrevistador";
            cmbEntrevistador.Text = entrevistador; // Establecer el valor del entrevistador

            Label lblEstado = new Label();
            lblEstado.Text = "Estado:";
            lblEstado.Location = new Point(20, 150);

            ComboBox cmbEstado = new ComboBox();
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.Items.AddRange(new string[] { "PROGRAMADA", "APTO", "NO APTO" });
            cmbEstado.Location = new Point(150, 150);
            cmbEstado.Size = new Size(200, 20);
            cmbEstado.SelectedIndex = 0;
            cmbEstado.Tag = "Estado";
            cmbEstado.Text = estado; // Establecer el valor del estado

            groupBox2.Controls.Add(lblFecha);
            groupBox2.Controls.Add(dtpFecha);
            groupBox2.Controls.Add(lblEntrevistador);
            groupBox2.Controls.Add(cmbEntrevistador);
            groupBox2.Controls.Add(lblEstado);
            groupBox2.Controls.Add(cmbEstado);
            groupBox2.Controls.Add(cmbArea);
            groupBox2.Controls.Add(lblArea);

            nuevaPestana.Controls.Add(groupBox2);

            Button btnGuardar = new Button();
            btnGuardar.Text = "Guardar";
            btnGuardar.Location = new Point(390, 300);
            btnGuardar.Size = new Size(80, 30);
            btnGuardar.Click += btnGuardar_Click;

            nuevaPestana.Controls.Add(btnGuardar);
            cmbArea.SelectedIndexChanged += (sender, e) =>
            {
                DataRowView selectedArea = cmbArea.SelectedItem as DataRowView;
                int idAreaSeleccionada = Convert.ToInt32(selectedArea["id_area"]);
                DataTable DTEmpleados = proceso.ObtenerEmpleados(idAreaSeleccionada);
                DTEmpleados.Columns.Add("NombreCompleto", typeof(string), "APELLIDOS + ', ' + NOMBRES");
                cmbEntrevistador.DataSource = DTEmpleados;
                cmbEntrevistador.DisplayMember = "NombreCompleto";
                cmbEntrevistador.Enabled = true;
            };
            return id_persona;
        }
        //private void CargarDatosEnControles(TabPage tab, DateTime fecha, string entrevistador, string estado)
        //{
        //    foreach (Control control in tab.Controls)
        //    {
        //        if (control is DateTimePicker)
        //        {
        //            ((DateTimePicker)control).Value = fecha;
        //        }
        //        else if (control is ComboBox)
        //        {
        //            ComboBox cmb = (ComboBox)control;
        //            if (cmb.Name == "cmbEntrevistador")
        //            {
        //                cmb.SelectedItem = entrevistador;
        //            }
        //            else if (cmb.Name == "cmbEstado")
        //            {
        //                cmb.SelectedItem = estado;
        //            }
        //        }
        //    }
        //}
        //public void SeleccionarPestana(string nombrePestana)
        //{
        //    for (int i = 0; i < tabEtapas.TabPages.Count; i++)
        //    {
        //        if (tabEtapas.TabPages[i].Text == nombrePestana)
        //        {
        //            tabEtapas.SelectedIndex = i;
        //            break;
        //        }
        //    }
        //}
        //public void ActualizarDatos(string nombre, string apellido, string puesto, DateTime fecha)
        //{
        //    lblNombreApellido.Text = $"{nombre} {apellido}";
        //    lblPuesto.Text = puesto;
        //    dtpFecha.Value = fecha;
        //    // Otros controles y datos que necesites actualizar
        //}
        private void cmbEmpleados_DropDown(object sender, EventArgs e)
        {
        }
        private void cmbEstadoEntrevista_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        //private void ActualizarHabilitacionPestanas()
        //{
        //    // Recorre las pestañas y actualiza la habilitación según la selección en el ComboBox de estado
        //    for (int i = 0; i < tabEtapas.TabPages.Count; i++)
        //    {
        //        TabPage tabPage = tabEtapas.TabPages[i];

        //        if (i == tabEtapas.SelectedIndex)
        //        {
        //            // Si es la pestaña actual, actualiza según el ComboBox de estado
        //            ComboBox cmbEstado = tabPage.Controls["cmbEstadoEntrevista"] as ComboBox;

        //            if (cmbEstado != null && cmbEstado.SelectedItem != null)
        //            {
        //                string estado = cmbEstado.Text;

        //                if (estado == "APTO")
        //                {
        //                    // Habilitar la siguiente pestaña
        //                    int nextIndex = i + 1;
        //                    if (nextIndex < tabEtapas.TabPages.Count)
        //                    {
        //                        tabEtapas.TabPages[nextIndex].Enabled = true;
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int id_entrevista = proceso.ObtenerIDEntrevistas(tabEtapas.SelectedTab.ToString().Split('-')[1].TrimEnd('}'));
            int id_persona = this.idCandidato;
            TabPage pestañaActual = tabEtapas.SelectedTab;
            DateTime fechaEntrevista = DateTime.MinValue;
            string entrevistador = "";
            string estado = "";

            // Buscar el GroupBox que contiene los ComboBoxes
            GroupBox groupBoxEntrevista = null;

            foreach (Control control in pestañaActual.Controls)
            {
                if (control is GroupBox groupBox && groupBox.Text == "Entrevista")
                {
                    groupBoxEntrevista = groupBox;
                    break;
                }
            }

            // Si se encuentra el GroupBox de entrevista, buscar los ComboBoxes dentro de él
            if (groupBoxEntrevista != null)
            {
                foreach (Control groupBoxControl in groupBoxEntrevista.Controls)
                {
                    // Buscar el DateTimePicker para la fecha de la entrevista
                    if (groupBoxControl is DateTimePicker dateTimePickerFechaEntrevista)
                    {
                        fechaEntrevista = dateTimePickerFechaEntrevista.Value;
                    }
                    // Buscar el ComboBox para el entrevistador
                    else if (groupBoxControl is ComboBox cmbEntrevistador && cmbEntrevistador.Tag != null && cmbEntrevistador.Tag.ToString() == "Entrevistador")
                    {
                        //entrevistador = cmbEntrevistador.SelectedItem?.ToString() ?? "";
                        if (cmbEntrevistador.SelectedItem is DataRowView)
                        {
                            DataRowView selectedRow = (DataRowView)cmbEntrevistador.SelectedItem;
                            entrevistador = selectedRow["NombreCompleto"].ToString();
                        }
                        else
                        {
                            entrevistador = cmbEntrevistador.SelectedItem.ToString();
                        }
                    }
                    // Buscar el ComboBox para el estado
                    else if (groupBoxControl is ComboBox cmbEstado && cmbEstado.Tag != null && cmbEstado.Tag.ToString() == "Estado")
                    {
                        estado = cmbEstado.SelectedItem?.ToString() ?? "";
                    }
                }
            }

            proceso.InsertarEtapa(id_persona, id_entrevista, fechaEntrevista, entrevistador, estado, null);


            //string entrevistador = cmbEntrevistador.Text;
            //DateTime fechaEtapa = dtpFecha.Value;
            //string estado = cmbEstado.SelectedItem.ToString();
            //string estado = cmbEstadoEntrevista.Text;

            //if (cmbEstadoEntrevista.Text == "APTO")
            //{

            //    if (cmbEstadoEntrevista.SelectedItem == null)
            //    {
            //        MessageBox.Show("Por favor, seleccione un estado.");
            //        return;
            //    }

            //    //string estado = cmbEstadoEntrevista.Text;
            //    proceso.ModificarEstado(idCandidato, estado, null);
            //    MessageBox.Show("Los datos han sido guardados correctamente.");
            //    if (estado == "APTO")
            //    {
            //        tabPreocupacional.Enabled = true;
            //    }
            //    else
            //    {
            //        tabPreocupacional.Enabled = false;
            //    }
            //}
            //else
            //{
            //    proceso.InsertarEtapa(idCandidato, id_entrevista, fecha, entrevistador, estado, null);
            //    MessageBox.Show("Los datos han sido guardados correctamente.");
            //    tabPreocupacional.Enabled = false;
            //}
        }

        private void tabEtapas_Selecting(object sender, TabControlCancelEventArgs e)
        {
        }
        //private void HabilitarPestanaInicial()
        //{
        //    int indexToEnable = 0;

        //    for (int i = 0; i < tabEtapas.TabPages.Count; i++)
        //    {
        //        TabPage tabPage = tabEtapas.TabPages[i];
        //        ComboBox cmbEstado = tabPage.Controls["cmbEstadoEntrevista"] as ComboBox;

        //        if (cmbEstado != null && cmbEstado.SelectedItem != null)
        //        {
        //            string estado = cmbEstado.Text;

        //            if (estado != "APTO")
        //            {
        //                // La pestaña no tiene estado "APTO", así que es la inicial
        //                indexToEnable = i;
        //                break;
        //            }
        //        }
        //    }

        //    tabEtapas.TabPages[indexToEnable].Enabled = true;
        //}

        private void frmEntrevistaPreocupacionalCapacitacion_Load(object sender, EventArgs e)
        {
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
            //cmbEstadoPreocupacional.DataSource = estados;
        }

        private void btnGuardarP_Click(object sender, EventArgs e)
        {
            //int idCandidato = IdCandidato;
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
                //proceso.InsertarEtapa(idCandidato, fecha_etapa, null, null);
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
