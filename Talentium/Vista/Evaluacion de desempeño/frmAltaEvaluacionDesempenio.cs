using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio;

namespace Vista.Evaluacion_de_desempeño
{
    public partial class frmAltaEvaluacionDesempenio : Form
    {
        CN_LogicaEvaluacionDesempenio evaluacionDesempenio = new CN_LogicaEvaluacionDesempenio();
        public frmAltaEvaluacionDesempenio()
        {
            InitializeComponent();
        }

        private void frmAltaEvaluacionDesempeño_Load(object sender, EventArgs e)
        {
            DataTable DT = evaluacionDesempenio.ObtenerAreas();
            cmbAreas.DataSource = DT;
            cmbAreas.DisplayMember = "area";
        }
    }
}
