using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio.Accesibilidad;

namespace Vista
{
    public partial class frmPuesto : Form
    {
        CN_LogicaPuestos puesto = new CN_LogicaPuestos();
        public frmPuesto()
        {
            InitializeComponent();
        }

        private void frmPuesto_Load(object sender, EventArgs e)
        {
            DataTable DT = puesto.ObtenerPuestos();
            lstPuestos.DataSource = DT;
            lstPuestos.DisplayMember = "puesto";
        }
    }
}
