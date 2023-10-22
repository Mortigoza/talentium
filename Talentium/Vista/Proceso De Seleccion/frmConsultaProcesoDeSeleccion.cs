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

namespace Vista
{
    public partial class frmConsultaProcesoDeSeleccion : Form
    {
        CN_LogicaProcesoSeleccion proceso = new CN_LogicaProcesoSeleccion();
        public DatosCandidato DatosSeleccionados { get; set; }
        public frmConsultaProcesoDeSeleccion()
        {
            InitializeComponent();
            
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

        private bool filtroUtilizado = false;

        private void cmbPuesto_TextChanged(object sender, EventArgs e)
        {
            filtroUtilizado = true;
        }

        private void cmbEtapa_TextChanged(object sender, EventArgs e)
        {
            filtroUtilizado = true;
        }

        private void txtCuilCuit_TextChanged(object sender, EventArgs e)
        {
            filtroUtilizado = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!filtroUtilizado)
            {
            
                MessageBox.Show("Por favor, utiliza al menos un filtro para la búsqueda.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                dtgCandidatos.AutoGenerateColumns = false;
                string cuil = string.IsNullOrEmpty(txtCuilCuit.Text) ? null : txtCuilCuit.Text;
                int id_puesto = cmbPuesto.SelectedValue != null ? (int)cmbPuesto.SelectedValue : -1;
                string etapa = string.IsNullOrEmpty(cmbEtapa.SelectedItem as string) ? null : cmbEtapa.SelectedItem as string;
                DataTable DTCandidatos = proceso.ObtenerCandidatosFiltros(cuil, id_puesto, etapa);
                dtgCandidatos.DataSource = DTCandidatos;
                for (int i = 0; i < dtgCandidatos.Rows.Count-1; i++)
                {
                    int id = Convert.ToInt32(DTCandidatos.Rows[i]["id_candidato"]);
                    dtgCandidatos.Rows[i].Tag = id;
                }
                CargarColumnasDataGrid();
            }
        }

        private void cmbPuesto_DropDown(object sender, EventArgs e)
        {
            cmbPuesto.DataSource = proceso.ObtenerPuestos();
            cmbPuesto.DisplayMember = "puesto";
            cmbPuesto.ValueMember = "id_puesto";
        }

        private void cmbEtapa_DropDown(object sender, EventArgs e)
        {
            List<string> lista = new List<string>{"Primera entrevista", "Segunda entrevista", "Preocupacional"};
            cmbEtapa.DataSource = lista;
        }

        public void CargarColumnasDataGrid()
        {
            dtgCandidatos.Columns["Etapa"].DataPropertyName = "etapa";
            dtgCandidatos.Columns["Estado"].DataPropertyName = "estado";
            dtgCandidatos.Columns["Puesto"].DataPropertyName = "nombre_puesto";
            dtgCandidatos.Columns["Cuil"].DataPropertyName = "cuit_cuil";
            dtgCandidatos.Columns["Nombre"].DataPropertyName = "nombres";
            dtgCandidatos.Columns["Apellido"].DataPropertyName = "apellidos";
            dtgCandidatos.Columns["Celular"].DataPropertyName = "tel_celular";
            dtgCandidatos.Columns["Alternativo"].DataPropertyName = "tel_alternativo";
            dtgCandidatos.Columns["Correo"].DataPropertyName = "correo";
            dtgCandidatos.Columns["Nacimiento"].DataPropertyName = "fecha_nacimiento";
            dtgCandidatos.Columns["Calle"].DataPropertyName = "calle";
            dtgCandidatos.Columns["Nro"].DataPropertyName = "nro";
            dtgCandidatos.Columns["Piso"].DataPropertyName = "piso";
            dtgCandidatos.Columns["Dpto"].DataPropertyName = "dpto";
            dtgCandidatos.Columns["Localidad"].DataPropertyName = "localidad";
            dtgCandidatos.Columns["CP"].DataPropertyName = "codPos";
            dtgCandidatos.Columns["Partido"].DataPropertyName = "partido";
            dtgCandidatos.Columns["Provincia"].DataPropertyName = "provincia";
        }

        private void dtgCandidatos_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgCandidatos.SelectedRows.Count > 0)
            {
                btnEtapas.Enabled = true;
            }
        }

        private void btnEtapas_Click(object sender, EventArgs e)
        {
            DataGridViewRow seleccionado = dtgCandidatos.SelectedRows[0];
            int idCandidatoSeleccionado = (int)dtgCandidatos.SelectedRows[0].Tag;
            string nombre = seleccionado.Cells["Nombre"].Value.ToString();
            string apellido = seleccionado.Cells["Apellido"].Value.ToString();
            string puesto = seleccionado.Cells["Puesto"].Value.ToString();
            frmEntrevistaPreocupacionalCapacitacion etapas = new frmEntrevistaPreocupacionalCapacitacion(nombre, apellido, puesto, idCandidatoSeleccionado);
            if (dtgCandidatos.SelectedRows.Count > 0)
            {
                string etapa = dtgCandidatos.SelectedRows[0].Cells["Etapa"].Value.ToString();

                if (etapa.Equals("Preocupacional", StringComparison.OrdinalIgnoreCase))
                {
                    etapas.SeleccionarTab(1);
                }
                else if (etapa.Equals("Segunda Entrevista", StringComparison.OrdinalIgnoreCase))
                {
                    etapas.SeleccionarTab(0);
                }
            }
            etapas.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dtgCandidatos.SelectedRows.Count > 0)
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
                frmModificarProcesoDeSeleccion formModificar = new frmModificarProcesoDeSeleccion(datosSeleccionados);
                formModificar.Show();
                //me falta recargar el data grid 
            }
            else
            {
                MessageBox.Show("Selecciona una fila antes de abrir el formulario.");
            }
        }
    }
}
