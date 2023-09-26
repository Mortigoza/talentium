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
    public partial class frmAltaProcesoDeSeleccion : Form
    {
        CN_LogicaProcesoSeleccion proceso = new CN_LogicaProcesoSeleccion();
        public frmAltaProcesoDeSeleccion()
        {
            InitializeComponent();
            btnGuardar.Enabled = false;
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string cuil = txtCuilCuit.Text.Trim();

            if (string.IsNullOrWhiteSpace(cuil))
            {
                MessageBox.Show("Debe completar el campo.");
            }
            else
            {
                bool esCuilValido = proceso.ExisteCandidato(cuil);

                if (!esCuilValido)
                {
                    foreach (Control control in grpAltaCandidato.Controls)
                    {
                        if (control is ComboBox || control is TextBox)
                        {
                            control.Enabled = !control.Enabled;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ese cuil ya está ingresado.");
                    txtCuilCuit.Clear();
                }
            }
        }
    }
}
