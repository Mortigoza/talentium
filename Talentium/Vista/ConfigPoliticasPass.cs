using Comun;
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
    public partial class ConfigPoliticasPass : Form
    {
        CN_PoliticaPassword config = new CN_PoliticaPassword();
        public ConfigPoliticasPass()
        {
            InitializeComponent();
            config.ConsultaPoliticaPass();

            chcChar.Checked = ConfigCache.caracteres;
            chcMay.Checked = ConfigCache.mayusculas;
            chcNum.Checked = ConfigCache.numeros;
            chcEsp.Checked = ConfigCache.especiales;
            chcPass.Checked = ConfigCache.passAnteriores;
            chcDatos.Checked = ConfigCache.noDatosPersonales;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            config.upPolPass(chcChar.Checked, chcMay.Checked, chcNum.Checked, chcEsp.Checked, chcPass.Checked, chcDatos.Checked);
        }

        private void ConfigPoliticasPass_Load(object sender, EventArgs e)
        {

        }
    }
}
