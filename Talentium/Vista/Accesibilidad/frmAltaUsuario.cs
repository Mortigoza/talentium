using LogicaNegocio;
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
    public partial class frmAltaUsuario : Form
    {
        CN_LogicaUsuarios usuario = new CN_LogicaUsuarios();
        int _index = -1;
        bool _usuario = true;
        public frmAltaUsuario()
        {
            InitializeComponent();
            #region config
            dtgPersonas.RowHeadersVisible = false;
            dtgPersonas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgPersonas.AllowUserToAddRows = false;
            dtgPersonas.AllowUserToResizeRows = false;
            dtgPersonas.ReadOnly = true;
            dtgPersonas.DataSource = null;
            lblDatosDtg.Text = "";
            #endregion
        }

        private void frmAltaUsuario_Load(object sender, EventArgs e)
        {

        }

        private void tbcAltaUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbpUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (_index > 0 && !_usuario)
            {
                usuario.InsertarNuevoUsuario(_index, txtUsuario.Text, txtContrasenia.Text, Convert.ToInt32(nmrCambiaCada.Value));
            }
            else
            {
                MessageBox.Show("Error de alta");
            }
        }

        private void btnCrearContrasenia_Click(object sender, EventArgs e)
        {
            txtContrasenia.Text = "aaf";
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCuit.Text) && string.IsNullOrEmpty(txtNombre.Text) && string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Utilice al menos un filtro");
            }
            else
            {
                DataTable dt = usuario.ConsultarPersonalAltaUsuario(txtCuit.Text, txtNombre.Text, txtApellido.Text);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Ningun registro coinside");
                }
                else
                {
                    dtgPersonas.DataSource = null;
                    dtgPersonas.DataSource = dt;
                    dtgPersonas.Columns[0].Visible = false;
                }
            }

        }

        private void dtgPersonas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _index = Convert.ToInt32(dtgPersonas.Rows[e.RowIndex].Cells[0].Value);
            lblDatosDtg.Text = $"{dtgPersonas.Rows[e.RowIndex].Cells[1].Value}    {dtgPersonas.Rows[e.RowIndex].Cells[2].Value}    {dtgPersonas.Rows[e.RowIndex].Cells[3].Value}";

            if (!string.IsNullOrEmpty(dtgPersonas.Rows[e.RowIndex].Cells[4].Value.ToString()))
            {
                _usuario = true;
            }
            else
            {
                _usuario = false;
            }
        }
    }
}
