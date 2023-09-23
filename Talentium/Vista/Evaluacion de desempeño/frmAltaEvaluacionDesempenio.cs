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
            // cargar combo de Area
            DataTable DT = evaluacionDesempenio.ObtenerAreas();
            cmbAreas.DataSource = DT;
            cmbAreas.DisplayMember = "area";
            cmbAreas.ValueMember = "id_area";

            // cargar el combo de los años
            List<string> DTAnio = combos.CargarAnioCombobox();
            cmbAnio.DataSource = DTAnio;

            // cargar el combo de los meses
            List<string> DTMeses = combos.CargarMesCombobox();
            cmbMes.DataSource = DTMeses;

            //// cargar el combo de las personas segun el area elegido en el combo anterior
            //DataTable DTPersona = evaluacionDesempenio.ObtenerPersonaConArea(cmbAreas.SelectedIndex);
            //cmbPersonal.DataSource = DTPersona;
            //cmbPersonal.DisplayMember = "nombres";
        }

        private void cmbAreas_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedArea = cmbAreas.SelectedItem as DataRowView;
            int idAreaSeleccionada = Convert.ToInt32(selectedArea["id_area"]);
            DataTable DTEmpleados = evaluacionDesempenio.ObtenerPersonaConArea(idAreaSeleccionada);
            if (DTEmpleados != null && DTEmpleados.Rows.Count > 0)
            {
                // Asignar la lista de empleados al ComboBox de empleados
                cmbPersonal.DataSource = DTEmpleados;
                cmbPersonal.DisplayMember = "nombres";
                
            }
            else
            {
                // Si no hay empleados para mostrar, limpia el ComboBox de empleados
                cmbPersonal.DataSource = null;
                cmbPersonal.Items.Clear();
            }
        }
    }
}
