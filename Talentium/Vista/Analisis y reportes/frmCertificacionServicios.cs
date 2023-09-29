using Comun;
using LogicaNegocio.Analisis_y_reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Analisis_y_reportes
{
    public partial class frmCertificacionServicios : Form
    {
        int _rowIndex = -1; // Index de la fila actual
        int _index = -1; // Index del id_persona de la fila actual
        int _etapa = 0;
        public frmCertificacionServicios()
        {
            InitializeComponent();
            //dtg configura el dtg
            dtgCertificados.MultiSelect = false;
            dtgCertificados.RowHeadersVisible = false;
            dtgCertificados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgCertificados.AllowUserToAddRows = false;
            dtgCertificados.AllowUserToResizeRows = false;
            dtgCertificados.ReadOnly = true;
            dtgCertificados.DataSource = null;
            refreshDtg();
        }

        private void dtgCertificados_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _rowIndex = e.RowIndex;
            _index = Convert.ToInt32(dtgCertificados.Rows[e.RowIndex].Cells[0].Value);
        }
        private void rdbEnProceso_CheckedChanged(object sender, EventArgs e)
        {
            _etapa = 0;
            btnAgregar.Enabled = true;
            UtilidadesForms.LimpiarControles(grpFiltro);
            refreshDtg();
        }
        private void rdbFinalizados_CheckedChanged(object sender, EventArgs e)
        {
            _etapa = 1;
            btnAgregar.Enabled = false;
            UtilidadesForms.LimpiarControles(grpFiltro);
            refreshDtg();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            int rows = refreshDtg(true);

            if (rows == 0)
            {
                MessageBox.Show("Ningun registro coinside");
            }

            UtilidadesForms.LimpiarControles(grpFiltro);
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaCertificacionServicios acs = new frmAltaCertificacionServicios();
            acs.ShowDialog();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            int id_certificacion = _index;
            int id_empleado = Convert.ToInt32(dtgCertificados.Rows[_rowIndex].Cells[8].Value);
            frmAltaCertificacionServicios acs = new frmAltaCertificacionServicios(id_certificacion, id_empleado);
            acs.ShowDialog();
        }
        #region metodos
        public int refreshDtg(bool filtro = false)
        {
            CN_ConsultarCertificacionServicios ccs = new CN_ConsultarCertificacionServicios();
            DataTable dt = ccs.ConsultaCertificacionServicios(txtCuit.Text, txtNombre.Text, txtApellido.Text, _etapa);
            if (!filtro || (filtro && dt.Rows.Count > 0))
            {
                dtgCertificados.DataSource = dt;

                dtgCertificados.Columns[0].Visible = false;
                dtgCertificados.Columns[7].Visible = false;
                dtgCertificados.Columns[8].Visible = false;
                dtgCertificados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }

            return dt.Rows.Count;
        }
        #endregion
    }
}
