using Comun;
using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            CN_LogicaLogin usuario = new CN_LogicaLogin();
            var validlogin = usuario.LoginUser(txtUsername.Text, txtPassword.Text);
            MessageBox.Show("datos usuario: " + validlogin);
            //if (Validaciones.ValUsr(txtUsername.Text, txtPassword.Text))
            //{
            //    this.Hide();
            //    frmMenu menu = new frmMenu();
            //    menu.Show();
            //}
            //else if (Validaciones.GetIntentos() > 0)
            //{
            //    MessageBox.Show("Usuario o contraseña incorrecto.");
            //}
            //else if (Validaciones.GetIntentos() == 0)
            //{
            //    MessageBox.Show($"Limite de intentos alcanzado, intente nuevamente a las {Validaciones.GetHoraDesbloqueo().ToLongTimeString()}");
            //}
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            UtilidadesForms.restaurar(txtUsername);
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            UtilidadesForms.restaurar(txtPassword);
        }
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            UtilidadesForms.TextboxDynamic(txtUsername);
        }
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            UtilidadesForms.TextboxDynamic(txtPassword);
        }
    }
}
