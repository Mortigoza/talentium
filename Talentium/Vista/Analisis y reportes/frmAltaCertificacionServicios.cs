using Comun;
using LogicaNegocio.Analisis_y_reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Lenguajes;
using Vista.Properties;

namespace Vista.Analisis_y_reportes
{
    public partial class frmAltaCertificacionServicios : Form
    {
        private bool _mod = false; // Si es modificacion de usuario (true) o alta de usuario (false)
        private int _idEmpleado;
        private int _idCertificacion;
        private int _etapa = 0;

        int _rowIndex = -1; // Index de la fila actual
        int _index = -1; // Index del id_persona de la fila actual

        // Filtros
        string _cuit;
        string _nombre;
        string _apellido;
        bool _estado = true;

        DataTable dtEtapas = new DataTable();
        public frmAltaCertificacionServicios()
        {
            InitializeComponent();
            Idioma.CargarIdioma(this.Controls, this); //Asigno los nombres a los controles del formulario

            //dtg configura el dtg
            dtgCertificados.MultiSelect = false;
            dtgCertificados.RowHeadersVisible = false;
            dtgCertificados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgCertificados.AllowUserToAddRows = false;
            dtgCertificados.AllowUserToResizeRows = false;
            dtgCertificados.ReadOnly = true;
            dtgCertificados.DataSource = null;
            dtgCertificados.Columns.Clear();

            //cmbEtapas
            Etapas.Culture = Thread.CurrentThread.CurrentUICulture;
            cmbEtapa.Items.Insert(0, Etapas.cmbEtapa_0);
            cmbEtapa.SelectedIndex = 0;
            cmbEtapa.Enabled = false;

            //lblPersona
            lblPersona.Text = "";
        }
        public frmAltaCertificacionServicios(int idCertificacion, int idEmpleado, int etapa)
        {
            InitializeComponent();
            Idioma.CargarIdioma(this.Controls, this); //Asigno los nombres a los controles del formulario

            _idCertificacion= idCertificacion;
            _idEmpleado = idEmpleado;
            _etapa= etapa;

            //dtg configura el dtg
            dtgCertificados.MultiSelect = false;
            dtgCertificados.RowHeadersVisible = false;
            dtgCertificados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgCertificados.AllowUserToAddRows = false;
            dtgCertificados.AllowUserToResizeRows = false;
            dtgCertificados.ReadOnly = true;
            dtgCertificados.DataSource = null;
            dtgCertificados.Columns.Clear();

            //cmbEtapas
            Etapas.Culture = Thread.CurrentThread.CurrentUICulture;
            cmbEtapa.Items.Insert(0, Etapas.cmbEtapa_0);

            switch (etapa)
            {
                case 1:
                    cmbEtapa.Items.Insert(1, Etapas.cmbEtapa_1);
                    cmbEtapa.SelectedIndex = 1;
                    break;
                case 2:
                    cmbEtapa.Items.Insert(1, Etapas.cmbEtapa_1);
                    cmbEtapa.Items.Insert(2, Etapas.cmbEtapa_2);
                    cmbEtapa.SelectedIndex = 2;
                    break;
                case 3:
                    cmbEtapa.Items.Insert(1, Etapas.cmbEtapa_1);
                    cmbEtapa.Items.Insert(2, Etapas.cmbEtapa_2);
                    cmbEtapa.SelectedIndex = 2;
                    cmbEtapa.Enabled = false;
                    break;
            }

            //lblPersona
            lblPersona.Text = "";

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (_mod)
            {
                default:

                    break;
                case true:

                    break;
            }
        }

        private void cmbEtapa_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbEtapa.SelectedIndex)
            {
                case 0:
                    lblFechaSolicitud.Text = Etapas.lblFechaSolicitud_0;
                    break;
                case 1:
                    lblFechaSolicitud.Text = Etapas.lblFechaSolicitud_1;
                    break;
                case 2:
                    lblFechaSolicitud.Text = Etapas.lblFechaSolicitud_2;
                    break;
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtCuit.Text) && string.IsNullOrEmpty(txtNombre.Text)
                && string.IsNullOrEmpty(txtApellido.Text))
            // Entra si los campos de filtrado estan todos en su estado por defecto
            {
                MessageBox.Show("Utilice al menos un filtro");
            }
            else
            //Entra si se usa al menos uno de los filtros
            {
                _cuit = txtCuit.Text;
                _nombre = txtNombre.Text;
                _apellido = txtApellido.Text;

                CN_ConsultarCertificacionServicios ccs = new CN_ConsultarCertificacionServicios();
                DataTable dt = ccs.ConsultaPersonalCertificacion(_cuit, _nombre, _apellido, _estado);

                if (dt.Rows.Count == 0)
                {
                    // Si el dtg es ejecutado y el filtrado no devuelve registros aparece un messagebox
                    MessageBox.Show("Ningun registro coinside");
                }
                else
                {
                    refreshDtg(dt);
                    UtilidadesForms.LimpiarControles(grpFiltro);
                }
            }
        }

        private void rdbActivos_CheckedChanged(object sender, EventArgs e)
        {

            // Configura los controles cuando se checkea el rdb activos
            if (rdbActivos.Checked)
            {
                _estado = true;
                if (dtgCertificados.DataSource != null)
                {
                    refreshDtg();
                }
            }
        }

        private void rdbInactivos_CheckedChanged(object sender, EventArgs e)
        {
            // Configura los controles cuando se checkea el rdb inactivos
            if (rdbInactivos.Checked)
            {
                _estado = false;
                if (dtgCertificados.DataSource != null)
                {
                    refreshDtg();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void dtgCertificados_DataSourceChanged(object sender, EventArgs e)
        {
            if (dtgCertificados.Rows.Count == 0)
            {
                lblPersona.Text = "";
            }
        }
        private void dtgCertificados_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _rowIndex = e.RowIndex;
            _index = Convert.ToInt32(dtgCertificados.Rows[_rowIndex].Cells[0].Value);
            lblPersona.Text = $"{dtgCertificados.Rows[_rowIndex].Cells[1].Value}    {dtgCertificados.Rows[_rowIndex].Cells[2].Value}    {dtgCertificados.Rows[_rowIndex].Cells[3].Value}";

        }
        #region metodos
        public void refreshDtg(DataTable dt = null)
        {
            if (dt == null)
            {
                CN_ConsultarCertificacionServicios ccs = new CN_ConsultarCertificacionServicios();
                dt = ccs.ConsultaPersonalCertificacion(_cuit, _nombre, _apellido, _estado);
            }

            dtgCertificados.DataSource = dt;
            dtgCertificados.Columns[0].Visible = false;
            dtgCertificados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        public void refreshDtg(int idPersona, int idCertificacion)
        {
            CN_ConsultarCertificacionServicios ccs = new CN_ConsultarCertificacionServicios();
            //DataTable dt = ;

            //dtgCertificados.DataSource = dt;
            dtgCertificados.Columns[0].Visible = false;
            dtgCertificados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        #endregion

    }
}
