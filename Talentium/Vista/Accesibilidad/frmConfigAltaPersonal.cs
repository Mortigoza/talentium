using LogicaNegocio.Accesibilidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Accesibilidad
{
    public partial class frmConfigAltaPersonal : Form
    {
        CN_ConfigAltaPersonal config = new CN_ConfigAltaPersonal();
        public frmConfigAltaPersonal()
        {
            InitializeComponent();
            grpModificar.Enabled = false;
            grpModificarTel.Enabled = false;
            grpNacioMod.Enabled = false;
            grpModificarGenero.Enabled = false;
            
        }
        private void NavigateTabs(int offset)
        {
            int currentIndex = tabConfigAltaPersonal.SelectedIndex;
            int newIndex = currentIndex + offset;

            // Verificar límites de las pestañas
            if (newIndex >= 0 && newIndex < tabConfigAltaPersonal.TabCount)
            {
                tabConfigAltaPersonal.SelectedIndex = newIndex;
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            NavigateTabs(-1);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            NavigateTabs(1);
        }

        private void btnGuardarMod_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarAlta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDocumento.Text))
            {
                MessageBox.Show("Por favor, asegúrate de que el campo esté completo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!config.ValidarTipoDoc(txtDocumento.Text))
            {
                //CargarGrid();
                MessageBox.Show("Se agrego el Tipo de documento correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDocumento.Clear();
            } else
            {
                MessageBox.Show("El Tipo de documento ya se encuentra en uso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDocumento.Clear();
            }

        }

        private void btnCancelarAlta_Click(object sender, EventArgs e)
        {
            txtDocumento.Clear();
        }
    }
}
