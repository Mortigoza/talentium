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
    public partial class frmConsultaPersonal : Form
    {
        public frmConsultaPersonal()
        {
            InitializeComponent();
        }

        private void frmConsultaPersonal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            frmAltaPersonal frmAltaPersonal = new frmAltaPersonal();
            frmAltaPersonal.ShowDialog();
        }
    }
}
