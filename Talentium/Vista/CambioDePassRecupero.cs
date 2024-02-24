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
    public partial class CambioDePassRecupero : Form
    {
        private string rta;
        private bool allow = false;
        public CambioDePassRecupero()
        {
            InitializeComponent();
            Idioma.CargarIdioma(this.Controls, this); //Asigno los nombres a los controles del formulario
            CN_PoliticaPassword config = new CN_PoliticaPassword();
            config.ConsultaPoliticaPass();
        
        }

        private void CambioDePass_Load(object sender, EventArgs e)
        { 
            
            int idPregunta;
            CN_CambarPassword pass = new CN_CambarPassword();

            DataTable rtaUsuarios = pass.ObtenerRespuetasUsuarios(UserCache.id);//pasar el id por el userCache
            rta = rtaUsuarios.Rows[0][3].ToString().Trim();
            idPregunta = (int)rtaUsuarios.Rows[0][1];
             DataTable pregUsuarios = pass.ObtenerPregutasUsuarios(idPregunta);   
             comboBox1.DisplayMember = "pregunta";
             comboBox1.DataSource = pregUsuarios;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void continuar_Click(object sender, EventArgs e)
        {
            CN_CambarPassword pass = new CN_CambarPassword();
            if (string.IsNullOrEmpty(tbContra1.Text) || string.IsNullOrEmpty(tbContra2.Text)) 
            {
                MessageBox.Show(Errores.CamposIncompletos);
            }else {

                if (tbContra1.Text == tbContra2.Text)
                {
                    if (comboBox1.SelectedItem != null && respuesta.Text.ToUpper() == rta && allow)
                    {
                        // se realiza el update de la nueva pass y se hashea la misma. 
                        pass.insertarPass(UserCache.usuario, tbContra2.Text);
                        this.Dispose();
                    }
                }
                else
                {
                    MessageBox.Show(Errores.PasNoIgual);
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
                continuar.Enabled = true;
            }
            else
            {
                lblError.Visible = true;
                continuar.Enabled = false;
                lblError.Text = "";
                foreach (string error in CN_Validaciones.GetMensajeErrorLabel())
                {
                    lblError.Text = lblError.Text + error + "\n";
                }
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
