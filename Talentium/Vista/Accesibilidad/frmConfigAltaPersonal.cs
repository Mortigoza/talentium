﻿using LogicaNegocio.Accesibilidad;
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
            grpModificarIdioma.Enabled = false;
            CargarDataGrid();
            CargarDataGridTipoTel();
            CargarDataGridNacionalidad();
            CargarDataGridGenero();
            CargarDataGridIdioma();
            CargarDataGridArea();
            CargarDataGridPuesto();
            // Config data grid Tipo de documento
            dtgDocumento.AutoGenerateColumns = false;
            dtgDocumento.AllowUserToAddRows = false;
            dtgDocumento.MultiSelect = false;
            dtgDocumento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDocumento.ReadOnly = true;
            dtgDocumento.RowHeadersVisible = false;
            // Config data grid Tipo de teléfono
            dtgTelefono.AutoGenerateColumns = false;
            dtgTelefono.AllowUserToAddRows = false;
            dtgTelefono.MultiSelect = false;
            dtgTelefono.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgTelefono.ReadOnly = true;
            dtgTelefono.RowHeadersVisible = false;
            // Config data grid Nacionalidad
            dtgNacionalidad.AutoGenerateColumns = false;
            dtgNacionalidad.AllowUserToAddRows = false;
            dtgNacionalidad.MultiSelect = false;
            dtgNacionalidad.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgNacionalidad.ReadOnly = true;
            dtgNacionalidad.RowHeadersVisible = false;
            // Config data grid Género
            dtgGenero.AutoGenerateColumns = false;
            dtgGenero.AllowUserToAddRows = false;
            dtgGenero.MultiSelect = false;
            dtgGenero.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgGenero.ReadOnly = true;
            dtgGenero.RowHeadersVisible = false;
            // Config data grid Idioma
            dtgIdiomas.AutoGenerateColumns = false;
            dtgIdiomas.AllowUserToAddRows = false;
            dtgIdiomas.MultiSelect = false;
            dtgIdiomas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgIdiomas.ReadOnly = true;
            dtgIdiomas.RowHeadersVisible = false;
            // Config data grid Área
            dtgArea.AutoGenerateColumns = false;
            dtgArea.AllowUserToAddRows = false;
            dtgArea.MultiSelect = false;
            dtgArea.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgArea.ReadOnly = true;
            dtgArea.RowHeadersVisible = false;
            // Config data grid Puesto
            dtgPuesto.AutoGenerateColumns = false;
            dtgPuesto.AllowUserToAddRows = false;
            dtgPuesto.MultiSelect = false;
            dtgPuesto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgPuesto.ReadOnly = true;
            dtgPuesto.RowHeadersVisible = false;
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
            if (dtgDocumento.SelectedRows.Count > 0)
            {
                int id_tipo_doc = Convert.ToInt32(dtgDocumento.SelectedRows[0].Cells["ID"].Value);

                if (string.IsNullOrWhiteSpace(txtDocumentoMod.Text))
                {
                    MessageBox.Show("Por favor, asegúrate de que el campo esté completo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (!config.ModificarTipoDoc(id_tipo_doc, txtDocumentoMod.Text))
                    {
                        MessageBox.Show("Se modificó el Tipo de documento correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDataGrid();
                        txtDocumentoMod.Clear();
                        grpModificar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("El Tipo de documento ya se encuentra en uso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtDocumentoMod.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }
        private void dtgDocumento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                grpModificar.Enabled = true;
                int rowIndex = e.RowIndex;
                DataGridViewRow selectedRow = dtgDocumento.Rows[rowIndex];
                txtDocumentoMod.Text = selectedRow.Cells["Nombre"].Value.ToString();
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
                int id_tipo_doc = Convert.ToInt32(dtgDocumento.SelectedRows[0].Cells[0].Value);
                if (config.TipoDocAsociadoAPersona(id_tipo_doc))
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
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
        private void txtDocumentoMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
        private void dtgDocumento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dtgDocumento.Rows[e.RowIndex].Selected = true;
                btnModificar.Enabled = true;
                btnBaja.Enabled = true;
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
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
        private void txtTipoTelMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
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
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
        private void txtNacioMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
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
                dtgNacionalidad.Rows[i].Cells["NombreNac"].Value = nacionalidad.Rows[i]["nacionalidad"];
            }
            dtgNacionalidad.Columns["IDNac"].Visible = false;
        }

        // tab Genero
        private void btnGeneroCancelarAlta_Click(object sender, EventArgs e)
        {
            txtGenero.Clear();
        }

        private void btnGeneroGuardarAlta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGenero.Text))
            {
                MessageBox.Show("Por favor, asegúrate de que el campo esté completo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!config.ValidarGenero(txtGenero.Text))
            {
                CargarDataGridGenero();
                MessageBox.Show("Se agregó el género correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGenero.Clear();
            }
            else
            {
                MessageBox.Show("El género ya se encuentra en uso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGenero.Clear();
            }
        }
        private void btnGeneroCancelarMod_Click(object sender, EventArgs e)
        {
            txtGeneroMod.Clear();
            grpModificarGenero.Enabled = false;
        }
        private void btnGuardarGeneroMod_Click(object sender, EventArgs e)
        {
            int id_genero = (int)dtgGenero.SelectedCells[0].Value;
            if (string.IsNullOrWhiteSpace(txtGeneroMod.Text))
            {
                MessageBox.Show("Por favor, asegúrate de que el campo esté completo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!config.ModificarGenero(id_genero, txtGeneroMod.Text))
            {
                CargarDataGridGenero();
                MessageBox.Show("Se modificó el género correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGeneroMod.Clear();
                grpModificarGenero.Enabled = false;
            }
            else
            {
                MessageBox.Show("El género ya se encuentra en uso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGeneroMod.Clear();
            }
        }
        private void btnGeneroMod_Click(object sender, EventArgs e)
        {
            grpModificarGenero.Enabled = true;
            if (dtgGenero.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dtgGenero.SelectedRows[0];

                if (filaSeleccionada.Cells["NombreGen"].Value != null)
                {
                    string valorCelda = filaSeleccionada.Cells["NombreGen"].Value.ToString();
                    txtGeneroMod.Text = valorCelda;
                }
            }
        }
        private void btnBajaGenero_Click(object sender, EventArgs e)
        {
            if (dtgGenero.SelectedRows.Count > 0)
            {
                int id_genero = Convert.ToInt32(dtgGenero.SelectedCells[0].Value);
                if (config.GeneroAsociadoAPersona(id_genero) == true)
                {
                    MessageBox.Show("No se puede eliminar el género porque se encuentra en uso.");
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("¿Quieres eliminar el género?", "Confirmar eliminación", MessageBoxButtons.OKCancel);

                    if (resultado == DialogResult.OK)
                    {
                        config.EliminarGenero(id_genero);
                        MessageBox.Show("El género ha sido eliminada con éxito.");
                        CargarDataGridGenero();
                    }
                    else if (resultado == DialogResult.Cancel)
                    {
                        MessageBox.Show("Se ha cancelado la operación.");
                    }
                }
            }
        }
        private void txtGenero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
        private void dtgGenero_SelectionChanged(object sender, EventArgs e)
        {
            btnGeneroMod.Enabled = dtgGenero.SelectedRows.Count > 0;
            btnBajaGenero.Enabled = dtgGenero.SelectedRows.Count > 0;
        }
        private void dtgGenero_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            grpModificarGenero.Enabled = true;
            if (e.RowIndex >= 0)
            {
                txtGeneroMod.Text = dtgGenero.SelectedCells[1].Value.ToString();
            }
        }
        public void CargarDataGridGenero()
        {
            DataTable genero = config.ObtenerGenero();
            dtgGenero.DataSource = genero;
            for (int i = 0; i < genero.Rows.Count; i++)
            {
                dtgGenero.Rows[i].Cells["NombreGen"].Value = genero.Rows[i]["genero"];
            }
            dtgGenero.Columns["IDGen"].Visible = false;
        }

        // tab Idiomas
        private void btnCancelarAltaIdioma_Click(object sender, EventArgs e)
        {
            txtIdiomasAlta.Clear();
        }
        public void CargarDataGridIdioma()
        {
            DataTable idioma = config.ObtenerIdioma();
            dtgIdiomas.DataSource = idioma;
            for (int i = 0; i < idioma.Rows.Count; i++)
            {
                dtgIdiomas.Rows[i].Cells["NombreIdioma"].Value = idioma.Rows[i]["idioma"];
            }
            dtgIdiomas.Columns["IDIdioma"].Visible = false;
        }

        private void btnCancelarIdiomaMod_Click(object sender, EventArgs e)
        {
            txtIdiomaMod.Clear();
            grpModificarIdioma.Enabled = false;
        }

        private void btnGuardarAltaIdioma_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdiomasAlta.Text))
            {
                MessageBox.Show("Por favor, asegúrate de que el campo esté completo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!config.ValidarIdioma(txtIdiomasAlta.Text))
            {
                CargarDataGridIdioma();
                MessageBox.Show("Se agregó el idioma correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdiomasAlta.Clear();
            }
            else
            {
                MessageBox.Show("El idioma ya se encuentra en uso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdiomasAlta.Clear();
            }
        }

        private void btnGuardarIdiomaMod_Click(object sender, EventArgs e)
        {
            int id_idioma = (int)dtgIdiomas.SelectedCells[0].Value;
            if (string.IsNullOrWhiteSpace(txtIdiomaMod.Text))
            {
                MessageBox.Show("Por favor, asegúrate de que el campo esté completo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!config.ModificarIdioma(id_idioma, txtIdiomaMod.Text))
            {
                CargarDataGridIdioma();
                MessageBox.Show("Se modificó el idioma correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdiomaMod.Clear();
                grpModificarIdioma.Enabled = false;
            }
            else
            {
                MessageBox.Show("El idioma ya se encuentra en uso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdiomaMod.Clear();
            }
        }

        private void btnModIdiomas_Click(object sender, EventArgs e)
        {
            grpModificarIdioma.Enabled = true;
            if (dtgIdiomas.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dtgIdiomas.SelectedRows[0];

                if (filaSeleccionada.Cells["NombreIdioma"].Value != null)
                {
                    string valorCelda = filaSeleccionada.Cells["NombreIdioma"].Value.ToString();
                    txtIdiomaMod.Text = valorCelda;
                }
            }
        }

        private void dtgIdiomas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dtgIdiomas_SelectionChanged(object sender, EventArgs e)
        {
            btnModIdiomas.Enabled = dtgIdiomas.SelectedRows.Count > 0;
            btnBajaIdiomas.Enabled = dtgIdiomas.SelectedRows.Count > 0;
        }

        private void txtIdiomasAlta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtIdiomaMod_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtIdiomaMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void dtgIdiomas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            grpModificarIdioma.Enabled = true;
            if (e.RowIndex >= 0)
            {
                txtIdiomaMod.Text = dtgIdiomas.SelectedCells[1].Value.ToString();
            }
        }

        private void btnBajaIdiomas_Click(object sender, EventArgs e)
        {
            if (dtgIdiomas.SelectedRows.Count > 0)
            {
                int id_idiomas = Convert.ToInt32(dtgIdiomas.SelectedCells[0].Value);
                if (config.IdiomaAsociadoAPersona(id_idiomas) == true)
                {
                    MessageBox.Show("No se puede eliminar el idioma porque se encuentra en uso.");
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("¿Quieres eliminar el idioma?", "Confirmar eliminación", MessageBoxButtons.OKCancel);

                    if (resultado == DialogResult.OK)
                    {
                        config.EliminarIdioma(id_idiomas);
                        MessageBox.Show("El idioma ha sido eliminada con éxito.");
                        CargarDataGridIdioma();
                    }
                    else if (resultado == DialogResult.Cancel)
                    {
                        MessageBox.Show("Se ha cancelado la operación.");
                    }
                }
            }
        }

        // tab Área
        private void btnCancelarAltaArea_Click(object sender, EventArgs e)
        {
            txtAreaAlta.Clear();
        }

        private void btnGuardarAltaArea_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAreaAlta.Text))
            {
                MessageBox.Show("Por favor, asegúrate de que el campo esté completo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!config.ValidarArea(txtAreaAlta.Text))
            {
                CargarDataGridArea();
                MessageBox.Show("Se agregó el área correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAreaAlta.Clear();
            }
            else
            {
                MessageBox.Show("El área ya se encuentra en uso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAreaAlta.Clear();
            }
        }

        private void btnCancelarModArea_Click(object sender, EventArgs e)
        {
            txtAreaMod.Clear();
            grpModificarArea.Enabled = false;
        }

        private void btnGuardarModArea_Click(object sender, EventArgs e)
        {
            int id_area = (int)dtgArea.SelectedCells[0].Value;
            if (string.IsNullOrWhiteSpace(txtAreaMod.Text))
            {
                MessageBox.Show("Por favor, asegúrate de que el campo esté completo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!config.ModificarArea(id_area, txtAreaMod.Text))
            {
                CargarDataGridArea();
                MessageBox.Show("Se modificó el área correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAreaMod.Clear();
                grpModificarArea.Enabled = false;
            }
            else
            {
                MessageBox.Show("El área ya se encuentra en uso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAreaMod.Clear();
            }
        }

        private void btnBajaArea_Click(object sender, EventArgs e)
        {
            if (dtgArea.SelectedRows.Count > 0)
            {
                int id_area = Convert.ToInt32(dtgArea.SelectedCells[0].Value);
                if (config.AreaAsociadoAPersona(id_area) == true)
                {
                    MessageBox.Show("No se puede eliminar el área porque se encuentra en uso.");
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("¿Quieres eliminar el área?", "Confirmar eliminación", MessageBoxButtons.OKCancel);

                    if (resultado == DialogResult.OK)
                    {
                        config.EliminarArea(id_area);
                        MessageBox.Show("El área ha sido eliminado con éxito.");
                        CargarDataGridArea();
                    }
                    else if (resultado == DialogResult.Cancel)
                    {
                        MessageBox.Show("Se ha cancelado la operación.");
                    }
                }
            }
        }

        private void btnModificarArea_Click(object sender, EventArgs e)
        {
            grpModificarArea.Enabled = true;
            if (dtgArea.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dtgArea.SelectedRows[0];

                if (filaSeleccionada.Cells["NombreArea"].Value != null)
                {
                    string valorCelda = filaSeleccionada.Cells["NombreArea"].Value.ToString();
                    txtAreaMod.Text = valorCelda;
                }
            }
        }

        private void dtgArea_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            grpModificarArea.Enabled = true;
            if (e.RowIndex >= 0)
            {
                txtAreaMod.Text = dtgArea.SelectedCells[1].Value.ToString();
            }
        }

        private void dtgArea_SelectionChanged(object sender, EventArgs e)
        {
            btnModificarArea.Enabled = dtgArea.SelectedRows.Count > 0;
            btnBajaArea.Enabled = dtgArea.SelectedRows.Count > 0;
        }

        private void txtAreaAlta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtAreaMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
        public void CargarDataGridArea()
        {
            DataTable area = config.ObtenerArea();
            dtgArea.DataSource = area;
            for (int i = 0; i < area.Rows.Count; i++)
            {
                dtgArea.Rows[i].Cells["NombreArea"].Value = area.Rows[i]["area"];
            }
            dtgArea.Columns["IDArea"].Visible = false;
        }
        // tabPuesto
        private void btnCancelarPuestoAlta_Click(object sender, EventArgs e)
        {
            txtPuestoAlta.Clear();
        }

        private void btnGuardarPuestoAlta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPuestoAlta.Text))
            {
                MessageBox.Show("Por favor, asegúrate de que el campo esté completo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!config.ValidarPuesto(txtPuestoAlta.Text))
            {
                CargarDataGridPuesto();
                MessageBox.Show("Se agregó el puesto correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPuestoAlta.Clear();
            }
            else
            {
                MessageBox.Show("El puesto ya se encuentra en uso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPuestoAlta.Clear();
            }
        }

        private void btnCancelarPuestoMod_Click(object sender, EventArgs e)
        {
            txtPuestoModificar.Clear();
            grpModificarPuesto.Enabled = false;
        }

        private void btnGuardarPuestoMod_Click(object sender, EventArgs e)
        {
            int id_puesto = (int)dtgPuesto.SelectedCells[0].Value;
            if (string.IsNullOrWhiteSpace(txtPuestoModificar.Text))
            {
                MessageBox.Show("Por favor, asegúrate de que el campo esté completo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!config.ModificarPuesto(id_puesto, txtPuestoModificar.Text))
            {
                CargarDataGridPuesto();
                MessageBox.Show("Se modificó el puesto correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPuestoModificar.Clear();
                grpModificarPuesto.Enabled = false;
            }
            else
            {
                MessageBox.Show("El puesto ya se encuentra en uso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPuestoModificar.Clear();
            }
        }

        private void btnModificarPuesto_Click(object sender, EventArgs e)
        {
            grpModificarPuesto.Enabled = true;
            if (dtgPuesto.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dtgPuesto.SelectedRows[0];

                if (filaSeleccionada.Cells["NombrePuesto"].Value != null)
                {
                    string valorCelda = filaSeleccionada.Cells["NombrePuesto"].Value.ToString();
                    txtPuestoModificar.Text = valorCelda;
                }
            }
        }

        private void btnBajaPuesto_Click(object sender, EventArgs e)
        {
            if (dtgPuesto.SelectedRows.Count > 0)
            {
                int id_puesto = Convert.ToInt32(dtgPuesto.SelectedCells[0].Value);
                if (config.PuestoAsociadoAPersona(id_puesto) == true)
                {
                    MessageBox.Show("No se puede eliminar el puesto porque se encuentra en uso.");
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("¿Quieres eliminar el puesto?", "Confirmar eliminación", MessageBoxButtons.OKCancel);

                    if (resultado == DialogResult.OK)
                    {
                        config.EliminarPuesto(id_puesto);
                        MessageBox.Show("El puesto ha sido eliminado con éxito.");
                        CargarDataGridPuesto();
                    }
                    else if (resultado == DialogResult.Cancel)
                    {
                        MessageBox.Show("Se ha cancelado la operación.");
                    }
                }
            }
        }

        private void txtPuestoAlta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtPuestoModificar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void dtgPuesto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            grpModificarPuesto.Enabled = true;
            if (e.RowIndex >= 0)
            {
                txtPuestoModificar.Text = dtgPuesto.SelectedCells[1].Value.ToString();
            }
        }

        private void dtgPuesto_SelectionChanged(object sender, EventArgs e)
        {
            btnModificarPuesto.Enabled = dtgPuesto.SelectedRows.Count > 0;
            btnBajaPuesto.Enabled = dtgPuesto.SelectedRows.Count > 0;
        }
        public void CargarDataGridPuesto()
        {
            DataTable puesto = config.ObtenerPuesto();
            dtgPuesto.DataSource = puesto;
            for (int i = 0; i < puesto.Rows.Count; i++)
            {
                dtgPuesto.Rows[i].Cells["NombrePuesto"].Value = puesto.Rows[i]["puesto"];
            }
            dtgPuesto.Columns["IDPuesto"].Visible = false;
        }

        private void lnkAtras_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }
    }
}
