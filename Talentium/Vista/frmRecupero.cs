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

namespace Vista
{
    public partial class frmRecupero : Form
    {
        public frmRecupero()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (!(string.IsNullOrWhiteSpace(textBoxUsuarioRec.Text)))
            {
                CN_LogicaLogin cnRecupero = new CN_LogicaLogin();
                cnRecupero.usuarioEmail(textBoxUsuarioRec.Text);
            } else
            {
                MessageBox.Show("El campo no debe estar vacio");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmMenu menu = new frmMenu();
            menu.Show();
        }
    }
}
