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
using static System.Net.Mime.MediaTypeNames;

namespace Vista
{
    public partial class Talentium : Form
    {
        public Talentium()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Validaciones.camposVacios(txtUsername.Text, txtPassword.Text))
            {
                CN_LogicaLogin login = new CN_LogicaLogin();
                try
                {
                    login.LoginUser(txtUsername.Text, txtPassword.Text);
                    MessageBox.Show($"{userCache.id} {userCache.idPersona} {userCache.usuario} {userCache.password}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El usuario o la contraseña son incorrectos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (Validaciones.GetIntentos() > 0)
            {
                MessageBox.Show("Hay campos incompletos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Validaciones.GetIntentos() == 0)
            {
                MessageBox.Show($"Limite de intentos alcanzado, intente nuevamente a las {Validaciones.GetHoraDesbloqueo().ToLongTimeString()}");
            }
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

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '\0';
        }

        private void btnMostrar_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
    }
}
