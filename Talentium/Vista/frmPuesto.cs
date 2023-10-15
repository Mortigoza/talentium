using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio.Accesibilidad;
using Vista.Lenguajes;

namespace Vista
{
    public partial class frmPuesto : Form
    {
        CN_LogicaPuestos puesto = new CN_LogicaPuestos();
        public frmPuesto()
        {
            Idioma.CargarIdioma(this.Controls, this); //Asigno los nombres a los controles del formulario
            InitializeComponent();

            //para que cuando al iniciar el form el boton de cancelar no esté habilitado
            btnCancelarCrear.Enabled = false;
            txtPuestoCrear.TextChanged += txtPuestoCrear_TextChanged;
            btnCancelarModificar.Enabled = false;
            txtPuestoModificar.TextChanged += txtPuestoModificar_TextChanged;
        }

        private void frmPuesto_Load(object sender, EventArgs e)
        {
            DataTable DT = puesto.ObtenerPuestos();
            lstPuestos.DataSource = DT;
            lstPuestos.DisplayMember = "puesto";
        }

        private void btnGuardarCrear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPuestoCrear.Text))
            {
                MessageBox.Show("Debe completar el campo.");
            }
            else if (puesto.validarPuesto(txtPuestoCrear.Text) == false)
            {
                MessageBox.Show("Alta de puesto exitosa.");
                txtPuestoCrear.Clear();
                frmPuesto_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Ese nombre de puesto ya está en uso.");
                txtPuestoCrear.Clear();
            }
        }

        private void btnCancelarCrear_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha cancelado la operación.");
            txtPuestoCrear.Clear();
        }

        private void lstPuestos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataRowView registroSeleccionado = lstPuestos.SelectedItem as DataRowView;

            if (registroSeleccionado != null)
            {
                txtPuestoModificar.Text = registroSeleccionado["puesto"].ToString();
            }
        }

        private void btnGuardarModificar_Click(object sender, EventArgs e)
        {
            int idRegistroSeleccionado = 0;
            string nuevoPuesto = txtPuestoModificar.Text;
            DataRowView registroSeleccionado = lstPuestos.SelectedItem as DataRowView;
            if (registroSeleccionado != null)
            {
                idRegistroSeleccionado = Convert.ToInt32(registroSeleccionado["id_puesto"]);
            }

            if (string.IsNullOrWhiteSpace(nuevoPuesto))
            {
                MessageBox.Show("Debe completar el campo.");
            }
            else if (puesto.ModificarPuesto(idRegistroSeleccionado, nuevoPuesto) == false)
            {
                MessageBox.Show("Modificación de puesto exitosa");
                txtPuestoModificar.Clear();
                frmPuesto_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Ese nombre de puesto ya está en uso.");
                txtPuestoModificar.Clear();
            }
        }

        private void btnCancelarModificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha cancelado la operación.");
            txtPuestoModificar.Clear();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            int idRegistroSeleccionado = 0;
            DataRowView registroSeleccionado = lstPuestos.SelectedItem as DataRowView;
            if (registroSeleccionado != null)
            {
                idRegistroSeleccionado = Convert.ToInt32(registroSeleccionado["id_puesto"]);
                if (puesto.AsociadoAPersona(idRegistroSeleccionado) == true)
                {
                    MessageBox.Show("No se puede eliminar el puesto porque se encuentra en uso.");
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("¿Quieres eliminar el puesto?", "Confirmar eliminación", MessageBoxButtons.OKCancel);

                    if (resultado == DialogResult.OK)
                    {
                        puesto.EliminarPuesto(idRegistroSeleccionado);
                        MessageBox.Show("El puesto ha sido eliminado con éxito.");
                        frmPuesto_Load(sender, e);
                    }
                    else if (resultado == DialogResult.Cancel)
                    {
                        MessageBox.Show("Se ha cancelado la operación.");
                    }

                }

            }
        }

        private void txtPuestoCrear_TextChanged(object sender, EventArgs e)
        {
            bool estaCompleto = !string.IsNullOrWhiteSpace(txtPuestoCrear.Text);
            btnCancelarCrear.Enabled = estaCompleto;
        }

        private void txtPuestoModificar_TextChanged(object sender, EventArgs e)
        {
            bool estaCompletoModif = !string.IsNullOrWhiteSpace(txtPuestoModificar.Text);
            btnCancelarModificar.Enabled = estaCompletoModif;
        }
    }
}
