using LogicaNegocio;
using System;
using System.Windows.Forms;

namespace Vista
{

    public partial class frmConvenios : Form
    {
        Categorias _categoria = new Categorias();
        public frmConvenios()
        {
            InitializeComponent();
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmConvenios_Load(object sender, EventArgs e)
        {
            var ObtenerCateogria = _categoria.ObtenerCategoria();
            cmbCategoria.DataSource = ObtenerCateogria;
            cmbCategoria.DisplayMember = "nombre_categoria";
            cmbCategoria.ValueMember = "id_categoria";
            //cmbProvincia.SelectedIndex = -1;
        }
    }
}
