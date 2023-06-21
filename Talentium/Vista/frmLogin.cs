using Comun;
using LogicaNegocio;
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
    public partial class Talentium : Form
    {
        public Talentium()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Validaciones.ValUsr(txtUsername.Text, txtPassword.Text))
            {
                this.Hide();
                frmMenu menu = new frmMenu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecto.");
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            UtilidadesForms.Prueba(txtUsername, this);
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            UtilidadesForms.Prueba(txtPassword, this);
        }
    }
}
