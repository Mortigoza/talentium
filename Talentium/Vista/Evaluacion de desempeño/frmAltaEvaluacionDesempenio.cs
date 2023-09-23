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
using Comun;

namespace Vista.Evaluacion_de_desempeño
{
    public partial class frmAltaEvaluacionDesempenio : Form
    {
        CN_LogicaEvaluacionDesempenio evaluacionDesempenio = new CN_LogicaEvaluacionDesempenio();
        CargarCombobox combos = new CargarCombobox();
        public frmAltaEvaluacionDesempenio()
        {
            InitializeComponent();
        }

        private void frmAltaEvaluacionDesempeño_Load(object sender, EventArgs e)
        {
            DataTable DT = evaluacionDesempenio.ObtenerAreas();
            cmbAreas.DataSource = DT;
            cmbAreas.DisplayMember = "area";
            cmbAreas.SelectedIndex = -1;

            DataTable DTPersona = evaluacionDesempenio.ConsultarPersonaConArea(cmbAreas.SelectedIndex);
            cmbAreas.DataSource = DTPersona;
            cmbAreas.DisplayMember = "Apellido";
            cmbAreas.SelectedIndex = -1;
            

            List<string> DTAnio = combos.CargarAnioCombobox();
            cmbAnio.DataSource = DTAnio;

            List<string> DTMeses = combos.CargarMesCombobox();
            cmbMes.DataSource = DTMeses;


        }
    }
}
