﻿using System;
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
            CargarDatos();
        }
        public void CargarDatos()
        {
            btnModificarCandidato.Enabled = true;
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
            if (dtgCandidatos.Rows.Count > 0)
            {
                int ultimaFilaIndex = dtgCandidatos.Rows.Count - 1;

                // Verifica si la celda "Estado" de la última fila no es nula antes de intentar acceder a su valor
                if (dtgCandidatos.Rows[ultimaFilaIndex].Cells["Estado"].Value != null)
                {
                    string estado = dtgCandidatos.Rows[ultimaFilaIndex].Cells["Estado"].Value.ToString();

                    if (estado == "APTO")
                    {
                        btnIngresarEmpleado.Enabled = true;
                    }
                    else
                    {
                        btnIngresarEmpleado.Enabled = false;
                    }
                }
                else
                {
                    // Si la celda es nula, deshabilita el botón
                    btnIngresarEmpleado.Enabled = false;
                }
            }
            else
            {
                btnIngresarEmpleado.Enabled = false;
            }
        }
        private void cmbPuesto_DropDown(object sender, EventArgs e)
        {
        }

        private void cmbEtapa_DropDown(object sender, EventArgs e)
        {
        }

        public void ActualizarDataGrid()
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
            bool etapaAnteriorConDatos = true;

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

                    if (estado == "APTO")
                    {
                        nuevaPestana.Enabled = false;
                    }
                    if (estado == "NO APTO")
                    {
                        formulario.tabEtapas.Enabled = false;
                        etapaAnteriorConDatos = false;
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

                        if (etapaAnteriorConDatos)
                        {
                            formulario.AgregarControlesEnTab(nombreEtapa, nombre, apellido, puesto, "", DateTime.Now, "", nuevaPestana, idPersona);
                        }
                        else
                        {
                            nuevaPestana.Enabled = false;
                        }
                    }
                }
                formulario.tabEtapas.TabPages.Add(nuevaPestana);
                etapaAnteriorConDatos = datosEtapa.Length > 0;
            }
            formulario.Show();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            bool esCandidato = true;
            frmAltaPersonal altaEmpleado = new frmAltaPersonal(esCandidato);
            string cuil = txtCuilCuit.Text;
            DataTable DTCandidatos = proceso.ObtenerCandidatosFiltros(cuil);
            int id_persona = (int)DTCandidatos.Rows[0]["ID"];
            altaEmpleado.CargarDatosModificacion(id_persona);
            altaEmpleado.cmbConvenio.Enabled = false;
            altaEmpleado.Show();
        }
        public void FrmModificarProcesoDeSeleccion_DataGridUpdated()
        {
        }
        private void btnIngresarEmpleado_Click(object sender, EventArgs e)
        {
            bool esCandidato = false;
            frmAltaPersonal altaEmpleado = new frmAltaPersonal(esCandidato);
            string cuil = txtCuilCuit.Text;
            DataTable DTCandidatos = proceso.ObtenerCandidatosFiltros(cuil);
            int id_persona = (int)DTCandidatos.Rows[0]["ID"];
            
            altaEmpleado.CargarDatosModificacion(id_persona);
            altaEmpleado.dttFechaAlta.Enabled = true;
            altaEmpleado.dttFechaAlta.Value = DateTime.Today;
            altaEmpleado.Show();
        }
        private void frmConsultaProcesoDeSeleccion_Load(object sender, EventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void txtCuilCuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) 
            {
                e.Handled = true;
            }
        }
    }
}
