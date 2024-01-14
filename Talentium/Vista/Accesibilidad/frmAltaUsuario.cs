using Comun;
using LogicaNegocio;
using LogicaNegocio.Accesibilidad;
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
using Vista.Lenguajes;

namespace Vista
{
    public partial class frmAltaUsuario : Form
    {
        private bool _mod = false; // Si es modificacion de usuario (true) o alta de usuario (false)
        private int _idUsuario;

        CN_LogicaUsuarios usuario = new CN_LogicaUsuarios();
        int _rowIndex = -1; // Index de la fila actual
        int _idPersona = -1; // Index del id_persona de la fila actual
        bool configEnd = false; // Controla si la configuracion (el constructor) finalizó
        bool perfilCustom = false; // Si es un perfil personalizado es true
        DataTable dtListaBd; // Almacena los permisos existentes en la bd
        DataTable dtListaMem = new DataTable("Permisos"); // Almacena los permisos asignados al usuario que sera dado de alta
        private string emailPersona = "";

        //Constructor Alta de usuario
        public frmAltaUsuario()
        {
            InitializeComponent();
            Idioma.CargarIdioma(this.Controls, this); //Asigno los nombres a los controles del formulario
            #region config

            this.Text = Strings.frmAltaUsuario;

            //dtg configura el dtg
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
            cmbArea.SelectedValue = -1;
            //cmb perfiles
            cmbRol.DataSource = null;
            cmbRol.DataSource = usuario.ConsultarPerfiles();
            cmbRol.ValueMember = "id_grupo";
            cmbRol.DisplayMember = "Perfil";
            cmbRol.SelectedValue = -1;
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

        //Constructor Modificacion de usuario
        public frmAltaUsuario(int id_usuario)
        {
            InitializeComponent();
            Idioma.CargarIdioma(this.Controls, this); //Asigno los nombres a los controles del formulario
            #region config
            _idUsuario = id_usuario;
            _mod = true;
            this.Text =
            this.Text = Strings.frmModUsuario;

            //dtg configura el dtg
            dtgPersonas.MultiSelect = false;
            dtgPersonas.RowHeadersVisible = false;
            dtgPersonas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgPersonas.AllowUserToAddRows = false;
            dtgPersonas.AllowUserToResizeRows = false;
            dtgPersonas.ReadOnly = true;
            CN_ConsultarPersonaMod cpm = new CN_ConsultarPersonaMod();
            DataTable dt = cpm.ConsultarPersonaMod(id_usuario);
            dtgPersonas.DataSource = dt;
            dtgPersonas.Columns[0].Visible = false;
            dtgPersonas.Columns[6].Visible = false;
            dtgPersonas.Columns[7].Visible = false;
            dtgPersonas.Columns[8].Visible = false;

            //Cargar datos
            txtUsuario.Text = Seguridad.DesEncriptar(dt.Rows[0][7].ToString());
            nmrCambiaCada.Value = (int)(dt.Rows[0][8]);
            //Bloqueos de controles
            grpFiltro.Enabled = false;
            dtgPersonas.Enabled = false;
            txtUsuario.Enabled = false;
            txtContrasenia.Enabled = false;
            btnCrearContrasenia.Visible = false;
            //cmb perfiles
            cmbRol.DataSource = null;
            cmbRol.DataSource = usuario.ConsultarPerfiles();
            cmbRol.ValueMember = "id_grupo";
            cmbRol.DisplayMember = "Perfil";
            cmbRol.SelectedValue = -1;
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
            dtListaBd = usuario.ConsultarPermisosLst();
            lstPermisos.DataSource = dtListaBd;
            lstPermisos.ValueMember = "id_permiso";
            lstPermisos.DisplayMember = "funcionalidad";

            lstPermisosAsignados.DataSource = null;
            lstPermisosAsignados.DataSource = dtListaMem;
            lstPermisosAsignados.ValueMember = "id_permiso";
            lstPermisosAsignados.DisplayMember = "funcionalidad";

            CN_ConsultarPermisosUsuario cpu = new CN_ConsultarPermisosUsuario();
            DataTable dtPermisosUsuario = cpu.ConsultarPermisosUsuario(id_usuario);
            if (dtPermisosUsuario.Rows.Count > 0)
                configListbox(usuario.ConsultarPermisosLst(), true, dtPermisosUsuario);

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
            int len;
            string msg;
            List<int> permisos = new List<int>(); // Lista permisos
            switch (_mod)
            {
                default:  // Si esta en modo alta 

                    usuario.UsrName = txtUsuario.Text;
                    usuario.Contrasenia = txtContrasenia.Text;
                    usuario.CambiaCada = nmrCambiaCada.Value;
                    usuario.Mail = txtEmail.Text;
                    usuario.IdPersona = _idPersona;
                    usuario.RowIndex = _rowIndex;

                    if (usuario.AltaUsuario(dtListaMem, cmbRol.SelectedValue, dtgPersonas))
                    {
                        MessageBox.Show("Alta exitosa");
                        this.Dispose();
                    }
                    break;

                case true: // Si esta en modo modificacion 

                    len = dtListaMem.Rows.Count;

                    for (int i = 0; i < len; i++)
                    {
                        // carga todos los permisos del dtListaMem en la lista permisos
                        permisos.Add(Convert.ToInt32(dtListaMem.Rows[i][0]));
                    }
                    try
                    {
                        // Hace la modificacion
                        CN_UpUsuario uu = new CN_UpUsuario();
                        uu.UpUsuario(_idUsuario, (int)nmrCambiaCada.Value, permisos.ToArray(), txtEmail.Text);
                        MessageBox.Show("Modificación exitosa");
                        this.Dispose();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }

        private void btnCrearContrasenia_Click(object sender, EventArgs e)
        {
            // Crea una contraseña aleatoria para el usuario
            txtContrasenia.Text = Seguridad.GenerarStringAleatorio();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCuit.Text) && string.IsNullOrEmpty(txtNombre.Text)
                && string.IsNullOrEmpty(txtApellido.Text) && (int)cmbArea.SelectedValue == -1)
            // Entra si los campos de filtrado estan todos en su estado por defecto
            {
                MessageBox.Show("Utilice al menos un filtro");
            }
            else
            //Entra si se usa al menos uno de los filtros
            {
                DataTable dt = usuario.ConsultarPersonalAltaUsuario(txtCuit.Text, txtNombre.Text, txtApellido.Text, (int)cmbArea.SelectedValue);

                if (dt.Rows.Count == 0)
                {
                    // Si el dtg es ejecutado y el filtrado no devuelve registros aparece un messagebox
                    MessageBox.Show("Ningun registro coinside");
                }
                else
                {
                    // Carga los registros en el dtg
                    dtgPersonas.DataSource = null;
                    dtgPersonas.DataSource = dt;
                    dtgPersonas.Columns[0].Visible = false;
                    dtgPersonas.Columns[6].Visible = false;
                    UtilidadesForms.LimpiarControles(grpFiltro);
                    cmbArea.SelectedValue = -1;
                }
            }
            dtgPersonas.AutoResizeColumns();
        }

        private void dtgPersonas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            switch (_mod)
            {
                default: // Si esta en modo alta 

                    // Carga variables y carga el lblDatosDtg
                    _rowIndex = e.RowIndex;
                    _idPersona = Convert.ToInt32(dtgPersonas.Rows[e.RowIndex].Cells[0].Value);
                    lblDatosDtg.Text = $"{dtgPersonas.Rows[e.RowIndex].Cells[1].Value}    {dtgPersonas.Rows[e.RowIndex].Cells[2].Value}    {dtgPersonas.Rows[e.RowIndex].Cells[3].Value}";
                    emailPersona = dtgPersonas.Rows[e.RowIndex].Cells[6].Value.ToString();
                    if (chcEmail.Checked == false)
                    {
                        txtEmail.Text = emailPersona;
                    }
                    break;
                case true: // Si esta en modo modificacion 

                    // Carga variables y carga el lblDatosDtg
                    _rowIndex = e.RowIndex;
                    _idPersona = Convert.ToInt32(dtgPersonas.Rows[e.RowIndex].Cells[0].Value);
                    lblDatosDtg.Text = $"{dtgPersonas.Rows[e.RowIndex].Cells[1].Value}    {dtgPersonas.Rows[e.RowIndex].Cells[2].Value}    {dtgPersonas.Rows[e.RowIndex].Cells[3].Value}";
                    emailPersona = dtgPersonas.Rows[e.RowIndex].Cells[6].Value.ToString();
                    txtEmail.Text = emailPersona;
                    dtgPersonas.AutoResizeColumns();
                    break;
            }

        }

        private void btnAsignarPermisos_Click(object sender, EventArgs e)
        {
            // Mueve el permiso seleccionado a la derecha
            UtilidadesForms.moverListboxRow(lstPermisos, lstPermisosAsignados, dtListaBd, dtListaMem, lstPermisos.SelectedIndex);
            PerfilCustom();
        }
        private void lstPermisos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Mueve el permiso seleccionado a la derecha
            UtilidadesForms.moverListboxRow(lstPermisos, lstPermisosAsignados, dtListaBd, dtListaMem, lstPermisos.SelectedIndex);
            PerfilCustom();
        }

        private void btnDesasignarPermisos_Click(object sender, EventArgs e)
        {
            // Mueve el permiso seleccionado a la izquierda
            UtilidadesForms.moverListboxRow(lstPermisosAsignados, lstPermisos, dtListaMem, dtListaBd, lstPermisosAsignados.SelectedIndex);
            PerfilCustom();
        }

        private void lstPermisosAsignados_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Mueve el permiso seleccionado a la izquierda
            UtilidadesForms.moverListboxRow(lstPermisosAsignados, lstPermisos, dtListaMem, dtListaBd, lstPermisosAsignados.SelectedIndex);
            PerfilCustom();
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Se encarga de cargar el perfil seleccionado en los permisos asignados
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
                    // Si se selecciona un perfil especifico se cargan los permisos
                    configListbox(dtPermisosDef, true, dtPermisosPerfil);
                }
                else
                {
                    // Si se selecciona un perfil personalizado se establecen por defecto (todos los permisos a la izquierda)
                    configListbox(dtPermisosDef);
                }
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
            if (lstPermisos.Items.Count > 0)
            {
                lstPermisos.SelectedIndex = 0;
                for (int i = 0, len = lstPermisos.Items.Count; i < len; i++)
                {
                    UtilidadesForms.moverListboxRow(lstPermisos, lstPermisosAsignados, dtListaBd, dtListaMem, 0);
                }
                PerfilCustom();
            }
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
                PerfilCustom();
            }
        }
        // Funciones
        // Configura el los listbox en base a una lista de permisos
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

        // Pone el Perfil personalizado sin alterar el estado de los listbox ni los datatables de permisos
        public void PerfilCustom()
        {
            if ((int)cmbRol.SelectedValue != -1)
            {
                perfilCustom = true;
                cmbRol.SelectedValue = -1;
                perfilCustom = false;
            }
        }
    }
}
