using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Lenguajes;

namespace Vista
{
    public partial class frmConvenios : Form
    {
        public frmConvenios()
        {
            Idioma.CargarIdioma(this.Controls, this); //Asigno los nombres a los controles del formulario
            InitializeComponent();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {

        }
    }
}
