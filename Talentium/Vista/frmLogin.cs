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
using Vista.Lenguajes;
using Vista.Properties;

namespace Vista
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            Idioma.CargarIdioma(this.Controls, this); //Asigno los nombres a los controles del formulario
            UtilidadesForms.CargarComboLenguajes(cmbLenguaje);//Llamo al metodo que cargara el ComboBox
            txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CN_LogicaLogin.LogIn(txtUsername.Text, txtPassword.Text))
            {
                if (UserCache.nuevo)
                {
                    //llamar al form que cambia la contraseña.
                    this.Hide();
                    CambioDePassNU CP = new CambioDePassNU();
                    CP.Show();
                }
                else 
                { 
                this.Hide();
                frmMenu menu = new frmMenu();
                menu.Show();
                }
            }
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '\0';
        }

        private void btnMostrar_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmRecupero recupero = new frmRecupero();
            recupero.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cmbLenguaje_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Settings.Default.Idioma = cmbLenguaje.SelectedValue.ToString();//Cargo el idioma seleccionado por el combo
            Settings.Default.Save(); //Guardo el idioma seleccionado para que quede grabado
            Idioma.CargarIdioma(this.Controls, this);//Llamo al metodo que cambiara el idioma en los formularios
        }
    }
}