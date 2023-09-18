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
        private string _usr = "";
        private string _nom = "";
        private string _ape = "";
        private int _area = -1;
        private bool _estado = true;
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
                && string.IsNullOrEmpty(txtApellido.Text) && (int)cmbArea.SelectedValue == -1)
            {
                MessageBox.Show("Utilice al menos un filtro");
            }
            else
            {
                CN_ConsultarUsuario cu = new CN_ConsultarUsuario();
                _usr = txtUsuario.Text;
                _nom = txtNombre.Text;
                _ape = txtApellido.Text;
                _area = (int)cmbArea.SelectedValue;
                DataTable dt = cu.ConsultarUsuario(_usr, _nom, _ape, _area,_estado);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Ningun registro coinside");
                    _estado = !_estado;
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaUsuario alta = new frmAltaUsuario();
            alta.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void rdbActivos_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbActivos.Checked)
            {
                _estado = true;
                if (dtgPersonas.DataSource != null)
                {
                    btnFiltrar_Click(sender, e);
                    rdbActivos.Checked = _estado;
                    rdbInactivos.Checked = !_estado;
                }
            }
        }

        private void rdbInactivos_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbInactivos.Checked)
            {
                _estado = false;
                if (dtgPersonas.DataSource != null)
                {
                    btnFiltrar_Click(sender, e);
                    rdbActivos.Checked = _estado;
                    rdbInactivos.Checked = !_estado;
                }
            }
        }
    }
}
