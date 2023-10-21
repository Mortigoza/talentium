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
namespace Vista
{
    public partial class CambioDePassNU : Form
    {
        CN_CambarPassword pass = new CN_CambarPassword();
        public CambioDePassNU()
        {
            InitializeComponent();
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
                MessageBox.Show("Los campos no deben estar vacios");
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

                            MessageBox.Show("Operación realizada con éxito");
                            this.Hide();
                            frmLogin login = new frmLogin();
                            login.Show();
                       

                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }
            }
        }

        private void tbContra1_Leave(object sender, EventArgs e)
        {
            if (CN_Validaciones.ValCar(tbContra1.Text, ConfigCache.caracteres, ConfigCache.mayusculas,
                ConfigCache.numeros, ConfigCache.especiales, ConfigCache.passAnteriores, ConfigCache.noDatosPersonales))
            {
                lblError.Visible = false;
            }
            else
            {
                lblError.Visible = true;
                lblError.Text = CN_Validaciones.GetMensajeErrorLabel();
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
    }
}
