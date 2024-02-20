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
        public frmConfigAltaPersonal()
        {
            InitializeComponent();
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

        }
    }
}
