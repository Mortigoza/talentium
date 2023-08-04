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
    public partial class Talentium : Form
    {
        public Talentium()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //    this.Hide();
            frmMenu menu = new frmMenu();
            //    menu.Show();

            CN_LogicaLogin usuario = new CN_LogicaLogin();
            var validlogin = usuario.LoginUser(txtUsername.Text, txtPassword.Text);
            if (validlogin)
            {
                menu.Show();
            }
            Console.WriteLine("datos usuario: "+ validlogin);

        }
    }
}
