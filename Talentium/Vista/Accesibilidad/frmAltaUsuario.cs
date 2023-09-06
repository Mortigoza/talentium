using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmAltaUsuario : Form
    {
        public frmAltaUsuario()
        {
            InitializeComponent();
        }

        private void frmAltaUsuario_Load(object sender, EventArgs e)
        {

        }

        private void tbcAltaUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbpUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CN_LogicaUsuarios usuario = new CN_LogicaUsuarios();
            usuario.InsertarNuevoUsuario(1, txtUsuario.Text, txtContrasenia.Text, Convert.ToInt32(nmrCambiaCada.Value));
        }

        private void btnCrearContrasenia_Click(object sender, EventArgs e)
        {
            txtContrasenia.Text = "aaf";
        }
    }
}
