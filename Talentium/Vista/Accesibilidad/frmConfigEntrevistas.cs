using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio.Accesibilidad;

namespace Vista.Accesibilidad
{
    public partial class frmConfigEntrevistas : Form
    {
        CN_LogicaEntrevista logicaEntrevista = new CN_LogicaEntrevista();
        public frmConfigEntrevistas()
        {
            InitializeComponent();
            CargarDataGrid();
            dtgEntrevistas.AllowUserToAddRows = false;
            dtgEntrevistas.AutoGenerateColumns = false;
            dtgEntrevistas.MultiSelect = false;
            dtgEntrevistas.ReadOnly = true;
            grpModEntrevista.Enabled = false;
            dtgEntrevistas.Columns["id_entrevista"].Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string entrevista = txtNombreEntrevista.Text.Trim();
            int instancia = Convert.ToInt32(txtInstancia.Text.Trim());

            if (string.IsNullOrWhiteSpace(entrevista) && string.IsNullOrWhiteSpace(instancia.ToString()))
            {
                MessageBox.Show("Debe completar todos los campos.");
            }
            else
            {
                bool esEntrevistaValida = logicaEntrevista.ValidarEntrevista(instancia, entrevista);

                if (!esEntrevistaValida)
                {
                    MessageBox.Show("Alta de entrevista exitosa.");
                    txtNombreEntrevista.Clear();
                    txtInstancia.Clear();
                    CargarDataGrid();
                }
                else
                {
                    MessageBox.Show("Ese nombre de entrevista ya está en uso.");
                    txtNombreEntrevista.Clear();
                }
            }
        }

        private void CargarDataGrid()
        {
            dtgEntrevistas.DataSource = logicaEntrevista.ConsultarEntrevistas();
            dtgEntrevistas.Columns["etapa"].DataPropertyName = "etapa";
            dtgEntrevistas.Columns["entrevista"].DataPropertyName = "entrevista";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            grpModEntrevista.Enabled = true;
            if (dtgEntrevistas.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dtgEntrevistas.SelectedRows[0];

                if (filaSeleccionada.Cells["Entrevista"].Value != null)
                {
                    string valorCelda = filaSeleccionada.Cells["etapa"].Value.ToString();
                    string valorCelda2 = filaSeleccionada.Cells["Entrevista"].Value.ToString();
                    txtInstanciaMod.Text = valorCelda;
                    txtModNombre.Text = valorCelda2;
                }
            }
        }

        private void btnModCancelar_Click(object sender, EventArgs e)
        {
            txtModNombre.Clear();
            txtInstanciaMod.Clear();
            grpModEntrevista.Enabled = false;
            grpAltaEntrevista.Enabled = true;
        }

        private void dtgEntrevistas_DoubleClick(object sender, EventArgs e)
        {
            grpModEntrevista.Enabled = true;
            grpAltaEntrevista.Enabled = false;
            txtInstanciaMod.Text = dtgEntrevistas.SelectedCells[1].Value.ToString();
            txtModNombre.Text = dtgEntrevistas.SelectedCells[2].Value.ToString();
        }

        private void btnModGuardar_Click(object sender, EventArgs e)
        {
            if (dtgEntrevistas.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dtgEntrevistas.SelectedRows[0];

                if (filaSeleccionada.DataBoundItem is DataRowView registroSeleccionado)
                {
                    int idRegistroSeleccionado = Convert.ToInt32(registroSeleccionado["id_entrevista"]);
                    if (int.TryParse(txtInstanciaMod.Text.Trim(), out int etapa))
                    {
                        string nuevaEntrevista = txtModNombre.Text.Trim();

                        if (string.IsNullOrWhiteSpace(nuevaEntrevista) && string.IsNullOrWhiteSpace(etapa.ToString()))
                        {
                            MessageBox.Show("Debe completar los campos.");
                        }
                        else
                        {
                            bool modificacionExitosa = logicaEntrevista.ModificarEntrevista(idRegistroSeleccionado, etapa, nuevaEntrevista);

                            if (modificacionExitosa)
                            {
                                MessageBox.Show("Modificación de entrevista exitosa");
                                txtModNombre.Clear();
                                txtInstanciaMod.Clear();
                                CargarDataGrid();
                            }
                            else
                            {
                                MessageBox.Show("Ese nombre de entrevista ya está en uso.");
                                txtModNombre.Clear();
                                txtInstanciaMod.Clear();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("El valor de etapa no es un número válido.");
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombreEntrevista.Clear();
            txtInstancia.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = dtgEntrevistas.SelectedRows[0];
            int idRegistroSeleccionado = Convert.ToInt32(filaSeleccionada.Cells["id_entrevista"].Value);

            if (dtgEntrevistas.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("¿Queres eliminar la entrevista?", "Confirmar eliminación", MessageBoxButtons.OKCancel);

                if (resultado == DialogResult.OK)
                {
                    if (logicaEntrevista.EliminarEntrevista(idRegistroSeleccionado) == false)
                    {
                        MessageBox.Show("El área ha sido eliminada con éxito.");
                        CargarDataGrid();
                    } else
                    {
                        MessageBox.Show("No se puede eliminar la entrevista porque se encuentra en uso.");
                    }
                    
                    
                }
                else if (resultado == DialogResult.Cancel)
                {
                    MessageBox.Show("Se ha cancelado la operación.");
                }
            } else
            {
                MessageBox.Show("Debe seleccionar un registro.");
            }
        }

        private void dtgEntrevistas_SelectionChanged(object sender, EventArgs e)
        {
            btnModificar.Enabled = dtgEntrevistas.SelectedRows.Count > 0;
            btnEliminar.Enabled = dtgEntrevistas.SelectedRows.Count > 0;
        }
    }
}
