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

        public frmConsultaPersonal()
        {
            InitializeComponent();
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
              nombres  = row.Field<string>("nombres"),
                    apellidos = row.Field<string>("apellidos"),
              cuit_cuil = row.Field<string>("cuit_cuil"),
                          nro_doc = row.Field<string>("nro_doc")
                          
            
          })
          .ToList();
            var nombre = personList.Where(x => x.nombres == txtNombre.Text).Select(x => x.nombres).FirstOrDefault();
            var apellidos = personList.Where(x => x.apellidos == txtApellido.Text).Select(x => x.apellidos).FirstOrDefault();
            //var nro_doc = personList.Where(x => x.nombres == txtDni.Text).Select(x => x.nro_doc).FirstOrDefault();
            var cuit_cuil = personList.Where(x => x.cuit_cuil == txtCuit.Text).Select(x => x.cuit_cuil).FirstOrDefault();

            DataTable dataTable = new DataTable();

            // Agregar una columna llamada "nombre" al DataTable
            dataTable.Columns.Add("nombres", typeof(string));
            dataTable.Columns.Add("apellidos", typeof(string));
            dataTable.Columns.Add("nro_doc", typeof(string));
            dataTable.Columns.Add("cuit_cuil", typeof(string));
            // Agregar una fila al DataTable y establecer el valor de la columna "nombre"
            DataRow row1 = dataTable.NewRow();
            row1["nombres"] = nombre;
            row1["apellidos"] = apellidos;
            //row1["nro_doc"] = nombre;
            row1["cuit_cuil"] = cuit_cuil;
            dataTable.Rows.Add(row1);
            dtgEmpleados.DataSource = dataTable;


        }

        private void CargarGrid()
        {
            DataTable ObtenerPersona= logicaPersona.ObtenerPersona();

            DataTable dt = new DataTable();
            dtgEmpleados.DataSource = ObtenerPersona;
            
        }

        private void frmConsultaPersonal_Load_1(object sender, EventArgs e)
        {

        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {

        }

        private void txtCuit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
