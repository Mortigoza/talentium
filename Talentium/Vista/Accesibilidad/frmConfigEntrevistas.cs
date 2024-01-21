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
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string entrevista = txtNombreEntrevista.Text.Trim();

            if (string.IsNullOrWhiteSpace(entrevista))
            {
                MessageBox.Show("Debe completar el campo.");
            }
            else
            {
                bool esEntrevistaValida = logicaEntrevista.ValidarEntrevista(entrevista);

                if (!esEntrevistaValida)
                {
                    MessageBox.Show("Alta de entrevista exitosa.");
                    txtNombreEntrevista.Clear();
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
            dtgEntrevistas.Columns["id_entrevista"].DataPropertyName = "id_entrevista";
            dtgEntrevistas.Columns["entrevista"].DataPropertyName = "entrevista";
        }
    }
}
