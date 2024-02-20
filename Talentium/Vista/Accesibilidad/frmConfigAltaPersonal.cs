using LogicaNegocio.Accesibilidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Accesibilidad
{
    public partial class frmConfigAltaPersonal : Form
    {
        CN_ConfigAltaPersonal config = new CN_ConfigAltaPersonal();
        public frmConfigAltaPersonal()
        {
            InitializeComponent();
            // tab Tipo de Documento
            grpModificar.Enabled = false;
            grpModificarTel.Enabled = false;
            grpNacioMod.Enabled = false;
            grpModificarGenero.Enabled = false;
            CargarDataGrid();
            // Config data grid Tipo de documento
            dtgDocumento.AutoGenerateColumns = false;
            dtgDocumento.AllowUserToAddRows = false;
            dtgDocumento.MultiSelect = false;
            // Config data grid Tipo de teléfono
            dtgTelefono.AutoGenerateColumns = false;
            dtgTelefono.AllowUserToAddRows = false;
            dtgTelefono.MultiSelect = false;
            // Config data grid Nacionalidad
            dtgNacionalidad.AutoGenerateColumns = false;
            dtgNacionalidad.AllowUserToAddRows = false;
            dtgNacionalidad.MultiSelect = false;
            // Config data grid Género
            dtgGenero.AutoGenerateColumns = false;
            dtgGenero.AllowUserToAddRows = false;
            dtgGenero.MultiSelect = false;
        }
        private void NavigateTabs(int offset)
        {
            int currentIndex = tabConfigAltaPersonal.SelectedIndex;
            int newIndex = currentIndex + offset;
            if (newIndex >= 0 && newIndex < tabConfigAltaPersonal.TabCount)
            {
                tabConfigAltaPersonal.SelectedIndex = newIndex;
            }
        }
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            NavigateTabs(-1);
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            NavigateTabs(1);
        }
        private void btnGuardarMod_Click(object sender, EventArgs e)
        {
            int id_tipo_doc = (int)dtgDocumento.SelectedCells[0].Value;
            if (string.IsNullOrWhiteSpace(txtDocumentoMod.Text))
            {
                MessageBox.Show("Por favor, asegúrate de que el campo esté completo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!config.ModificarTipoDoc(id_tipo_doc, txtDocumentoMod.Text))
            {
                CargarDataGrid();
                MessageBox.Show("Se modificó el Tipo de documento correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDocumentoMod.Clear();
                grpModificar.Enabled = false;
            }
            else
            {
                MessageBox.Show("El Tipo de documento ya se encuentra en uso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDocumentoMod.Clear();
            }
        }
        private void btnGuardarAlta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDocumento.Text))
            {
                MessageBox.Show("Por favor, asegúrate de que el campo esté completo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!config.ValidarTipoDoc(txtDocumento.Text))
            {
                CargarDataGrid();
                MessageBox.Show("Se agregó el Tipo de documento correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDocumento.Clear();
            } else
            {
                MessageBox.Show("El Tipo de documento ya se encuentra en uso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDocumento.Clear();
            }
        }
        private void btnCancelarAlta_Click(object sender, EventArgs e)
        {
            txtDocumento.Clear();
        }
        public void CargarDataGrid()
        {
            DataTable tipoDoc = config.ObtenerTipoDoc();
            dtgDocumento.DataSource = tipoDoc;
            for (int i = 0; i < tipoDoc.Rows.Count; i++)
            {
                dtgDocumento.Rows[i].Cells["Nombre"].Value = tipoDoc.Rows[i]["tipo_doc"];
            }
            dtgDocumento.Columns["ID"].Visible = false;
        }

        private void dtgDocumento_SelectionChanged(object sender, EventArgs e)
        {
            btnModificar.Enabled = dtgDocumento.SelectedRows.Count > 0;
            btnBaja.Enabled = dtgDocumento.SelectedRows.Count > 0;
        }
        private void dtgDocumento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            grpModificar.Enabled = true;
            if (e.RowIndex >= 0)
            {
                txtDocumentoMod.Text = dtgDocumento.SelectedCells[1].Value.ToString();
            }
        }
        private void btnCancelarMod_Click(object sender, EventArgs e)
        {
            txtDocumentoMod.Clear();
            grpModificar.Enabled = false;
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            grpModificar.Enabled = true;
            if (dtgDocumento.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dtgDocumento.SelectedRows[0];

                if (filaSeleccionada.Cells["Nombre"].Value != null)
                {
                    string valorCelda = filaSeleccionada.Cells["Nombre"].Value.ToString();
                    txtDocumentoMod.Text = valorCelda;
                }
            }
        }
        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (dtgDocumento.SelectedRows.Count > 0)
            {
                int id_tipo_doc = Convert.ToInt32(dtgDocumento.SelectedCells[0].Value);
                if (config.TipoDocAsociadoAPersona(id_tipo_doc) == true)
                {
                    MessageBox.Show("No se puede eliminar el tipo de documento porque se encuentra en uso.");
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("¿Quieres eliminar el tipo de documento?", "Confirmar eliminación", MessageBoxButtons.OKCancel);

                    if (resultado == DialogResult.OK)
                    {
                        config.EliminarTipoDoc(id_tipo_doc);
                        MessageBox.Show("El tipo de documento ha sido eliminado con éxito.");
                        CargarDataGrid();
                    }
                    else if (resultado == DialogResult.Cancel)
                    {
                        MessageBox.Show("Se ha cancelado la operación.");
                    }
                }

            }
        }
    }
}
