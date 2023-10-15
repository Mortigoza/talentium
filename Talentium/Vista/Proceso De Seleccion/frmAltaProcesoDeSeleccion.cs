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
    public partial class frmAltaProcesoDeSeleccion : Form
    {
        public frmAltaProcesoDeSeleccion()
        {
            InitializeComponent();
            Idioma.CargarIdioma(this.Controls, this); //Asigno los nombres a los controles del formulario
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
