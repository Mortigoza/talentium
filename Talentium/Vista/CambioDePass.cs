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
    public partial class CambioDePass : Form
    {
        public CambioDePass()
        {
            InitializeComponent();
        }

        private void CambioDePass_Load(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void continuar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbContra1.Text) || string.IsNullOrEmpty(tbContra2.Text)) 
            {
                MessageBox.Show("Los campos no deben estar vacios");
            }else { 
                bool valor = CN_CambarPassword.ValidatePassword(tbContra1.Text);
                if (valor)
                {
                    if (tbContra1.Text == tbContra1.Text)
                    {


                    } else 
                    {

                    }
                }
                else
                {
                    MessageBox.Show("La clave debe contener al menos un carácter alfanumérico y al menos un carácter especial, y tener una longitud mínima de 8 caracteres. ");

                }

            }
        }
    }
}
