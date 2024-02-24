﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio;
using Vista.Lenguajes;

namespace Vista
{
    public partial class frmRecupero : Form
    {
        public frmRecupero()
        {
            InitializeComponent();
            Idioma.CargarIdioma(this.Controls, this); //Asigno los nombres a los controles del formulario
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (!(string.IsNullOrWhiteSpace(textBoxUsuarioRec.Text)))
            {
                CN_LogicaLogin cnRecupero = new CN_LogicaLogin();
                try
                {
                    cnRecupero.UsuarioEmail(textBoxUsuarioRec.Text);
                    string msj = cnRecupero.Message.Substring(5);
                    if (msj == "Error" || msj == "error")
                    {
                        MessageBox.Show(cnRecupero.Message);
                    }
                    else 
                    {
                        label3.Text = cnRecupero.Message;
                        label3.Visible = true;
                        label6.Visible = true;
                        codigo.Visible = true;
                        Verificar.Visible = true;
                        textBoxUsuarioRec.Enabled = false;
                        btnContinuar.Visible = false;
                    }

           // ocultar el boton, disablear el texbox usuario y agregar visible el textbox cod email y el boton verificar cod
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } else
            {
                MessageBox.Show("El campo no debe estar vacio");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CN_LogicaLogin cnRecupero = new CN_LogicaLogin();

            bool valor = cnRecupero.ValidCode(codigo.Text);

            if (valor) 
            {
                this.Hide();
                CambioDePassRecupero cambioDePass =  new CambioDePassRecupero();
                cambioDePass.ShowDialog();
                this.Dispose();
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
