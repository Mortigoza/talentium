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
namespace Vista
{
    public partial class Asistencias : Form
    {
        CN_Asistencias asistencias = new CN_Asistencias();
        C_Asistencias datos = new C_Asistencias();
        public Asistencias()
        {
            InitializeComponent();
            buscarAlta.Enabled = false;
            DataTable asistencia = asistencias.area();
            areasAltas.DisplayMember = "area";
            areasAltas.DataSource = asistencia;
            AreaMod.DisplayMember = "area";
            AreaMod.DataSource = asistencia;
            dataGridAlta.Columns["Abrir"].Visible = false;
            dataGridModificar.Columns["Modificar"].Visible = false;
            fechaDesdeMod.Visible = false;
            FechaHastaMod.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            Refrescar(dataGridAlta);
            Refrescar(dataGridModificar);

        }

        public void Refrescar(DataGridView dtg) 
        {
            dtg.DataSource = null;
            dtg.AllowUserToAddRows = false;
            dtg.MultiSelect = false;
            dtg.RowHeadersVisible = false;
            dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtg.AllowUserToAddRows = false;
            dtg.AllowUserToResizeRows = false;
            dtg.ReadOnly = true;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = dataGridAlta.CurrentRow;

            if (filaSeleccionada != null)
            {
                // Accede a los valores de las celdas en esa fila

                datos.idPersona = Convert.ToInt32(filaSeleccionada.Cells["id_persona"].Value.ToString());
                datos.Nombre = filaSeleccionada.Cells["Nombre"].Value.ToString();
                datos.Apellido = filaSeleccionada.Cells["Apellido"].Value.ToString();
                datos.Area = filaSeleccionada.Cells["Area"].Value.ToString();
                datos.Puesto = filaSeleccionada.Cells["Puesto"].Value.ToString();
                datos.Alta = true;
                // y así sucesivamente para las otras columnas

                // Ahora puedes trabajar con los valores obtenidos
            }
            AsistenciasPanel panel = new AsistenciasPanel(datos);

            panel.Show();
            dataGridAlta.DataSource = null;
            cuilAltas.Clear();
            areasAltas.SelectedIndex = 0;
            puestosAltas.SelectedIndex = 0;
            dataGridAlta.Columns["Abrir"].Visible = false;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void cargar(DataTable data) 
        {
            dataGridAlta.AllowUserToAddRows = false;
            dataGridAlta.DataSource = data;
            dataGridAlta.Columns["Abrir"].Visible = true;

            // Ocultar las demás columnas

            dataGridAlta.Columns["id_persona"].Visible = false;
        }
        public void cargarDtg(DataTable data) 
        {
            dataGridModificar.AllowUserToAddRows = false;
            dataGridModificar.DataSource = data;
            dataGridModificar.Columns["Modificar"].Visible = true;

            // Ocultar los id en las columnas
                    
                    dataGridModificar.Columns["id_persona"].Visible = false;
                    dataGridModificar.Columns["id_asistencias"].Visible = false;
                    dataGridModificar.Columns["id_motivo"].Visible = false;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //boton buscar del alta
            DataRowView selectedArea = (DataRowView)areasAltas.SelectedItem;
            DataRowView selectedPuesto = (DataRowView)puestosAltas.SelectedItem;
            int idA = Convert.ToInt32(selectedArea["id_area"]);
            int idP = Convert.ToInt32(selectedPuesto["id_puesto"]);
            if (string.IsNullOrEmpty(cuilAltas.Text))
            {
                DataTable asis = asistencias.filtroAlta(idA, idP, null);
                cargar(asis);            }
            else
            {
                DataTable asis = asistencias.filtroAlta(idA, idP, cuilAltas.Text);
                cargar(asis);

            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void areasAltas_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedRow = (DataRowView)areasAltas.SelectedItem;
            int id = Convert.ToInt32(selectedRow["id_area"]);

            DataTable asistenciaP = asistencias.puesto(id);
            puestosAltas.DisplayMember = "puesto";
            puestosAltas.DataSource = asistenciaP;

            if (areasAltas.SelectedItem != null && puestosAltas.Text != null)
            {
                buscarAlta.Enabled = true; 
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void periodo_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void periodo_CheckedChanged_1(object sender, EventArgs e)
        {
            if (periodo.Checked)
            {
                FechaMod.Visible = false;
                fechaDesdeMod.Visible = true;
                FechaHastaMod.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = false;
            }
            else
            {
                FechaMod.Visible = true;
                fechaDesdeMod.Visible = false;
                FechaHastaMod.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //boton buscar del modificar
            DataRowView selectedArea = (DataRowView)AreaMod.SelectedItem;
            DataRowView selectedPuesto = (DataRowView)PuestoMod.SelectedItem;
            object idA = selectedArea["id_area"];
            object idP = selectedPuesto["id_puesto"];
            
                DataTable asis = asistencias.filtroModificacion(periodo.Checked ,idA, idP, CuilMod.Text, FechaMod.Value, fechaDesdeMod.Value, FechaHastaMod.Value );
            //corroborar las cargas del dtg aplicar la busqueda del motivo para traerlo.
            //tengo que traer nombre y apellido de persona, dejando el id_persona y el id_motivo
            cargarDtg(asis);
           


        }

        private void AreaMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedRow = (DataRowView)areasAltas.SelectedItem;
            int id = Convert.ToInt32(selectedRow["id_area"]);

            DataTable asistenciaP = asistencias.puesto(id);
            PuestoMod.DisplayMember = "puesto";
            PuestoMod.DataSource = asistenciaP;

            if (areasAltas.SelectedItem != null && puestosAltas.Text != null)
            {
                buscarAlta.Enabled = true;
            }
        }

        private void dataGridModificar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = dataGridModificar.CurrentRow;

            if (filaSeleccionada != null)
            {
                // Accede a los valores de las celdas en esa fila

                datos.idAsistencia = Convert.ToInt32(filaSeleccionada.Cells["id_asistencias"].Value.ToString());
                datos.idPersona = Convert.ToInt32(filaSeleccionada.Cells["id_persona"].Value.ToString());
                datos.Nombre = filaSeleccionada.Cells["Nombre"].Value.ToString();
                datos.Apellido = filaSeleccionada.Cells["Apellido"].Value.ToString();
                datos.Area = filaSeleccionada.Cells["Area"].Value.ToString();
                datos.Puesto = filaSeleccionada.Cells["Puesto"].Value.ToString();

                datos.Periodo = Convert.ToBoolean(filaSeleccionada.Cells["periodo"].Value.ToString());
                if (datos.Periodo)
                {
                    datos.Fecha = DateTime.Now;
                    datos.Fecha_desde = Convert.ToDateTime(filaSeleccionada.Cells["fecha_desde"].Value.ToString());
                    datos.Fecha_hasta = Convert.ToDateTime(filaSeleccionada.Cells["fecha_hasta"].Value.ToString());
                }
                else 
                {
                    datos.Fecha = Convert.ToDateTime(filaSeleccionada.Cells["fecha"].Value.ToString());
                    datos.Fecha_desde = DateTime.Now; 
                    datos.Fecha_hasta = DateTime.Now;

                }
                datos.Justificada = Convert.ToBoolean(filaSeleccionada.Cells["justificada"].Value.ToString());
                datos.Id_motivo = Convert.ToInt32(filaSeleccionada.Cells["id_motivo"].Value.ToString());
                datos.Otro_motivo = filaSeleccionada.Cells["otro_motivo"].Value.ToString();
                datos.Observaciones = filaSeleccionada.Cells["observaciones"].Value.ToString();
                datos.Alta = false;
                // y así sucesivamente para las otras columnas

                // Ahora puedes trabajar con los valores obtenidos
            }
            AsistenciasPanel panel = new AsistenciasPanel(datos);

            panel.Show();

            dataGridModificar.DataSource = null;
            CuilMod.Clear();
            AreaMod.SelectedIndex = 0;
            PuestoMod.SelectedIndex =0;
            periodo.Checked = false;
            FechaMod.Value = DateTime.Now;
            fechaDesdeMod.Value = DateTime.Now;
            FechaHastaMod.Value = DateTime.Now;
            dataGridModificar.Columns["Modificar"].Visible = false;

        }
    }
}
