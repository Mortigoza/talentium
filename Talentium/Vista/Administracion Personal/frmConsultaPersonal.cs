using Comun;
using LogicaNegocio.Administracion_Del_Personal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmConsultaPersonal : Form
    {

        CN_AdministracionDatosPersonal logicaPersona = new CN_AdministracionDatosPersonal();
        CN_AdministracionPersonalComboBox logica = new CN_AdministracionPersonalComboBox();
        public frmConsultaPersonal()
        {
            InitializeComponent();

            DataTable area = logica.ObtenerArea();
            cmbArea.DataSource = area;
            cmbArea.DisplayMember = "area";
            cmbArea.ValueMember = "id_area";
            cmbArea.SelectedIndex = -1;
        }

        private void frmConsultaPersonal_Load(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var persona = logicaPersona.ObtenerPersona();
            List<Persona> personList = persona.AsEnumerable()
                .Select(row => new Persona
                {
                    id_persona = row.Field<int>("id_persona"),
                    nombres = row.Field<string>("nombres"),
                    apellidos = row.Field<string>("apellidos"),
                    cuit_cuil = row.Field<string>("cuit_cuil"),
                    nro_doc = row.Field<string>("nro_doc"),
                    id_area= row.Field<int>("id_area") // Asegúrate de agregar esta línea para obtener el área
    })
                .ToList();

            string filtroNombres = txtNombre.Text;
            string filtroApellidos = txtApellido.Text;
            string filtroCuil = txtCuit.Text;
            int filtroIdArea = (int)cmbArea.SelectedValue; // Obtén el área seleccionada desde el ComboBox

            // Realizar el filtrado en base a los valores de los campos de texto y el área seleccionada
            var resultadosFiltrados = personList.Where(persona1 =>
                (string.IsNullOrEmpty(filtroNombres) || persona1.nombres.Contains(filtroNombres)) &&
                (string.IsNullOrEmpty(filtroApellidos) || persona1.apellidos.Contains(filtroApellidos)) &&
                (string.IsNullOrEmpty(filtroCuil) || persona1.cuit_cuil.Contains(filtroCuil)) &&
                (filtroIdArea == 0 || persona1.id_area == filtroIdArea)
            ).ToList();

            dtgEmpleados.DataSource = resultadosFiltrados;

            // Oculta las columnas que no necesitas
            foreach (DataGridViewColumn columna in dtgEmpleados.Columns)
            {
                if (columna.Name != "nombres" && columna.Name != "apellidos" && columna.Name != "cuit_cuil" && columna.Name != "nro_doc")
                {
                    columna.Visible = false;
                }
            }

            // Cambia el nombre de las columnas
            dtgEmpleados.Columns["nombres"].HeaderText = "Nombres";
            dtgEmpleados.Columns["apellidos"].HeaderText = "Apellidos";
            dtgEmpleados.Columns["cuit_cuil"].HeaderText = "Cuit/Cuil";
            dtgEmpleados.Columns["nro_doc"].HeaderText = "DNI";

        }


        private void frmConsultaPersonal_Load_1(object sender, EventArgs e)
        {

        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            if (dtgEmpleados.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dtgEmpleados.SelectedRows[0].Cells["id_persona"].Value); 

                // Abre FormAltaPersonal y pasa el id_persona
                frmAltaPersonal frmAltaPersonal = new frmAltaPersonal();
                frmAltaPersonal.CargarDatosPersona(id);
                frmAltaPersonal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila antes de hacer clic en 'Detalles'.");
            }
           
        }

        private void txtCuit_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dtgEmpleados.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dtgEmpleados.SelectedRows[0].Cells["id_persona"].Value);

                // Abre FormAltaPersonal y pasa el id_persona
                frmAltaPersonal frmAltaPersonal = new frmAltaPersonal();
                frmAltaPersonal.CargarDatosModificacion(id);
                frmAltaPersonal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila antes de hacer clic en 'Detalles'.");
            }
        }
    }
}
