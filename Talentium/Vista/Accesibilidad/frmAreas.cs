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
            if (string.IsNullOrWhiteSpace(txtArea.Text))
            {
                MessageBox.Show("Debe completar los campos.");
            } else if(area.validarArea(txtArea.Text) == false)
            {
                MessageBox.Show("Alta de área exitosa");
                txtArea.Clear();
                frmAreas_Load(sender,e);
            } else
            {
                MessageBox.Show("Ese nombre de área ya está en uso.");
                txtArea.Clear();
            }
        }

        private void lstAreas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataRowView registroSeleccionado = lstAreas.SelectedItem as DataRowView;

            if (registroSeleccionado != null)
            {
                txtModifArea.Text = registroSeleccionado["area"].ToString();
            }
        }

        private void btnGuardarModificar_Click(object sender, EventArgs e)
        {
            int idRegistroSeleccionado =0;
            string nuevaArea = txtModifArea.Text;
            DataRowView registroSeleccionado = lstAreas.SelectedItem as DataRowView;
            if (registroSeleccionado != null)
            {
                idRegistroSeleccionado = Convert.ToInt32(registroSeleccionado["id_area"]);
            }

            if (string.IsNullOrWhiteSpace(nuevaArea))
            {
                MessageBox.Show("Debe completar los campos.");
            }
            else if (area.ModificarArea(idRegistroSeleccionado, nuevaArea) == false)
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
    }
}
