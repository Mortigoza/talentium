using Comun;
using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmAltaUsuario : Form
    {
        CN_LogicaUsuarios usuario = new CN_LogicaUsuarios();
        int _rowIndex = -1;
        int _index = -1;
        bool configEnd = false;
        bool perfilCustom = false;
        DataTable dtListaBd; 
        DataTable dtListaMem = new DataTable("Permisos");
        private string emailPersona = "";
        public frmAltaUsuario()
        {
            InitializeComponent();
            #region config
            //dtg
            dtgPersonas.MultiSelect = false;
            dtgPersonas.RowHeadersVisible = false;
            dtgPersonas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgPersonas.AllowUserToAddRows = false;
            dtgPersonas.AllowUserToResizeRows = false;
            dtgPersonas.ReadOnly = true;
            dtgPersonas.DataSource = null;
            //lblDatos
            lblDatosDtg.Text = "";
            //cmb area
            cmbArea.DataSource = null;
            cmbArea.DataSource = usuario.ConsultarAreas();
            cmbArea.ValueMember = "id_area";
            cmbArea.DisplayMember = "area";
            //cmb perfiles
            cmbRol.DataSource = null;
            cmbRol.DataSource = usuario.ConsultarPerfiles();
            cmbRol.ValueMember = "id_grupo";
            cmbRol.DisplayMember = "grupo";
            cmbRol.SelectedValue = -1;
            //dt
            DataColumn idColumn = new DataColumn();
            idColumn.DataType = System.Type.GetType("System.Int32");
            idColumn.ColumnName = "id_permiso";
            dtListaMem.Columns.Add(idColumn);

            DataColumn fNameColumn = new DataColumn();
            fNameColumn.DataType = System.Type.GetType("System.String");
            fNameColumn.ColumnName = "funcionalidad";
            dtListaMem.Columns.Add(fNameColumn);
            //lst
            lstPermisos.DataSource = null;
            dtListaBd = usuario.ConsultarPermisosLst();
            lstPermisos.DataSource = dtListaBd;
            lstPermisos.ValueMember = "id_permiso";
            lstPermisos.DisplayMember = "funcionalidad";

            lstPermisosAsignados.DataSource = null;
            lstPermisosAsignados.DataSource = dtListaMem;
            lstPermisosAsignados.ValueMember = "id_permiso";
            lstPermisosAsignados.DisplayMember = "funcionalidad";
            #endregion

            configEnd = true;
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
            Tuple<bool, string> verif = usuario.ValidarAltaUsuario(txtUsuario.Text, txtContrasenia.Text, dtgPersonas, _rowIndex).ToTuple();
            if (verif.Item1)
            {
                List<int> permisos = new List<int>();
                int len = dtListaMem.Rows.Count;

                for (int i = 0; i < len; i++)
                {
                    permisos.Add(Convert.ToInt32(dtListaMem.Rows[i][0]));
                }

                string msg = usuario.MandarMail(_index, txtContrasenia.Text, txtEmail.Text);
                try
                {
                    if (string.IsNullOrEmpty(msg))
                    {
                        usuario.InsertarNuevoUsuario(_index, txtUsuario.Text, txtContrasenia.Text, Convert.ToInt32(nmrCambiaCada.Value), permisos.ToArray(), txtEmail.Text);
                        MessageBox.Show("Alta exitosa");
                    }
                    else
                    {
                        MessageBox.Show(msg);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show(verif.Item2);
            }
        }

        private void btnCrearContrasenia_Click(object sender, EventArgs e)
        {
            txtContrasenia.Text = Seguridad.GenerarStringAleatorio();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCuit.Text) && string.IsNullOrEmpty(txtNombre.Text)
                && string.IsNullOrEmpty(txtApellido.Text)&& (int) cmbArea.SelectedValue == -1)
            {
                MessageBox.Show("Utilice al menos un filtro");
            }
            else
            {
                DataTable dt = usuario.ConsultarPersonalAltaUsuario(txtCuit.Text, txtNombre.Text, txtApellido.Text, (int)cmbArea.SelectedValue);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Ningun registro coinside");
                }
                else
                {
                    dtgPersonas.DataSource = null;
                    dtgPersonas.DataSource = dt;
                    dtgPersonas.Columns[0].Visible = false;
                    dtgPersonas.Columns[6].Visible = false;
                }
            }

        }

        private void dtgPersonas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _rowIndex = e.RowIndex;
            _index = Convert.ToInt32(dtgPersonas.Rows[e.RowIndex].Cells[0].Value);
            lblDatosDtg.Text = $"{dtgPersonas.Rows[e.RowIndex].Cells[1].Value}    {dtgPersonas.Rows[e.RowIndex].Cells[2].Value}    {dtgPersonas.Rows[e.RowIndex].Cells[3].Value}";
            emailPersona = dtgPersonas.Rows[e.RowIndex].Cells[6].Value.ToString();
            if (chcEmail.Checked == false)
            {
                txtEmail.Text = emailPersona;
            }

        }

        private void btnAsignarPermisos_Click(object sender, EventArgs e)
        {
            UtilidadesForms.moverListboxRow(lstPermisos, lstPermisosAsignados, dtListaBd, dtListaMem, lstPermisos.SelectedIndex);
            PerfilCustom();
        }
        private void lstPermisos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            UtilidadesForms.moverListboxRow(lstPermisos, lstPermisosAsignados, dtListaBd, dtListaMem, lstPermisos.SelectedIndex);
            PerfilCustom();
        }

        private void btnDesasignarPermisos_Click(object sender, EventArgs e)
        {
            UtilidadesForms.moverListboxRow(lstPermisosAsignados, lstPermisos, dtListaMem, dtListaBd, lstPermisosAsignados.SelectedIndex);
            PerfilCustom();
        }

        private void lstPermisosAsignados_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            UtilidadesForms.moverListboxRow(lstPermisosAsignados, lstPermisos, dtListaMem, dtListaBd, lstPermisosAsignados.SelectedIndex);
            PerfilCustom();
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (configEnd && !perfilCustom)
            {
                int id_perfil = -1;
                try
                {
                    id_perfil = (int)cmbRol.SelectedValue;
                }
                catch { }

                DataTable dtPermisosPerfil = usuario.ConsultarPermisosPerfil(id_perfil);
                DataTable dtPermisosDef = usuario.ConsultarPermisosLst();

                if (id_perfil != -1)
                {
                    configListbox(dtPermisosDef, true, dtPermisosPerfil);
                }
                else
                {
                    configListbox(dtPermisosDef);
                }
            }
        }
        public void configListbox(DataTable dtLeft, bool def = false, DataTable dtRight = null)
        {
            // dtLeft trae todos los permisos
            // dtRight trae los permisos asociados al perfil

            dtListaBd.Clear();
            if (def)
            {
                for (int i = 0; i < dtLeft.Rows.Count; i++)
                {
                    int nLeft = (int)dtLeft.Rows[i][0];
                    for (int j = 0; j < dtRight.Rows.Count; j++)
                    {
                        if (nLeft == (int)dtRight.Rows[j][0])
                        {
                            dtLeft.Rows.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }
            dtListaBd.Clear();
            dtListaBd = dtLeft;
            lstPermisos.DataSource = dtListaBd;
            lstPermisos.Update();

            dtListaMem.Clear();
            if (def) dtListaMem = dtRight;
            lstPermisosAsignados.DataSource = dtListaMem;
            lstPermisosAsignados.Update();
        }
        public void PerfilCustom()
        {

            if ((int)cmbRol.SelectedValue != -1)
            {
                perfilCustom = true;
                cmbRol.SelectedValue = -1;
                perfilCustom = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void chcEmail_CheckedChanged(object sender, EventArgs e)
        {
            switch (chcEmail.Checked)
            {
                default:
                    txtEmail.ReadOnly = true;
                    txtEmail.Text = emailPersona;
                    break;
                case true:
                    txtEmail.ReadOnly = false;
                    txtEmail.Text = "";
                    break;
            }
        }

        private void btnAsignarPermisosTodos_Click(object sender, EventArgs e)
        {
            for (int i = 0, len = lstPermisos.Items.Count; i < len; i++)
            {
                UtilidadesForms.moverListboxRow(lstPermisos, lstPermisosAsignados, dtListaBd, dtListaMem, 0);
            }
            PerfilCustom();
        }

        private void btnDesasignarPermisosTodos_Click(object sender, EventArgs e)
        {
            for (int i = 0, len = lstPermisosAsignados.Items.Count; i < len; i++)
            {
                UtilidadesForms.moverListboxRow(lstPermisosAsignados, lstPermisos, dtListaMem, dtListaBd, 0);
            }
            PerfilCustom();
        }
    }
}
