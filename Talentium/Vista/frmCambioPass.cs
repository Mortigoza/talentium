using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comun;
using DocumentFormat.OpenXml.Wordprocessing;
using LogicaNegocio;
using LogicaNegocio.Lenguajes;
using Vista.Lenguajes;

namespace Vista
{
    public partial class frmCambioPass : Form
    {
        CN_CambiarPassword pass = new CN_CambiarPassword();
        private string rta;
        private bool allow = false;
        private bool _esNuevo = false;
        public frmCambioPass(bool esNuevo = false)
        {
            InitializeComponent();
            Idioma.CargarIdioma(this.Controls, this); //Asigno los nombres a los controles del formulario
            _esNuevo = esNuevo;
            CN_PoliticaPassword config = new CN_PoliticaPassword();
            config.ConsultaPoliticaPass();
        }
        private void CambioDePass_Load(object sender, EventArgs e)
        {
            DataTable preguntas;
            switch (_esNuevo)
            {
                default:
                    btnAtras.Visible = true;
                    int idPregunta;
                    DataTable rtaUsuarios = pass.ObtenerRespuetasUsuarios(UserCache.id); //pasar el id por el userCache
                    rta = rtaUsuarios.Rows[0][3].ToString().Trim();
                    idPregunta = (int)rtaUsuarios.Rows[0][1];
                    preguntas = pass.ObtenerPregutasUsuarios(idPregunta);
                    cmbPreguntas.DisplayMember = "pregunta";
                    cmbPreguntas.DataSource = preguntas;
                    break;

                case true:
                    btnAtras.Visible = false;
                    preguntas = pass.ObtenerTodasPregutasSeg();
                    break;
            }
            cmbPreguntas.DisplayMember = "pregunta";
            cmbPreguntas.DataSource = preguntas;
        }
        private void continuar_Click(object sender, EventArgs e)
        {
            if (pass.ValidarPass(_esNuevo, allow, txtContra1, txtContra2, txtRespuesta, cmbPreguntas))
            {
                this.Dispose();
            }
            else
            {
                MessageBox.Show(Errores.Error, Errores.Aviso, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbContra1_Leave(object sender, EventArgs e)
        {
            allow = (CN_Validaciones.ValCar(txtContra1.Text, ConfigCache.caracteres, ConfigCache.mayusculas,
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

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
