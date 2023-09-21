using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Evaluacion_de_desempeño;

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

        }

        private void altasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAltaPersonal alta = new frmAltaPersonal();
            alta.Show();
        }

        private void áreasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAreas area = new frmAreas();
            area.Show();
        }

        private void puestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPuesto puestos = new frmPuesto();
            puestos.Show();
        }

        private void crearEvaluacionDeDesempenioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAltaEvaluacionDesempenio evaluacionDesempenio = new frmAltaEvaluacionDesempenio();
            evaluacionDesempenio.Show();
        }
    }
}
