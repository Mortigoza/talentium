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
using Vista.Gestion_de_Talento;
using Comun;
using Vista.Lenguajes;
using LogicaNegocio.Accesibilidad;

namespace Vista
{
    public partial class frmConsultaProcesoDeSeleccion : Form
    {
        CN_LogicaProcesoSeleccion proceso = new CN_LogicaProcesoSeleccion();
        CN_LogicaEntrevista entrevista = new CN_LogicaEntrevista();
        public DatosCandidato DatosSeleccionados { get; set; }
        private bool filtroUtilizado = false;
        public frmConsultaProcesoDeSeleccion()
        {
            InitializeComponent();
            dtgCandidatos.Columns["ID"].Visible = false;
            dtgCandidatos.AutoGenerateColumns = false;
            dtgCandidatos.AllowUserToAddRows = false;
            dtgCandidatos.MultiSelect = false;
            dtgCandidatos.Enabled = false;
            Idioma.CargarIdioma(this.Controls, this); //Asigno los nombres a los controles del formulario
            int filas = entrevista.CantidadEntrevista();
            dtgCandidatos.Rows.Add(filas);
            DataTable lista = entrevista.ConsultarEntrevistas();
            lista.Columns.Add("Etapas", typeof(string), "Etapa + '-' + Entrevista");
            for (int i = 0; i < filas; i++)
            {
                dtgCandidatos.Rows[i].Cells["Etapa"].Value = lista.Rows[i]["Etapas"];
            }

        }
        private void txtCuilCuit_Leave(object sender, EventArgs e)
        {
            string cuil = txtCuilCuit.Text.Trim();
            if (cuil.Length != 11 && cuil != "")
            {
                MessageBox.Show("El cuil ingresado no tiene un formato correcto.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCuilCuit.Focus();
            }
        }
        private void cmbPuesto_TextChanged(object sender, EventArgs e)
        {
        }

        private void cmbEtapa_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtCuilCuit_TextChanged(object sender, EventArgs e)
        {
            filtroUtilizado = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!filtroUtilizado)
            {
                MessageBox.Show("Por favor, introduzca el Cuil para la búsqueda.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dtgCandidatos.Enabled = true;
                dtgCandidatos.ReadOnly = true;
                string cuil = string.IsNullOrEmpty(txtCuilCuit.Text) ? null : txtCuilCuit.Text;
                DataTable DTCandidatos = proceso.ObtenerCandidatosFiltros(cuil);
                if (DTCandidatos != null && DTCandidatos.Rows.Count > 0)
                {
                    bool todasCoinciden = true;
                    int numFilasDataGridView = dtgCandidatos.Rows.Count;

                    for (int i = 0; i < DTCandidatos.Rows.Count; i++)
                    {
                        if (i < numFilasDataGridView)
                        {
                            string etapaDataTable = DTCandidatos.Rows[i]["Etapa"].ToString();
                            string etapaDataGridView = dtgCandidatos.Rows[i].Cells["Etapa"].Value.ToString();

                            if (etapaDataTable != etapaDataGridView)
                            {
                                todasCoinciden = false;
                                break;
                            }

                            for (int j = 0; j < dtgCandidatos.Columns.Count; j++)
                            {
                                string nombreColumna = dtgCandidatos.Columns[j].Name;
                                if (nombreColumna != "Etapa")
                                {
                                    if (nombreColumna == "Fecha_Entrevista")
                                    {
                                        string valorFecha = DTCandidatos.Rows[i][nombreColumna].ToString();
                                        DateTime fechaEntrevista;
                                        if (DateTime.TryParse(valorFecha, out fechaEntrevista))
                                        {
                                            dtgCandidatos.Rows[i].Cells[nombreColumna].Value = fechaEntrevista;
                                        }
                                        else
                                        {
                                            dtgCandidatos.Rows[i].Cells[nombreColumna].Value = DateTime.MinValue;
                                        }
                                    }
                                    else
                                    {
                                        dtgCandidatos.Rows[i].Cells[nombreColumna].Value = DTCandidatos.Rows[i][nombreColumna].ToString();
                                    }
                                }
                            }
                        }
                        else
                        {
                            DataGridViewRow nuevaFila = new DataGridViewRow();
                            nuevaFila.CreateCells(dtgCandidatos);
                            dtgCandidatos.Rows.Add(nuevaFila);

                            for (int j = 0; j < dtgCandidatos.Columns.Count; j++)
                            {
                                string nombreColumna = dtgCandidatos.Columns[j].Name;
                                if (nombreColumna != "Etapa")
                                {
                                    dtgCandidatos.Rows[i].Cells[nombreColumna].Value = DTCandidatos.Rows[i][nombreColumna].ToString();
                                }
                            }
                        }
                    }
                    lblNombreLlenar.Text = DTCandidatos.Rows[0]["Nombre"].ToString();
                    lblApellidoLlenar.Text = DTCandidatos.Rows[0]["Apellido"].ToString();
                    lblCuilLlenar.Text = DTCandidatos.Rows[0]["Cuit"].ToString();

                    if (!todasCoinciden)
                    {
                        MessageBox.Show("Las etapas no coinciden. No se puede completar el DataGridView.");
                    }
                }
                else
                {
                    MessageBox.Show("No hay resultados que coincidan con la búsqueda.");
                }
            }
        }

        private void cmbPuesto_DropDown(object sender, EventArgs e)
        {
        }

        private void cmbEtapa_DropDown(object sender, EventArgs e)
        {
        }

        public void CargarColumnasDataGrid()
        {
            dtgCandidatos.Columns["Estado"].DataPropertyName = "Estado";
            dtgCandidatos.Columns["Puesto"].DataPropertyName = "Puesto";
            dtgCandidatos.Columns["Fecha_Entrevista"].DataPropertyName = "Fecha_Entrevista";
            dtgCandidatos.Columns["Entrevistador"].DataPropertyName = "Entrevistador";
            dtgCandidatos.Columns["ID"].DataPropertyName = "ID";
        }

        private void dtgCandidatos_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgCandidatos.SelectedRows.Count > 0)
            {
                object fechaEntrevista = dtgCandidatos.SelectedRows[0].Cells["Fecha_Entrevista"].Value;

                if (fechaEntrevista == null || fechaEntrevista == DBNull.Value || string.IsNullOrWhiteSpace(fechaEntrevista.ToString()))
                {
                    btnEtapas.Enabled = false;
                }
                else
                {
                    btnEtapas.Enabled = true;
                }
            }
            else
            {
                btnEtapas.Enabled = false;
            }
        }
        private void btnEtapas_Click(object sender, EventArgs e)
        {
            if (dtgCandidatos.SelectedRows.Count > 0)
            {
                DataGridViewRow seleccionado = dtgCandidatos.SelectedRows[0];
                int id = Convert.ToInt32(seleccionado.Cells["ID"].Value);
                frmEntrevistaPreocupacionalCapacitacion formularioPestañas = new frmEntrevistaPreocupacionalCapacitacion();
                MostrarFormularioPestañas(formularioPestañas, id);
            }


        }
        private void MostrarFormularioPestañas(frmEntrevistaPreocupacionalCapacitacion formulario, int idPersona)
        {
            DataTable entrevistasPersona = proceso.ObtenerDatosEtapas(idPersona);

            DataTable todasLasEtapas = entrevista.ConsultarEntrevistas();
            todasLasEtapas.Columns.Add("Etapas", typeof(string), "Etapa + '-' + Entrevista");

            formulario.tabEtapas.TabPages.Clear();

            foreach (DataRow etapa in todasLasEtapas.Rows)
            {
                string nombreEtapa = $"{etapa["Etapas"]}";

                TabPage nuevaPestana = new TabPage();
                nuevaPestana.Text = nombreEtapa;

                DataRow[] datosEtapa = entrevistasPersona.Select($"Etapa = '{nombreEtapa}'");

                if (datosEtapa.Length > 0)
                {
                    string nombre = datosEtapa[0]["Nombre"].ToString();
                    string apellido = datosEtapa[0]["Apellido"].ToString();
                    string puesto = datosEtapa[0]["Puesto"].ToString();
                    DateTime fecha = (DateTime)datosEtapa[0]["Fecha_Entrevista"];
                    string entrevistador = datosEtapa[0]["Entrevistador"].ToString();
                    string estado = datosEtapa[0]["Estado"].ToString();
                    if (estado == "APTO" || estado == "NO APTO")
                    {
                        nuevaPestana.Enabled = false;
                    }

                    formulario.AgregarControlesEnTab(nombreEtapa, nombre, apellido, puesto, estado, fecha, entrevistador, nuevaPestana, idPersona);
                }
                else
                {
                    DataTable datos = proceso.ConsultarCandidato(idPersona);

                    if (datos.Rows.Count > 0)
                    {
                        DataRow row = datos.Rows[0];

                        string nombre = row["nombres"].ToString();
                        string apellido = row["apellidos"].ToString();
                        string puesto = row["puesto"].ToString();
                        formulario.AgregarControlesEnTab(nombreEtapa, nombre, apellido, puesto, "", DateTime.Now, "", nuevaPestana, idPersona);
                    }
                }
                formulario.tabEtapas.TabPages.Add(nuevaPestana);
                
            }
            formulario.Show();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dtgCandidatos.SelectedRows.Count > 0)
            {
                frmModificarProcesoDeSeleccion formModificar = new frmModificarProcesoDeSeleccion(DatosCandidato());
                formModificar.ShowDialog();
                FrmModificarProcesoDeSeleccion_DataGridUpdated();
            }
            else
            {
                MessageBox.Show("Selecciona una fila antes de abrir el formulario.");
            }
        }
        public void FrmModificarProcesoDeSeleccion_DataGridUpdated()
        {
            //// Actualiza el DataGridView, por ejemplo, volviendo a cargar los datos.
            //string cuil = string.IsNullOrEmpty(txtCuilCuit.Text) ? null : txtCuilCuit.Text;
            //int id_puesto = cmbPuesto.SelectedValue != null ? (int)cmbPuesto.SelectedValue : -1;
            //string etapa = string.IsNullOrEmpty(cmbEtapa.SelectedItem as string) ? null : cmbEtapa.SelectedValue as string;
            //DataTable DTCandidatos = proceso.ObtenerCandidatosFiltros(cuil, id_puesto, etapa);
            //dtgCandidatos.DataSource = DTCandidatos;
            //for (int i = 0; i < dtgCandidatos.Rows.Count - 1; i++)
            //{
            //    int id = Convert.ToInt32(DTCandidatos.Rows[i]["ID"]);
            //    dtgCandidatos.Rows[i].Tag = id;
            //}
            //CargarColumnasDataGrid();
        }

        private void btnIngresarEmpleado_Click(object sender, EventArgs e)
        {
            if (dtgCandidatos.SelectedRows.Count > 0)
            {
                DatosCandidato();
                //frmAltaPersonal frmAltaPersonal = new frmAltaPersonal();
                //frmAltaPersonal.ShowDialog();
            }
        }

        private DatosCandidato DatosCandidato()
        {
            DataGridViewRow filaSeleccionada = dtgCandidatos.SelectedRows[0];

            DatosCandidato datosSeleccionados = new DatosCandidato
            {
                CuilCuit = filaSeleccionada.Cells["Cuil"].Value.ToString(),
                Nombre = filaSeleccionada.Cells["Nombre"].Value.ToString(),
                Apellido = filaSeleccionada.Cells["Apellido"].Value.ToString(),
                Celular = filaSeleccionada.Cells["Celular"].Value.ToString(),
                Alternativo = filaSeleccionada.Cells["Alternativo"].Value.ToString(),
                Correo = filaSeleccionada.Cells["Correo"].Value.ToString(),
                Nacimiento = Convert.ToDateTime(filaSeleccionada.Cells["Nacimiento"].Value),
                Provincia = filaSeleccionada.Cells["Provincia"].Value.ToString(),
                Partido = filaSeleccionada.Cells["Partido"].Value.ToString(),
                Localidad = filaSeleccionada.Cells["Localidad"].Value.ToString(),
                Calle = filaSeleccionada.Cells["Calle"].Value.ToString(),
                Nro = Convert.ToInt32(filaSeleccionada.Cells["Nro"].Value),
                Piso = filaSeleccionada.Cells["Piso"].Value.ToString(),
                Dpto = filaSeleccionada.Cells["Dpto"].Value.ToString(),
                Puesto = filaSeleccionada.Cells["Puesto"].Value.ToString()
            };

            return datosSeleccionados;
        }

        private void frmConsultaProcesoDeSeleccion_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
