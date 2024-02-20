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
            CargarDataGridTipoTel();
            CargarDataGridNacionalidad();
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
        // tab Tipo de documento
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

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDocumentoMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // tab tipo de teléfono 
        private void btnCancelarAltaTel_Click(object sender, EventArgs e)
        {
            txtTelefonoAlta.Clear();
        }

        private void btnGuardarAltaTel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTelefonoAlta.Text))
            {
                MessageBox.Show("Por favor, asegúrate de que el campo esté completo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!config.ValidarTipoTel(txtTelefonoAlta.Text))
            {
                CargarDataGridTipoTel();
                MessageBox.Show("Se agregó el Tipo de teléfono correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTelefonoAlta.Clear();
            }
            else
            {
                MessageBox.Show("El Tipo de teléfono ya se encuentra en uso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTelefonoAlta.Clear();
            }
        }
        public void CargarDataGridTipoTel()
        {
            DataTable tipoTel = config.ObtenerTipoTel();
            dtgTelefono.DataSource = tipoTel;
            for (int i = 0; i < tipoTel.Rows.Count; i++)
            {
                dtgTelefono.Rows[i].Cells["NombreTel"].Value = tipoTel.Rows[i]["tipo"];
            }
            dtgTelefono.Columns["IDTel"].Visible = false;
        }
        private void btnGuardarTelMod_Click(object sender, EventArgs e)
        {
            int id_tipo_tel = (int)dtgTelefono.SelectedCells[0].Value;
            if (string.IsNullOrWhiteSpace(txtTipoTelMod.Text))
            {
                MessageBox.Show("Por favor, asegúrate de que el campo esté completo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!config.ModificarTipoTel(id_tipo_tel, txtTipoTelMod.Text))
            {
                CargarDataGridTipoTel();
                MessageBox.Show("Se modificó el Tipo de teléfono correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTipoTelMod.Clear();
                grpModificarTel.Enabled = false;
            }
            else
            {
                MessageBox.Show("El Tipo de teléfono ya se encuentra en uso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTipoTelMod.Clear();
            }
        }
        private void btnCancelarTelMod_Click(object sender, EventArgs e)
        {
            txtTipoTelMod.Clear();
            grpModificarTel.Enabled = false;
        }
        private void dtgTelefono_SelectionChanged(object sender, EventArgs e)
        {
            btnModificarTel.Enabled = dtgTelefono.SelectedRows.Count > 0;
            btnBajaTel.Enabled = dtgTelefono.SelectedRows.Count > 0;
        }
        private void dtgTelefono_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            grpModificarTel.Enabled = true;
            if (e.RowIndex >= 0)
            {
                txtTipoTelMod.Text = dtgTelefono.SelectedCells[1].Value.ToString();
            }
        }
        private void btnModificarTel_Click(object sender, EventArgs e)
        {
            grpModificarTel.Enabled = true;
            if (dtgTelefono.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dtgTelefono.SelectedRows[0];

                if (filaSeleccionada.Cells["NombreTel"].Value != null)
                {
                    string valorCelda = filaSeleccionada.Cells["NombreTel"].Value.ToString();
                    txtTipoTelMod.Text = valorCelda;
                }
            }
        }
        private void btnBajaTel_Click(object sender, EventArgs e)
        {
            if (dtgTelefono.SelectedRows.Count > 0)
            {
                int id_tel = Convert.ToInt32(dtgTelefono.SelectedCells[0].Value);
                if (config.TipoTelAsociadoAPersona(id_tel) == true)
                {
                    MessageBox.Show("No se puede eliminar el tipo de teléfono porque se encuentra en uso.");
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("¿Quieres eliminar el tipo de teléfono?", "Confirmar eliminación", MessageBoxButtons.OKCancel);

                    if (resultado == DialogResult.OK)
                    {
                        config.EliminarTipoTel(id_tel);
                        MessageBox.Show("El tipo de teléfono ha sido eliminado con éxito.");
                        CargarDataGridTipoTel();
                    }
                    else if (resultado == DialogResult.Cancel)
                    {
                        MessageBox.Show("Se ha cancelado la operación.");
                    }
                }

            }
        }
        private void txtTelefonoAlta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtTipoTelMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // tab Nacionalidad
        private void btnCancelarNacioAlta_Click(object sender, EventArgs e)
        {
            txtNacionalidad.Clear();
        }

        private void btnNacioGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNacionalidad.Text))
            {
                MessageBox.Show("Por favor, asegúrate de que el campo esté completo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!config.ValidarNacionalidad(txtNacionalidad.Text))
            {
                CargarDataGridNacionalidad();
                MessageBox.Show("Se agregó la nacionalidad correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNacionalidad.Clear();
            }
            else
            {
                MessageBox.Show("La nacionalidad ya se encuentra en uso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNacionalidad.Clear();
            }
        }

        private void btnNacioCancelarMod_Click(object sender, EventArgs e)
        {
            txtNacioMod.Clear();
            grpNacioMod.Enabled = false;
        }

        private void btnNacioGuardarMod_Click(object sender, EventArgs e)
        {
            int id_nacionalidad = (int)dtgNacionalidad.SelectedCells[0].Value;
            if (string.IsNullOrWhiteSpace(txtNacioMod.Text))
            {
                MessageBox.Show("Por favor, asegúrate de que el campo esté completo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!config.ModificarNacionalidad(id_nacionalidad, txtNacioMod.Text))
            {
                CargarDataGridNacionalidad();
                MessageBox.Show("Se modificó la nacionalidad correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNacioMod.Clear();
                grpNacioMod.Enabled = false;
            }
            else
            {
                MessageBox.Show("La nacionalidad ya se encuentra en uso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNacioMod.Clear();
            }
        }

        private void btnNacionalidadMod_Click(object sender, EventArgs e)
        {
            grpNacioMod.Enabled = true;
            if (dtgNacionalidad.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dtgNacionalidad.SelectedRows[0];

                if (filaSeleccionada.Cells["NombreNac"].Value != null)
                {
                    string valorCelda = filaSeleccionada.Cells["NombreNac"].Value.ToString();
                    txtNacioMod.Text = valorCelda;
                }
            }
        }

        private void btnBajaNacionalidad_Click(object sender, EventArgs e)
        {
            if (dtgNacionalidad.SelectedRows.Count > 0)
            {
                int id_nacionalidad = Convert.ToInt32(dtgNacionalidad.SelectedCells[0].Value);
                if (config.NacionalidadAsociadaAPersona(id_nacionalidad) == true)
                {
                    MessageBox.Show("No se puede eliminar la nacionalidad porque se encuentra en uso.");
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("¿Quieres eliminar la nacionalidad?", "Confirmar eliminación", MessageBoxButtons.OKCancel);

                    if (resultado == DialogResult.OK)
                    {
                        config.EliminarNacionalidad(id_nacionalidad);
                        MessageBox.Show("La nacionalidad ha sido eliminada con éxito.");
                        CargarDataGridNacionalidad();
                    }
                    else if (resultado == DialogResult.Cancel)
                    {
                        MessageBox.Show("Se ha cancelado la operación.");
                    }
                }
            }
        }
        private void txtNacionalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtNacioMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dtgNacionalidad_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            grpNacioMod.Enabled = true;
            if (e.RowIndex >= 0)
            {
                txtNacioMod.Text = dtgNacionalidad.SelectedCells[1].Value.ToString();
            }
        }
        private void dtgNacionalidad_SelectionChanged(object sender, EventArgs e)
        {
            btnNacionalidadMod.Enabled = dtgNacionalidad.SelectedRows.Count > 0;
            btnBajaNacionalidad.Enabled = dtgNacionalidad.SelectedRows.Count > 0;
        }
        public void CargarDataGridNacionalidad()
        {
            DataTable nacionalidad = config.ObtenerNacionalidad();
            dtgNacionalidad.DataSource = nacionalidad;
            for (int i = 0; i < nacionalidad.Rows.Count; i++)
            {
                dtgTelefono.Rows[i].Cells["NombreNac"].Value = nacionalidad.Rows[i]["nacionalidad"];
            }
            dtgTelefono.Columns["IDNac"].Visible = false;
        }
    }
}
