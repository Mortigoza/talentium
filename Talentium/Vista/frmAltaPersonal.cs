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
    public partial class frmAltaPersonal : Form
    {
        public frmAltaPersonal()
        {
            InitializeComponent();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            grbSuperior.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            grbSuperior.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            grbExp1.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            grbExp1.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            grbExp2.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            grbExp2.Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            grbExp3.Visible = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            grbExp3.Visible = false;
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            grbExp2.Visible = true;
        }
    }
}
