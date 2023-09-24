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
    public partial class frmConsultaEvaluacionDesempenio : Form
    {
        CN_LogicaEvaluacionDesempenio evaluacionDesempenio = new CN_LogicaEvaluacionDesempenio();
        CargarCombobox combos = new CargarCombobox();
        public frmConsultaEvaluacionDesempenio()
        {
            InitializeComponent();
        }

        private void frmConsultaEvaluacionDesempenio_Load(object sender, EventArgs e)
        {
            // cargar combo de Area
            DataTable DT = evaluacionDesempenio.ObtenerAreas();
            cmbAreas.DataSource = DT;
            cmbAreas.DisplayMember = "area";
            cmbAreas.ValueMember = "id_area";

            // cargar el combo de los años
            List<string> DTAnio = combos.CargarAnioCombobox();
            DTAnio.Insert(0, "");
            cmbAnio.DataSource = DTAnio;

            dtgConsultaEvaluacion.AllowUserToAddRows = false;
        }

        private void cmbAreas_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedArea = cmbAreas.SelectedItem as DataRowView;
            int idAreaSeleccionada = Convert.ToInt32(selectedArea["id_area"]);
            DataTable DTEmpleados = evaluacionDesempenio.ObtenerPersonaConArea(idAreaSeleccionada);
            DTEmpleados.Columns.Add("NombreCompleto", typeof(string), "APELLIDOS + ', ' + NOMBRES");

            if (DTEmpleados != null && DTEmpleados.Rows.Count > 0)
            {
                cmbPersonal.DataSource = DTEmpleados;
                cmbPersonal.DisplayMember = "NombreCompleto";
                cmbPersonal.ValueMember = "id_persona";
            }
            else
            {
                // Si no hay empleados para mostrar, limpia el ComboBox de empleados
                cmbPersonal.DataSource = null;
                cmbPersonal.Items.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbPersonal.SelectedItem != null && cmbPersonal.SelectedValue != null)
            {
                DataRowView empleadoSeleccionado = cmbPersonal.SelectedItem as DataRowView;

                string nombres = empleadoSeleccionado["nombres"].ToString();
                string apellidos = empleadoSeleccionado["apellidos"].ToString();
                string nombreApellido = $"{apellidos}, {nombres}";

                lblNombreYApellido.Text = nombreApellido;

                string cuil = empleadoSeleccionado["cuit_cuil"].ToString();
                lblCuil.Text = cuil;

                lblNombreYApellido.Visible = true;
                lblCuil.Visible = true;
            }
            string anio = cmbAnio.SelectedValue.ToString();
            int id_persona = Convert.ToInt32(cmbPersonal.SelectedValue);
            dtgConsultaEvaluacion.AutoGenerateColumns = false;
            if (!string.IsNullOrEmpty(anio) && anio!="")
            {
                dtgConsultaEvaluacion.DataSource = evaluacionDesempenio.ObtenerEvaluacion(anio, id_persona);
                CargarColumnasDataGrid();
                dtgConsultaEvaluacion.Columns["Anio"].Visible = false;
                int cantidadEvaluacion = dtgConsultaEvaluacion.Rows.Count;
                lblCantidadEval.Text = cantidadEvaluacion.ToString();

            }
            else
            {
                dtgConsultaEvaluacion.Columns["Anio"].Visible = true;
                dtgConsultaEvaluacion.DataSource = evaluacionDesempenio.ObtenerEvaluacionPersona(id_persona);
                CargarColumnasDataGrid();
                int cantidadEvaluacion = dtgConsultaEvaluacion.Rows.Count;
                lblCantidadEval.Text = cantidadEvaluacion.ToString();
            }
        }

        public void CargarColumnasDataGrid()
        {
            dtgConsultaEvaluacion.Columns["MesEvaluacion"].DataPropertyName = "mes";
            dtgConsultaEvaluacion.Columns["EfectTareas"].DataPropertyName = "efectividadTarea";
            dtgConsultaEvaluacion.Columns["Puntualidad"].DataPropertyName = "puntualidad";
            dtgConsultaEvaluacion.Columns["RelSup"].DataPropertyName = "relacionSuperiores";
            dtgConsultaEvaluacion.Columns["Disciplina"].DataPropertyName = "disciplina";
            dtgConsultaEvaluacion.Columns["DesempEquipo"].DataPropertyName = "desempenioEquipo";
            dtgConsultaEvaluacion.Columns["Anio"].DataPropertyName = "anio";
        }
    }
}
