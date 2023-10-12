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
            abrirAlta.Enabled = false;
            DataTable asistencia = asistencias.area();
            areasAltas.DisplayMember = "area";
            areasAltas.DataSource = asistencia;
            dataGridAlta.Columns["Abrir"].Visible = false;

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
                datos.Puesto= filaSeleccionada.Cells["Puesto"].Value.ToString();
                // y así sucesivamente para las otras columnas

                // Ahora puedes trabajar con los valores obtenidos
            }
            AsistenciasPanel panel = new AsistenciasPanel(datos);

            panel.Show();
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
            foreach (DataGridViewColumn column in dataGridAlta.Columns)
            {
                if (column.Name != "Nombre" && column.Name != "Apellido"
                    && column.Name != "Area" && column.Name != "Puesto"
                    && column.Name != "Abrir")
                {
                    column.Visible = false;

                }

            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
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
    }
}
