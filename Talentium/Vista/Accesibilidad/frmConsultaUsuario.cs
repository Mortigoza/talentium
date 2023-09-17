using LogicaNegocio;
using LogicaNegocio.Accesibilidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmConsultaUsuario : Form
    {
        int _index = -1;
        public frmConsultaUsuario()
        {
            InitializeComponent();
            //dtg
            dtgPersonas.MultiSelect = false;
            dtgPersonas.RowHeadersVisible = false;
            dtgPersonas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgPersonas.AllowUserToAddRows = false;
            dtgPersonas.AllowUserToResizeRows = false;
            dtgPersonas.ReadOnly = true;
            dtgPersonas.DataSource = null;
            //cmb area
            cmbArea.DataSource = null;
            CN_LogicaUsuarios usuario = new CN_LogicaUsuarios();
            cmbArea.DataSource = usuario.ConsultarAreas();
            cmbArea.ValueMember = "id_area";
            cmbArea.DisplayMember = "area";
            cmbArea.SelectedValue = -1;
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

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) && string.IsNullOrEmpty(txtNombre.Text)
                && string.IsNullOrEmpty(txtApellido.Text) && (int)cmbArea.SelectedValue == -2)
            {
                MessageBox.Show("Utilice al menos un filtro");
            }
            else
            {
                CN_ConsultarUsuario cu = new CN_ConsultarUsuario();
                DataTable dt = cu.ConsultarUsuario(txtUsuario.Text, txtNombre.Text, txtApellido.Text, (int)cmbArea.SelectedValue);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Ningun registro coinside");
                }
                else
                {
                    dtgPersonas.DataSource = null;
                    dtgPersonas.DataSource = dt;
                    dtgPersonas.Columns[0].Visible = false;
                    dtgPersonas.AutoResizeColumns();
                }
            }
        }

        private void dtgPersonas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _index = Convert.ToInt32(dtgPersonas.Rows[e.RowIndex].Cells[0].Value);
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_index.ToString());
        }
    }
}
