using Comun;
using LogicaNegocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace Vista
{

    public partial class frmConvenios : Form
    {
        CN_Convenio _convenio = new CN_Convenio();
        CN_Categorias _categoria = new CN_Categorias();
        private bool inicial = true;
        private int id_convenio;


        public frmConvenios()
        {
            InitializeComponent();

            txtSueldo.Enabled = false;
            txtJornada.Enabled = false;
            txtSueldoModif.Enabled = false;
            txtJornadaModif.Enabled = false;
            txtCategoriaModif.Enabled = false;

            CargarGrid();
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inicial)
            {
                return;
            }
            var seleccion = cmbCategoria.SelectedValue.ToString();
            var categoria = _convenio.ObtenerCategoriaID(int.Parse(seleccion));
            txtJornada.Text = categoria.Rows[0]["jornada"].ToString();
            txtSueldo.Text = categoria.Rows[0]["sueldos"].ToString();
            
          
        }

        private void CargarGrid()
        {

            var ObtenerConvenio = _convenio.ObtenerConvenio();

            dtgConvenio.DataSource = ObtenerConvenio;

            dtgConvenio.Columns["id_convenio"].Visible = false;
            dtgConvenio.Columns["id_categoria"].Visible = false;


        }

        private void frmConvenios_Load(object sender, EventArgs e)
        {
            var ObtenerCateogria = _categoria.ObtenerCategoria();
            cmbCategoria.DataSource = ObtenerCateogria;
            cmbCategoria.DisplayMember = "nombre_categoria";
            cmbCategoria.SelectedIndex = 0;
            cmbCategoria.ValueMember = "id_categoria";
            cmbCateModif.DataSource = ObtenerCateogria.Copy();
            cmbCateModif.DisplayMember = "nombre_categoria";
            cmbCateModif.SelectedIndex = 0;
            cmbCateModif.ValueMember = "id_categoria";
            inicial = false;



        }


        private void btnGuardarCrear_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtConvenio.Text) ||
              string.IsNullOrWhiteSpace(txtObraSocial.Text) ||
              string.IsNullOrWhiteSpace(txtSeguridadSalud.Text))
            {
                MessageBox.Show("Por favor, asegúrate de que todos los campos estén llenos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ConvenioDto convenio = new ConvenioDto();
                convenio.convenio = txtConvenio.Text;
                convenio.seguridad_salud = txtSeguridadSalud.Text;
                convenio.obra_social = txtObraSocial.Text;
                convenio.id_categoria = int.Parse(cmbCategoria.SelectedValue.ToString());
                _convenio.InsertarConvenio(convenio);
                CargarGrid();
                MessageBox.Show("Se agrego el convenio correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }


        private void btnGuardarModif_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtConvenioModif.Text) ||
         string.IsNullOrWhiteSpace(txtObraSocialModif.Text) ||
         string.IsNullOrWhiteSpace(txtSeguridadSaludModif.Text))
            {
                MessageBox.Show("Por favor, asegúrate de que todos los campos estén llenos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ConvenioDto convenioDto = new ConvenioDto();
                convenioDto.convenio = txtConvenioModif.Text;
                convenioDto.obra_social = txtObraSocialModif.Text;
                convenioDto.seguridad_salud = txtSeguridadSaludModif.Text;
                convenioDto.id_categoria = int.Parse(cmbCateModif.SelectedValue.ToString()); ;
                
                _convenio.ModificarConvenio(convenioDto, id_convenio);
                CargarGrid();
                MessageBox.Show("Se Modifico el convenio correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }


        private void LimpiarControlesModificacion()
        {
            txtConvenioModif.Text = null;
            txtSeguridadSalud.Text = null;
            txtObraSocialModif.Text = null;
        }

        private void dtgConvenio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell celda = dtgConvenio.Rows[e.RowIndex].Cells[e.ColumnIndex];
                id_convenio = int.Parse(dtgConvenio.SelectedCells[0].Value.ToString());
                txtConvenioModif.Text = dtgConvenio.SelectedCells[1].Value.ToString();
                txtObraSocialModif.Text = dtgConvenio.SelectedCells[2].Value.ToString();
                txtSeguridadSaludModif.Text = dtgConvenio.SelectedCells[3].Value.ToString();
                txtCategoriaModif.Text = dtgConvenio.SelectedCells[6].Value.ToString();
                txtSueldoModif.Text = dtgConvenio.SelectedCells[7].Value.ToString();
                txtJornadaModif.Text= dtgConvenio.SelectedCells[8].Value.ToString();

             

            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            try
            {
                int valor = int.Parse(dtgConvenio.SelectedCells[0].Value.ToString());

                _convenio.EliminarConvenio(valor);
                CargarGrid();
                MessageBox.Show("El convenio fue dada de baja con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbCateModif_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inicial)
            {
                return;
            }
            
            var seleccion = cmbCateModif.SelectedValue.ToString();
            var categoria = _convenio.ObtenerCategoriaID(int.Parse(seleccion));
            txtJornadaModif.Text = categoria.Rows[0]["jornada"].ToString();
            txtSueldoModif.Text = categoria.Rows[0]["sueldos"].ToString();
            
        }

        private void txtConvenio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada de caracteres no alfabéticos
                MessageBox.Show("En este campo solo debe ingresar letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtSeguridadSalud_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada de caracteres no alfabéticos
                MessageBox.Show("En este campo solo debe ingresar letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtObraSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada de caracteres no alfabéticos
                MessageBox.Show("En este campo solo debe ingresar letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtConvenioModif_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada de caracteres no alfabéticos
                MessageBox.Show("En este campo solo debe ingresar letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtSeguridadSaludModif_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada de caracteres no alfabéticos
                MessageBox.Show("En este campo solo debe ingresar letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtObraSocialModif_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada de caracteres no alfabéticos
                MessageBox.Show("En este campo solo debe ingresar letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbCateModif_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
