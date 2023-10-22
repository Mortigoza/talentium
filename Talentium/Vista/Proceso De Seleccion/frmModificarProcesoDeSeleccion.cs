using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comun;
using LogicaNegocio;

namespace Vista
{
    public partial class frmModificarProcesoDeSeleccion : Form
    {
        private DatosCandidato datosSeleccionados;
        CN_LogicaProcesoSeleccion proceso = new CN_LogicaProcesoSeleccion();
        public frmModificarProcesoDeSeleccion(DatosCandidato datosCandidato)
        {
            InitializeComponent();
            datosSeleccionados = datosCandidato;
            cmbPuesto.DataSource = proceso.ObtenerPuestos();
            cmbProvincia.DataSource = proceso.ObtenerProvincia();
            cmbPuesto.DisplayMember = "puesto";
            cmbPuesto.ValueMember = "id_puesto";
            //cmbLocalidad.DataSource
            cmbProvincia.ValueMember = "Provincia";
            cmbPartido.ValueMember = "Partido";
            //cmbPuesto.DisplayMember = "Puesto";
            //cmbPuesto.ValueMember = "Puesto";

        }

        private void frmModificarProcesoDeSeleccion_Load(object sender, EventArgs e)
        {
            lblCuil.Text = datosSeleccionados.CuilCuit;
            txtNombre.Text = datosSeleccionados.Nombre;
            txtApellido.Text = datosSeleccionados.Apellido;
            txtCelular.Text = datosSeleccionados.Celular;
            txtAlternativo.Text = datosSeleccionados.Alternativo;
            txtCorreo.Text = datosSeleccionados.Correo;
            dtpNacimiento.Value = datosSeleccionados.Nacimiento;
            cmbProvincia.SelectedValue = datosSeleccionados.Provincia;
            cmbPartido.SelectedValue = datosSeleccionados.Partido;
            cmbLocalidad.Text = datosSeleccionados.Localidad;
            txtCalle.Text = datosSeleccionados.Calle;
            txtNro.Text = datosSeleccionados.Nro.ToString();
            txtPiso.Text = datosSeleccionados.Piso;
            txtDpto.Text = datosSeleccionados.Dpto;
            cmbPuesto.Text = datosSeleccionados.Puesto;

            //if (datosSeleccionados.Puesto != null)
            //{
            //    cmbPuesto.SelectedValue = datosSeleccionados.Puesto;
            //}
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool algunCampoSinCompletar = false;
            foreach (Control control in grpModificar.Controls)
            {


                if (control is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
                {
                    algunCampoSinCompletar = true;
                    break;
                }
            }
            if (!algunCampoSinCompletar)
            {
                MessageBox.Show("Por favor, debes completar todos los campos antes de guardar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string cuil = lblCuil.Text;
            string nombres = txtNombre.Text;
            string apellidos = txtApellido.Text;
            string tel_celular = txtCelular.Text;
            string tel_alternativo = txtAlternativo.Text;
            string correo = txtCorreo.Text;
            DateTime fecha_nacimiento = dtpNacimiento.Value;
            int id_localidad = Convert.ToInt32(cmbLocalidad.SelectedValue);
            string calle = txtCalle.Text;
            int nro = Convert.ToInt32(txtNro.Text);
            string piso = txtPiso.Text;
            string dpto = txtDpto.Text;
            int id_puesto = Convert.ToInt32(cmbPuesto.SelectedValue);

            bool candidatoModificado = proceso.ModificarCandidato(cuil, nombres, apellidos, tel_celular, tel_alternativo, correo,
                fecha_nacimiento, id_localidad, calle, nro, piso, dpto, id_puesto);

            if (!candidatoModificado)
            {
                MessageBox.Show("Modificación de Candidato exitosa.");

                Close();
            }
        }

        private void cmbProvincia_DropDown(object sender, EventArgs e)
        {
            cmbProvincia.DataSource = proceso.ObtenerProvincia();
            cmbProvincia.DisplayMember = "provincia";
            cmbProvincia.ValueMember = "id_provincia";
        }

        private void cmbPuesto_DropDown(object sender, EventArgs e)
        {
            cmbPuesto.DataSource = proceso.ObtenerPuestos();
            cmbPuesto.DisplayMember = "puesto";
            cmbPuesto.ValueMember = "id_puesto";
        }

        private void cmbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView provinciaSeleccionada = cmbProvincia.SelectedItem as DataRowView;
            if (provinciaSeleccionada != null)
            {
                int idProvinciaSeleccionada = Convert.ToInt32(provinciaSeleccionada["id_provincia"]);
                DataTable DTPartidos = proceso.ObtenerPartido(idProvinciaSeleccionada);

                if (DTPartidos != null && DTPartidos.Rows.Count > 0)
                {
                    cmbPartido.DataSource = DTPartidos;
                    cmbPartido.DisplayMember = "partido";
                    cmbPartido.ValueMember = "id_partido";
                }
                else
                {
                    cmbPartido.DataSource = null;
                    cmbPartido.Items.Clear();
                }
            }
        }

        private void cmbPartido_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView partidoSeleccionado = cmbPartido.SelectedItem as DataRowView;
            if (partidoSeleccionado != null)
            {
                int idPartidoSeleccionado = Convert.ToInt32(partidoSeleccionado["id_partido"]);
                DataTable DTLocalidades = proceso.ObtenerLocalidad(idPartidoSeleccionado);

                if (DTLocalidades != null && DTLocalidades.Rows.Count > 0)
                {
                    cmbLocalidad.DataSource = DTLocalidades;
                    cmbLocalidad.DisplayMember = "localidad";
                    cmbLocalidad.ValueMember = "id_localidad";
                }
                else
                {
                    cmbLocalidad.DataSource = null;
                    cmbLocalidad.Items.Clear();
                }
            }
        }
    }
}
