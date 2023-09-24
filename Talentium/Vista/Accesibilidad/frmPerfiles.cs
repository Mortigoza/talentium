using Comun;
using LogicaNegocio;
using LogicaNegocio.Accesibilidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Lenguajes;
using Vista.Properties;

namespace Vista.Accesibilidad
{
    public partial class frmPerfiles : Form
    {
        CN_LogicaUsuarios logica = new CN_LogicaUsuarios();
        bool perfilCustom = false; // Si es un perfil personalizado es true
        int _rowIndex = -1; // Index de la fila actual
        int _index = -1; // Index del id_persona de la fila actual
        DataTable dtListaBd; // Almacena los permisos existentes en la bd
        DataTable dtListaMem = new DataTable("Permisos"); // Almacena los permisos asignados al usuario que sera dado de alta
        public frmPerfiles()
        {
            InitializeComponent();
            Idioma.CargarIdioma(this.Controls, this);
            #region config

            this.Text = "Alta de usuarios";

            //dtg configura el dtg
            dtgPerfiles.MultiSelect = false;
            dtgPerfiles.RowHeadersVisible = false;
            dtgPerfiles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgPerfiles.AllowUserToAddRows = false;
            dtgPerfiles.AllowUserToResizeRows = false;
            dtgPerfiles.ReadOnly = true;
            refreshDtg();

            //dt, crea las columnas para el dtListaMem
            DataColumn idColumn = new DataColumn();
            idColumn.DataType = System.Type.GetType("System.Int32");
            idColumn.ColumnName = "id_permiso";
            dtListaMem.Columns.Add(idColumn);

            DataColumn fNameColumn = new DataColumn();
            fNameColumn.DataType = System.Type.GetType("System.String");
            fNameColumn.ColumnName = "funcionalidad";
            dtListaMem.Columns.Add(fNameColumn);

            //lst, carga los dt en las listBox de permisos
            lstPermisos.DataSource = null;
            dtListaBd = logica.ConsultarPermisosLst();
            lstPermisos.DataSource = dtListaBd;
            lstPermisos.ValueMember = "id_permiso";
            lstPermisos.DisplayMember = "funcionalidad";

            lstPermisosAsignados.DataSource = null;
            lstPermisosAsignados.DataSource = dtListaMem;
            lstPermisosAsignados.ValueMember = "id_permiso";
            lstPermisosAsignados.DisplayMember = "funcionalidad";

            #endregion
            dtgPerfiles.AutoResizeColumns();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void btnAsignarPermisos_Click(object sender, EventArgs e)
        {
            UtilidadesForms.moverListboxRow(lstPermisos, lstPermisosAsignados, dtListaBd, dtListaMem, lstPermisos.SelectedIndex);
        }
        private void lstPermisos_DoubleClick(object sender, EventArgs e)
        {
            UtilidadesForms.moverListboxRow(lstPermisos, lstPermisosAsignados, dtListaBd, dtListaMem, lstPermisos.SelectedIndex);
        }

        private void btnAsignarPermisosTodos_Click(object sender, EventArgs e)
        {

            if (lstPermisos.Items.Count > 0)
            {
                lstPermisos.SelectedIndex = 0;
                for (int i = 0, len = lstPermisos.Items.Count; i < len; i++)
                {
                    UtilidadesForms.moverListboxRow(lstPermisos, lstPermisosAsignados, dtListaBd, dtListaMem, 0);
                }
            }
        }

        private void btnDesasignarPermisos_Click(object sender, EventArgs e)
        {
            UtilidadesForms.moverListboxRow(lstPermisosAsignados, lstPermisos, dtListaMem, dtListaBd, lstPermisosAsignados.SelectedIndex);
        }

        private void lstPermisosAsignados_DoubleClick(object sender, EventArgs e)
        {
            UtilidadesForms.moverListboxRow(lstPermisosAsignados, lstPermisos, dtListaMem, dtListaBd, lstPermisosAsignados.SelectedIndex);
        }
        private void btnDesasignarPermisosTodos_Click(object sender, EventArgs e)
        {

            if (lstPermisosAsignados.Items.Count > 0)
            {
                lstPermisosAsignados.SelectedIndex = 0;
                for (int i = 0, len = lstPermisosAsignados.Items.Count; i < len; i++)
                {
                    UtilidadesForms.moverListboxRow(lstPermisosAsignados, lstPermisos, dtListaMem, dtListaBd, 0);
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int len;
            List<int> permisos = new List<int>(); // Lista permisos
            switch (btnAgregar.Name)
            {
                case "btnAgregar":
                    if (!string.IsNullOrEmpty(txtNombrePermiso.Text) && lstPermisosAsignados.Items.Count > 0)
                    {
                        // lista de permisos
                        len = dtListaMem.Rows.Count;

                        for (int i = 0; i < len; i++)
                        {
                            // carga todos los permisos del dtListaMem en la lista permisos
                            permisos.Add(Convert.ToInt32(dtListaMem.Rows[i][0]));
                        }
                        try
                        {
                            CN_AltaPerfil ap = new CN_AltaPerfil();
                            ap.AltaPerfil(txtNombrePermiso.Text, txtDescripcion.Text, permisos.ToArray());
                            UtilidadesForms.LimpiarControles(this);
                            DataTable dtPermisosDef = logica.ConsultarPermisosLst();
                            configListbox(dtPermisosDef);
                            refreshDtg();
                            MessageBox.Show("Alta exitosa");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un nombre de perfil valido y al menos un permiso");
                    }
                    break;

                case "btnModificar":
                    if (!string.IsNullOrEmpty(txtNombrePermiso.Text) && lstPermisosAsignados.Items.Count > 0)
                    {
                        // lista de permisos
                        len = dtListaMem.Rows.Count;

                        for (int i = 0; i < len; i++)
                        {
                            // carga todos los permisos del dtListaMem en la lista permisos
                            permisos.Add(Convert.ToInt32(dtListaMem.Rows[i][0]));
                        }
                        try
                        {
                            CN_UpPerfil up = new CN_UpPerfil();
                            up.UpPerfil(_index, txtNombrePermiso.Text, txtDescripcion.Text, permisos.ToArray());
                            UtilidadesForms.LimpiarControles(this);
                            DataTable dtPermisosDef = logica.ConsultarPermisosLst();
                            configListbox(dtPermisosDef);
                            refreshDtg();
                            MessageBox.Show("Modificación exitosa");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un nombre de perfil valido y al menos un permiso");
                    }
                    break;
            }
        }
        private void dtgPerfiles_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _rowIndex = e.RowIndex;
            _index = Convert.ToInt32(dtgPerfiles.Rows[_rowIndex].Cells[0].Value);

            DataTable dtPermisosDef = logica.ConsultarPermisosLst();
            switch (chcModificar.Checked)
            {
                case true:
                    cargarCamposMod(dtPermisosDef);
                    break;
                case false:
                    break;
            }
        }

        private void chcModificar_CheckedChanged(object sender, EventArgs e)
        {
                DataTable dtPermisosDef = logica.ConsultarPermisosLst();
                switch (chcModificar.Checked)
                {
                    case true:
                        if (dtgPerfiles.Rows.Count > 0)
                        {
                            btnAgregar.Name = "btnModificar";
                            btnAgregar.Text = "Modificar";
                            btnBaja.Enabled = false;
                            cargarCamposMod(dtPermisosDef);
                        }
                        else
                        {
                            chcModificar.Checked = false;
                        }
                        break;
                    case false:
                        btnAgregar.Name = "btnAgregar";
                        btnAgregar.Text = "Agregar";
                        btnBaja.Enabled = true;
                        UtilidadesForms.LimpiarControles(this);
                        configListbox(dtPermisosDef);
                        break;
                }
        }
        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Evitar que se genere una nueva línea
                e.Handled = true;

                // Obtener la posición actual del cursor
                int currentPosition = txtDescripcion.SelectionStart;

                // Obtener el texto del richTextBox
                string text = txtDescripcion.Text;

                // Insertar un espacio en la posición actual del cursor
                text = text.Insert(currentPosition - 1, " ");

                // Actualizar el texto del richTextBox
                txtDescripcion.Text = text;

                // Mover el cursor a la posición siguiente
                txtDescripcion.SelectionStart = currentPosition + 1;
            }
        }
        private void btnBaja_Click(object sender, EventArgs e)
        {
            CN_BajaPerfil bp = new CN_BajaPerfil();
            bp.BajaPerfil(_index);
            refreshDtg();
        }
        #region Metodos
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

        private void txtDescripcion_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        }
        public DataTable traerPermisos()
        {
            CN_ConsultarPermisosPerfil cpp = new CN_ConsultarPermisosPerfil();
            DataTable permisosPerfil = cpp.ConsultarPermisosPerfil(_index);
            return permisosPerfil;
        }
        public void cargarCamposMod(DataTable dtPermisosDef)
        {
            txtNombrePermiso.Text = dtgPerfiles.Rows[_rowIndex].Cells[1].Value.ToString();
            txtDescripcion.Text = dtgPerfiles.Rows[_rowIndex].Cells[2].Value.ToString();
            DataTable permisosPerfil = traerPermisos();
            configListbox(dtPermisosDef, true, permisosPerfil);
        }
        public void refreshDtg()
        {
            dtgPerfiles.DataSource = null;
            dtgPerfiles.DataSource = logica.ConsultarPerfiles(false);
            dtgPerfiles.Columns[2].MinimumWidth = 200;
            dtgPerfiles.Columns[0].Visible = false;
            dtgPerfiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        #endregion

    }
}
