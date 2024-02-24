using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comun;
using LogicaNegocio;
using LogicaNegocio.Lenguajes;
using Vista.Lenguajes;

namespace Vista
{
    public partial class CambioDePassNU : Form
    {
        CN_CambarPassword pass = new CN_CambarPassword();
        private bool allow = false;
        public CambioDePassNU()
        {
            InitializeComponent();
            Idioma.CargarIdioma(this.Controls, this); //Asigno los nombres a los controles del formulario
            CN_PoliticaPassword config = new CN_PoliticaPassword();
            config.ConsultaPoliticaPass();
        }

        private void CambioDePassNU_Load(object sender, EventArgs e)
        {
            

            DataTable preguntas = pass.ObtenerTodasPregutasSeg();
            comboBox1.DisplayMember = "pregunta";
            comboBox1.DataSource = preguntas;
        }

        private void continuar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbContra1.Text) || string.IsNullOrEmpty(tbContra2.Text))
            {
                MessageBox.Show(Errores.CamposIncompletos, Errores.Aviso, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                if (tbContra1.Text == tbContra2.Text)
                {
                    if (comboBox1.SelectedItem != null)
                    {
                         DataRowView selectedRow = (DataRowView)comboBox1.SelectedItem;
                        int id = Convert.ToInt32(selectedRow["id_pregunta"]);
                        
                        string rta = respuesta.Text.ToUpper();

                        // Se realiza el insert de las respuestas y preguntas.
                        pass.insertarRta(UserCache.id, rta, id);

                        // se realiza el update de la nueva pass y se hashea la misma. 
                        pass.insertarPass(UserCache.usuario, tbContra2.Text);
                        this.Dispose();
                    }
                }
                else
                {
                    MessageBox.Show(Errores.PasNoIgual, Errores.Aviso, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void tbContra1_Leave(object sender, EventArgs e)
        {
            allow = (CN_Validaciones.ValCar(tbContra1.Text, ConfigCache.caracteres, ConfigCache.mayusculas,
                ConfigCache.numeros, ConfigCache.especiales, ConfigCache.passAnteriores, ConfigCache.noDatosPersonales));

            if (allow)
            {
                lblError.Visible = false;
            }
            else
            {
                lblError.Visible = true;
                lblError.Text = "";
                foreach (string error in CN_Validaciones.GetMensajeErrorLabel())
                {
                    lblError.Text = lblError.Text + error + "\n";
                }
            }
        }

        private void lblError_Click(object sender, EventArgs e)
        {

        }

        private void tbContra1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbContra1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void tbContra2_TextChanged(object sender, EventArgs e)
        {

        }

        private void respuesta_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbContra1_TextChanged_2(object sender, EventArgs e)
        {

        }
    }
}
