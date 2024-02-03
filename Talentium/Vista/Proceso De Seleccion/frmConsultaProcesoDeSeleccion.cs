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
            Idioma.CargarIdioma(this.Controls, this); //Asigno los nombres a los controles del formulario
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
                dtgCandidatos.AllowUserToAddRows = false;
                string cuil = string.IsNullOrEmpty(txtCuilCuit.Text) ? null : txtCuilCuit.Text;
                int id_puesto = cmbPuesto.SelectedValue != null ? (int)cmbPuesto.SelectedValue : -1;
                string etapa = string.IsNullOrEmpty(cmbEtapa.SelectedValue as string) ? null : cmbEtapa.SelectedValue as string;
                DataTable DTCandidatos = proceso.ObtenerCandidatosFiltros(cuil, id_puesto, etapa);
                if (DTCandidatos != null && DTCandidatos.Rows.Count>0)
                {
                    dtgCandidatos.DataSource = DTCandidatos;
                    for (int i = 0; i < dtgCandidatos.Rows.Count; i++)
                    {
                        int idUnico = Convert.ToInt32(dtgCandidatos.Rows[i].Cells["ID"].Value);
                        dtgCandidatos.Rows[i].Tag = idUnico;
                    }
                    CargarColumnasDataGrid();
                } else
                {
                    MessageBox.Show("No hay resultados que coincidan con la búsqueda.");
                }
                
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
            DataTable lista = entrevista.ConsultarEntrevistas();
            lista.Columns.Add("Etapas", typeof(string), "Etapa + '-' + Entrevista");
            cmbEtapa.DataSource = lista;
            cmbEtapa.DisplayMember = "Etapas";
            cmbEtapa.ValueMember = "Etapas";
        }

        public void CargarColumnasDataGrid()
        {
            dtgCandidatos.Columns["Etapa"].DataPropertyName = "Etapa";
            dtgCandidatos.Columns["Estado"].DataPropertyName = "Estado";
            dtgCandidatos.Columns["Puesto"].DataPropertyName = "Puesto";
            dtgCandidatos.Columns["Cuil"].DataPropertyName = "Cuit";
            dtgCandidatos.Columns["Nombre"].DataPropertyName = "Nombre";
            dtgCandidatos.Columns["Apellido"].DataPropertyName = "Apellido";
            dtgCandidatos.Columns["ID"].DataPropertyName = "ID";
        }

        private void dtgCandidatos_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgCandidatos.SelectedRows.Count > 0)
            {
                btnEtapas.Enabled = true;
                btnModificarCandidato.Enabled = true;
                DataGridViewRow seleccionada = dtgCandidatos.SelectedRows[0];

                //if (seleccionada.Cells["Etapa"].Value.ToString() == "Preocupacional")
                //{
                //    if (seleccionada.Cells["Estado"].Value.ToString() == "APTO")
                //    {
                //        btnIngresarEmpleado.Enabled = true;
                //        return;
                //    } else
                //    {
                //        btnIngresarEmpleado.Enabled = false;
                //    }
                    
                //}
            }
        }

        private void btnEtapas_Click(object sender, EventArgs e)
        {
            DataGridViewRow seleccionado = dtgCandidatos.SelectedRows[0];
            int id = (int)dtgCandidatos.SelectedRows[0].Tag;
            string nombre = seleccionado.Cells["Nombre"].Value.ToString();
            string apellido = seleccionado.Cells["Apellido"].Value.ToString();
            string puesto = seleccionado.Cells["Puesto"].Value.ToString();
            frmEntrevistaPreocupacionalCapacitacion etapas = new frmEntrevistaPreocupacionalCapacitacion(nombre, apellido, puesto, id);
            
            //if (dtgCandidatos.SelectedRows.Count > 0)
            //{
            //    string etapa = dtgCandidatos.SelectedRows[0].Cells["Etapa"].Value.ToString();

            //    if (etapa.Equals("Preocupacional", StringComparison.OrdinalIgnoreCase))
            //    {
            //        etapas.SeleccionarTab(1);
            //    }
            //    else if (etapa.Equals("Segunda Entrevista", StringComparison.OrdinalIgnoreCase))
            //    {
            //        etapas.SeleccionarTab(0);
            //    }
            //}
            etapas.Show();
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
            // Actualiza el DataGridView, por ejemplo, volviendo a cargar los datos.
            string cuil = string.IsNullOrEmpty(txtCuilCuit.Text) ? null : txtCuilCuit.Text;
            int id_puesto = cmbPuesto.SelectedValue != null ? (int)cmbPuesto.SelectedValue : -1;
            string etapa = string.IsNullOrEmpty(cmbEtapa.SelectedItem as string) ? null : cmbEtapa.SelectedValue as string;
            DataTable DTCandidatos = proceso.ObtenerCandidatosFiltros(cuil, id_puesto, etapa);
            dtgCandidatos.DataSource = DTCandidatos;
            for (int i = 0; i < dtgCandidatos.Rows.Count - 1; i++)
            {
                int id = Convert.ToInt32(DTCandidatos.Rows[i]["ID"]);
                dtgCandidatos.Rows[i].Tag = id;
            }
            CargarColumnasDataGrid();
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
    }
}
