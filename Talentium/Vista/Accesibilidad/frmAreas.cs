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
            } else
            {
                MessageBox.Show("Ese nombre de área ya está en uso.");
                txtArea.Clear();
            }
        }
    }
}
