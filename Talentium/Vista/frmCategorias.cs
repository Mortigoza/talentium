using Comun;
using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmCategorias : Form
    {
        
        Categorias _categoria = new  Categorias();

        private int id_categoria;
        public frmCategorias()
        {
            InitializeComponent();
        }
        private void CargarGrid()
        {
            
            var ObtenerCateogria = _categoria.ObtenerCategoria();

            DataTable dt = new DataTable();
            dtgCategoria.DataSource = ObtenerCateogria;
            dtgCategoria.Columns["id_categoria"].Visible = false;

        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {

            CargarGrid();

        }

        private void btnGuardarCrear_Click(object sender, EventArgs e)
        {
            CategoriaDto categoria = new CategoriaDto();
            categoria.categoria = txtCategoria.Text;

            categoria.jornada = int.Parse(txtJornada.Text);
            categoria.sueldo = Decimal.Parse(txtSueldo.Text);

            _categoria.InsertarCategoria(categoria);
            CargarGrid();
        }

        private void LimpiarControlesAlta()
        {
            txtCategoria.Text = null;
            txtJornada.Text = null;
            txtSueldo.Text = null;
        }

        private void LimpiarControlesModificacion()
        {
            txtCategoriaModif.Text = null;
            txtJornadaModif.Text = null;
            txtSueldoModif.Text = null;
        }

        private void btnCancelarCrear_Click(object sender, EventArgs e)
        {
            LimpiarControlesAlta();
        }

        private void btnCancelarModif_Click(object sender, EventArgs e)
        {
            LimpiarControlesModificacion();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {

            int valor = int.Parse(dtgCategoria.SelectedCells[0].Value.ToString());

            _categoria.EliminarCategoria(valor);
            CargarGrid();
        }

        private void dtgCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell celda = dtgCategoria.Rows[e.RowIndex].Cells[e.ColumnIndex];
                id_categoria = int.Parse(dtgCategoria.SelectedCells[0].Value.ToString());
                txtCategoriaModif.Text =  dtgCategoria.SelectedCells[1].Value.ToString();
                txtJornadaModif.Text = dtgCategoria.SelectedCells[2].Value.ToString();
                txtSueldoModif.Text = dtgCategoria.SelectedCells[3].Value.ToString();

            }
        }

        private void btnGuardarModif_Click(object sender, EventArgs e)
        {
            CategoriaDto categoriaDto= new CategoriaDto();
            categoriaDto.categoria = txtCategoriaModif.Text;
            categoriaDto.jornada = int.Parse(txtJornadaModif.Text);
            categoriaDto.sueldo = Decimal.Parse(txtSueldoModif.Text);
            _categoria.ModificarCategoria(categoriaDto, id_categoria);
            CargarGrid();
            LimpiarControlesModificacion();
        }
    }
}
