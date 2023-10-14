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

namespace Vista
{
    public partial class frmConsultaProcesoDeSeleccion : Form
    {
        CN_LogicaProcesoSeleccion proceso = new CN_LogicaProcesoSeleccion();
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
            frmEntrevistaPreocupacionalCapacitacion etapa = new frmEntrevistaPreocupacionalCapacitacion(nombre, apellido, puesto, idCandidatoSeleccionado);
            etapa.Show();
        }
    }
}
