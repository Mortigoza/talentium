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
using Comun;
using LogicaNegocio.Accesibilidad;

namespace Vista
{
    public partial class frmAreas : Form
    {
        CN_LogicaArea area = new CN_LogicaArea();
        public frmAreas()
        {
            InitializeComponent();

            lstAreas.MouseDoubleClick += new MouseEventHandler(lstAreas_MouseDoubleClick);

            //para que cuando al iniciar el form el boton de cancelar no esté habilitado
            btnCancelarCrear.Enabled = false;
            txtArea.TextChanged += txtArea_TextChanged;
            btnCancelarModificar.Enabled = false;
            txtModifArea.TextChanged += txtModifArea_TextChanged;
        }

        private void Áreas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmAreas_Load(object sender, EventArgs e)
        {
            DataTable DT = area.ObtenerAreas();
            lstAreas.DataSource = DT;
            lstAreas.DisplayMember = "area";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // el trim elimina espacios en blanco al principio y al final
            string areaNombre = txtArea.Text.Trim();

            if (string.IsNullOrWhiteSpace(areaNombre))
            {
                MessageBox.Show("Debe completar el campo.");
            }
            else
            {
                bool esAreaValida = area.ValidarArea(areaNombre);

                if (!esAreaValida)
                {
                    MessageBox.Show("Alta de área exitosa.");
                    txtArea.Clear();
                    frmAreas_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Ese nombre de área ya está en uso.");
                    txtArea.Clear();
                }
            }
        }

        private void lstAreas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstAreas.SelectedItem is DataRowView registroSeleccionado)
            {
                txtModifArea.Text = registroSeleccionado["area"].ToString();
            }
        }

        private void btnGuardarModificar_Click(object sender, EventArgs e)
        {
            if (lstAreas.SelectedItem is DataRowView registroSeleccionado)
            {
                int idRegistroSeleccionado = Convert.ToInt32(registroSeleccionado["id_area"]);
                string nuevaArea = txtModifArea.Text.Trim();

                if (string.IsNullOrWhiteSpace(nuevaArea))
                {
                    MessageBox.Show("Debe completar los campos.");
                }
                else
                {
                    bool modificacionExitosa = area.ModificarArea(idRegistroSeleccionado, nuevaArea);

                    if (modificacionExitosa)
                    {
                        MessageBox.Show("Modificación de área exitosa");
                        txtModifArea.Clear();
                        frmAreas_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Ese nombre de área ya está en uso.");
                        txtModifArea.Clear();
                    }
                }
            }
        }

        private void btnCancelarCrear_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha cancelado la operación.");
            txtArea.Clear();
        }

        private void btnCancelarModificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha cancelado la operación.");
            txtModifArea.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int idRegistroSeleccionado = 0;
            DataRowView registroSeleccionado = lstAreas.SelectedItem as DataRowView;
            if (registroSeleccionado != null)
            {
                idRegistroSeleccionado = Convert.ToInt32(registroSeleccionado["id_area"]);
                if (area.AsociadoAPersona(idRegistroSeleccionado) == true)
                {
                    MessageBox.Show("No se puede eliminar el área porque se encuentra en uso.");
                } else
                {
                    DialogResult resultado = MessageBox.Show("¿Quieres eliminar el área?", "Confirmar eliminación", MessageBoxButtons.OKCancel);

                    if (resultado == DialogResult.OK)
                    {
                        area.EliminarArea(idRegistroSeleccionado);
                        MessageBox.Show("El área ha sido eliminada con éxito.");
                        frmAreas_Load(sender, e);
                    }
                    else if (resultado == DialogResult.Cancel)
                    {
                        MessageBox.Show("Se ha cancelado la operación.");
                    }
                }
            }
        }

        private void txtArea_TextChanged(object sender, EventArgs e)
        {
            bool estaCompleto = !string.IsNullOrWhiteSpace(txtArea.Text);
            btnCancelarCrear.Enabled = estaCompleto;
        }

        private void txtModifArea_TextChanged(object sender, EventArgs e)
        {
            bool estaCompletoModif = !string.IsNullOrWhiteSpace(txtModifArea.Text);
            btnCancelarModificar.Enabled = estaCompletoModif;
        }
    }
}
