using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Lenguajes;
using LogicaNegocio;
using Comun;

namespace Vista
{
    public partial class frmAltaProcesoDeSeleccion : Form
    {
        CN_LogicaProcesoSeleccion proceso = new CN_LogicaProcesoSeleccion();
        public frmAltaProcesoDeSeleccion()
        {
            InitializeComponent();
            btnGuardar.Enabled = false;

            
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string cuil = txtCuilCuit.Text.Trim();

            if (string.IsNullOrWhiteSpace(cuil))
            {
                MessageBox.Show("Debe completar el campo.");
            }
            else if (txtCuilCuit.Text.Length < 11)
            {
                MessageBox.Show("Debe ingresar un formato de Cuil/Cuit correcto.");
            }
            //else
            //{
            //    //bool esCuilValido = proceso.ExisteCandidato(cuil);

            //    //if (!esCuilValido)
            //    //{
            //    //    btnGuardar.Enabled = true;
            //    //    foreach (Control control in grpAltaCandidato.Controls)
            //    //    {
            //    //        if (control is ComboBox || control is TextBox || control is DateTimePicker)
            //    //        {
            //    //            control.Enabled = !control.Enabled;
            //    //        }
            //    //    }
            //    //}
            //    else
            //    {
            //        MessageBox.Show("Ese cuil ya está ingresado.");
            //        txtCuilCuit.Clear();
            //    }
            //}
        }

        private void frmAltaProcesoDeSeleccion_Load(object sender, EventArgs e)
        {
            
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool algunCampoSinCompletar = false;
            foreach (Control control in grpAltaCandidato.Controls)
            {


                if (control is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
                {
                    algunCampoSinCompletar = true;
                    break;
                }
            }
            if (algunCampoSinCompletar)
            {
                MessageBox.Show("Por favor, debes completar todos los campos antes de guardar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string cuil = txtCuilCuit.Text;
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

            bool candidatoIngresado = proceso.InsertarCandidato(cuil, nombres, apellidos, tel_celular, tel_alternativo, correo,
                fecha_nacimiento, id_localidad, calle, nro, piso, dpto, id_puesto);

            if (candidatoIngresado)
            {
                MessageBox.Show("Alta de Candidato exitosa.");
                UtilidadesForms.LimpiarControles(grpAltaCandidato);
            }
            else
            {
                MessageBox.Show("El candidato que intenta ingresar ya se encuentra registrado anteriormente.");
            }
            
            Idioma.CargarIdioma(this.Controls, this); //Asigno los nombres a los controles del formulario
        }
    }
}
