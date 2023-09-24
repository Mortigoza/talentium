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
            dtgPerfiles.DataSource = null;

            dtgPerfiles.DataSource = logica.ConsultarPerfiles(false);
            dtgPerfiles.Columns[0].Visible = false;

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
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
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

        private void btnAsignarPermisos_Click(object sender, EventArgs e)
        {
            UtilidadesForms.moverListboxRow(lstPermisos, lstPermisosAsignados, dtListaBd, dtListaMem, lstPermisos.SelectedIndex);

        }

        private void btnDesasignarPermisos_Click(object sender, EventArgs e)
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
        // ConfigListbox metodo
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
                            //ap.AltaPerfil(txtNombrePermiso.Text, txtDescripcion.Text, permisos.ToArray());
                            UtilidadesForms.LimpiarControles(this);
                            DataTable dtPermisosDef = logica.ConsultarPermisosLst();
                            configListbox(dtPermisosDef);

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
                    MessageBox.Show("Modificar");
                    break;
            }
        }
        private void dtgPerfiles_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _rowIndex = e.RowIndex;
            _index = Convert.ToInt32(dtgPerfiles.Rows[_rowIndex].Cells[0].Value);
        }

        private void chcModificar_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dtPermisosDef = logica.ConsultarPermisosLst();
            switch (chcModificar.Checked)
            {
                case true:
                    btnAgregar.Name = "btnModificar";
                    btnAgregar.Text = "Modificar";
                    btnBaja.Enabled = false;
                    //DataTable permisosPerfil = null;                            // HACER UN SP
                    //configListbox(dtPermisosDef, true, permisosPerfil);
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
    }
}
