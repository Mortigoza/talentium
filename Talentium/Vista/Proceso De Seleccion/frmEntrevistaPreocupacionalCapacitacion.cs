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

namespace Vista.Gestion_de_Talento
{
    public partial class frmEntrevistaPreocupacionalCapacitacion : Form
    {
        CN_LogicaProcesoSeleccion proceso = new CN_LogicaProcesoSeleccion();
        public frmEntrevistaPreocupacionalCapacitacion(string nombre, string apellido, string puesto)
        {
            InitializeComponent();
            lblNombreApellido.Text = $"{nombre} {apellido}";
            lblPuesto.Text = puesto;
        }

        private void cmbEstadoEntrevista_DropDown(object sender, EventArgs e)
        {
            List<string> estados = new List<string>() { "APTO", "NO APTO" };
            cmbEstadoEntrevista.DataSource = estados;
        }

        private void cmbEmpleados_DropDown(object sender, EventArgs e)
        {
            
        }

        private void cmbAreas_DropDown(object sender, EventArgs e)
        {
            cmbAreas.DataSource = proceso.ObtenerAreas();
            cmbAreas.DisplayMember = "area";
            cmbAreas.ValueMember = "id_area";
        }

        private void cmbAreas_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedArea = cmbAreas.SelectedItem as DataRowView;
            int idAreaSeleccionada = Convert.ToInt32(selectedArea["id_area"]);
            DataTable DTEmpleados = proceso.ObtenerEmpleados(idAreaSeleccionada);
            DTEmpleados.Columns.Add("NombreCompleto", typeof(string), "APELLIDOS + ', ' + NOMBRES");

            if (DTEmpleados != null && DTEmpleados.Rows.Count > 0)
            {
                cmbEmpleados.DataSource = DTEmpleados;
                cmbEmpleados.DisplayMember = "NombreCompleto";
            }
            else
            {
                cmbEmpleados.DataSource = null;
                cmbEmpleados.Items.Clear();
            }
        }

        private void dtpEntrevista_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = dtpEntrevista.Value;

            if (fechaSeleccionada < DateTime.Now) 
            {
                cmbEstadoEntrevista.Enabled = true;
            }
            else
            {
                cmbEstadoEntrevista.Enabled = false;
                cmbEstadoEntrevista.SelectedItem = null;
            }
        }
    }
}
