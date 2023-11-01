using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConsultaPersonal alta = new frmConsultaPersonal();
            alta.Show();
        }

        private void altasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAltaPersonal alta = new frmAltaPersonal();
            alta.Show();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConsultaPersonal alta = new frmConsultaPersonal();
            alta.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
