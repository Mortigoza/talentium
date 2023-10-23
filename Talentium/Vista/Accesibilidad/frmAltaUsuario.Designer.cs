namespace Vista
{
    partial class frmAltaUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgPersonas = new System.Windows.Forms.DataGridView();
            this.grpFiltro = new System.Windows.Forms.GroupBox();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblCuil = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.nmrCambiaCada = new System.Windows.Forms.NumericUpDown();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblCambiaCada = new System.Windows.Forms.Label();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.lblDatosDtg = new System.Windows.Forms.Label();
            this.btnCrearContrasenia = new System.Windows.Forms.Button();
            this.btnAsignarPermisos = new System.Windows.Forms.Button();
            this.btnDesasignarPermisos = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lstPermisos = new System.Windows.Forms.ListBox();
            this.lstPermisosAsignados = new System.Windows.Forms.ListBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.chcEmail = new System.Windows.Forms.CheckBox();
            this.btnAsignarPermisosTodos = new System.Windows.Forms.Button();
            this.btnDesasignarPermisosTodos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPersonas)).BeginInit();
            this.grpFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCambiaCada)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgPersonas
            // 
            this.dtgPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPersonas.Location = new System.Drawing.Point(184, 36);
            this.dtgPersonas.Name = "dtgPersonas";
            this.dtgPersonas.ReadOnly = true;
            this.dtgPersonas.Size = new System.Drawing.Size(648, 231);
            this.dtgPersonas.TabIndex = 0;
            this.dtgPersonas.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPersonas_RowEnter);
            // 
            // grpFiltro
            // 
            this.grpFiltro.BackgroundImage = global::Vista.Properties.Resources.fondo_pared_textura_blanca2;
            this.grpFiltro.Controls.Add(this.cmbArea);
            this.grpFiltro.Controls.Add(this.btnFiltrar);
            this.grpFiltro.Controls.Add(this.txtApellido);
            this.grpFiltro.Controls.Add(this.lblArea);
            this.grpFiltro.Controls.Add(this.lblCuil);
            this.grpFiltro.Controls.Add(this.txtNombre);
            this.grpFiltro.Controls.Add(this.lblApellido);
            this.grpFiltro.Controls.Add(this.txtCuit);
            this.grpFiltro.Controls.Add(this.lblNombre);
            this.grpFiltro.Location = new System.Drawing.Point(24, 36);
            this.grpFiltro.Name = "grpFiltro";
            this.grpFiltro.Size = new System.Drawing.Size(137, 231);
            this.grpFiltro.TabIndex = 12;
            this.grpFiltro.TabStop = false;
            this.grpFiltro.Text = "Filtro";
            // 
            // cmbArea
            // 
            this.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(17, 158);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(100, 21);
            this.cmbArea.TabIndex = 9;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(17, 193);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(100, 23);
            this.btnFiltrar.TabIndex = 7;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(17, 119);
            this.txtApellido.MaxLength = 50;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 5;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.BackColor = System.Drawing.Color.Transparent;
            this.lblArea.Location = new System.Drawing.Point(14, 142);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(29, 13);
            this.lblArea.TabIndex = 8;
            this.lblArea.Text = "Area";
            // 
            // lblCuil
            // 
            this.lblCuil.AutoSize = true;
            this.lblCuil.BackColor = System.Drawing.Color.Transparent;
            this.lblCuil.Location = new System.Drawing.Point(14, 25);
            this.lblCuil.Name = "lblCuil";
            this.lblCuil.Size = new System.Drawing.Size(61, 13);
            this.lblCuil.TabIndex = 1;
            this.lblCuil.Text = "CUIT/CUIL";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(17, 80);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblApellido.Location = new System.Drawing.Point(14, 103);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(17, 41);
            this.txtCuit.MaxLength = 15;
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(100, 20);
            this.txtCuit.TabIndex = 4;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Location = new System.Drawing.Point(14, 64);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(47, 338);
            this.txtUsuario.MaxLength = 30;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(167, 20);
            this.txtUsuario.TabIndex = 0;
            // 
            // nmrCambiaCada
            // 
            this.nmrCambiaCada.Increment = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nmrCambiaCada.Location = new System.Drawing.Point(47, 456);
            this.nmrCambiaCada.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nmrCambiaCada.Name = "nmrCambiaCada";
            this.nmrCambiaCada.ReadOnly = true;
            this.nmrCambiaCada.Size = new System.Drawing.Size(167, 20);
            this.nmrCambiaCada.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(757, 520);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(47, 377);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.ReadOnly = true;
            this.txtContrasenia.Size = new System.Drawing.Size(167, 20);
            this.txtContrasenia.TabIndex = 2;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreUsuario.Location = new System.Drawing.Point(44, 322);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(96, 13);
            this.lblNombreUsuario.TabIndex = 3;
            this.lblNombreUsuario.Text = "Nombre de usuario";
            // 
            // lblCambiaCada
            // 
            this.lblCambiaCada.AutoSize = true;
            this.lblCambiaCada.BackColor = System.Drawing.Color.Transparent;
            this.lblCambiaCada.Location = new System.Drawing.Point(44, 440);
            this.lblCambiaCada.Name = "lblCambiaCada";
            this.lblCambiaCada.Size = new System.Drawing.Size(128, 13);
            this.lblCambiaCada.TabIndex = 4;
            this.lblCambiaCada.Text = "Cambiar contraseña cada";
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.BackColor = System.Drawing.Color.Transparent;
            this.lblContrasenia.Location = new System.Drawing.Point(44, 361);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(61, 13);
            this.lblContrasenia.TabIndex = 5;
            this.lblContrasenia.Text = "Contraseña";
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.BackColor = System.Drawing.Color.Transparent;
            this.lblPerfil.Location = new System.Drawing.Point(44, 400);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(81, 13);
            this.lblPerfil.TabIndex = 6;
            this.lblPerfil.Text = "Perfil (Permisos)";
            // 
            // cmbRol
            // 
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(46, 416);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(168, 21);
            this.cmbRol.TabIndex = 7;
            this.cmbRol.SelectedIndexChanged += new System.EventHandler(this.cmbRol_SelectedIndexChanged);
            // 
            // lblDatosDtg
            // 
            this.lblDatosDtg.AutoSize = true;
            this.lblDatosDtg.BackColor = System.Drawing.Color.Transparent;
            this.lblDatosDtg.Location = new System.Drawing.Point(192, 279);
            this.lblDatosDtg.Name = "lblDatosDtg";
            this.lblDatosDtg.Size = new System.Drawing.Size(165, 13);
            this.lblDatosDtg.TabIndex = 17;
            this.lblDatosDtg.Text = "Nombre     Apellido     CUIL/CUIT";
            // 
            // btnCrearContrasenia
            // 
            this.btnCrearContrasenia.Location = new System.Drawing.Point(220, 371);
            this.btnCrearContrasenia.Name = "btnCrearContrasenia";
            this.btnCrearContrasenia.Size = new System.Drawing.Size(30, 30);
            this.btnCrearContrasenia.TabIndex = 18;
            this.btnCrearContrasenia.Text = "R";
            this.btnCrearContrasenia.UseVisualStyleBackColor = true;
            this.btnCrearContrasenia.Click += new System.EventHandler(this.btnCrearContrasenia_Click);
            // 
            // btnAsignarPermisos
            // 
            this.btnAsignarPermisos.Location = new System.Drawing.Point(529, 368);
            this.btnAsignarPermisos.Name = "btnAsignarPermisos";
            this.btnAsignarPermisos.Size = new System.Drawing.Size(40, 40);
            this.btnAsignarPermisos.TabIndex = 19;
            this.btnAsignarPermisos.Text = ">";
            this.btnAsignarPermisos.UseVisualStyleBackColor = true;
            this.btnAsignarPermisos.Click += new System.EventHandler(this.btnAsignarPermisos_Click);
            // 
            // btnDesasignarPermisos
            // 
            this.btnDesasignarPermisos.Location = new System.Drawing.Point(529, 409);
            this.btnDesasignarPermisos.Name = "btnDesasignarPermisos";
            this.btnDesasignarPermisos.Size = new System.Drawing.Size(40, 40);
            this.btnDesasignarPermisos.TabIndex = 20;
            this.btnDesasignarPermisos.Text = "<";
            this.btnDesasignarPermisos.UseVisualStyleBackColor = true;
            this.btnDesasignarPermisos.Click += new System.EventHandler(this.btnDesasignarPermisos_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(676, 520);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lstPermisos
            // 
            this.lstPermisos.FormattingEnabled = true;
            this.lstPermisos.Location = new System.Drawing.Point(307, 322);
            this.lstPermisos.Name = "lstPermisos";
            this.lstPermisos.Size = new System.Drawing.Size(216, 173);
            this.lstPermisos.TabIndex = 23;
            this.lstPermisos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstPermisos_MouseDoubleClick);
            // 
            // lstPermisosAsignados
            // 
            this.lstPermisosAsignados.FormattingEnabled = true;
            this.lstPermisosAsignados.Location = new System.Drawing.Point(575, 322);
            this.lstPermisosAsignados.Name = "lstPermisosAsignados";
            this.lstPermisosAsignados.Size = new System.Drawing.Size(216, 173);
            this.lstPermisosAsignados.TabIndex = 24;
            this.lstPermisosAsignados.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstPermisosAsignados_MouseDoubleClick);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(47, 495);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(168, 20);
            this.txtEmail.TabIndex = 25;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Location = new System.Drawing.Point(43, 479);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 26;
            this.lblEmail.Text = "Email";
            // 
            // chcEmail
            // 
            this.chcEmail.AutoSize = true;
            this.chcEmail.BackColor = System.Drawing.Color.Transparent;
            this.chcEmail.Location = new System.Drawing.Point(113, 520);
            this.chcEmail.Name = "chcEmail";
            this.chcEmail.Size = new System.Drawing.Size(119, 17);
            this.chcEmail.TabIndex = 27;
            this.chcEmail.Text = "Email personalizado";
            this.chcEmail.UseVisualStyleBackColor = false;
            this.chcEmail.CheckedChanged += new System.EventHandler(this.chcEmail_CheckedChanged);
            // 
            // btnAsignarPermisosTodos
            // 
            this.btnAsignarPermisosTodos.Location = new System.Drawing.Point(529, 322);
            this.btnAsignarPermisosTodos.Name = "btnAsignarPermisosTodos";
            this.btnAsignarPermisosTodos.Size = new System.Drawing.Size(40, 40);
            this.btnAsignarPermisosTodos.TabIndex = 28;
            this.btnAsignarPermisosTodos.Text = ">>";
            this.btnAsignarPermisosTodos.UseVisualStyleBackColor = true;
            this.btnAsignarPermisosTodos.Click += new System.EventHandler(this.btnAsignarPermisosTodos_Click);
            // 
            // btnDesasignarPermisosTodos
            // 
            this.btnDesasignarPermisosTodos.Location = new System.Drawing.Point(529, 455);
            this.btnDesasignarPermisosTodos.Name = "btnDesasignarPermisosTodos";
            this.btnDesasignarPermisosTodos.Size = new System.Drawing.Size(40, 40);
            this.btnDesasignarPermisosTodos.TabIndex = 29;
            this.btnDesasignarPermisosTodos.Text = "<<";
            this.btnDesasignarPermisosTodos.UseVisualStyleBackColor = true;
            this.btnDesasignarPermisosTodos.Click += new System.EventHandler(this.btnDesasignarPermisosTodos_Click);
            // 
            // frmAltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.fondo_pared_textura_blanca2;
            this.ClientSize = new System.Drawing.Size(857, 566);
            this.Controls.Add(this.btnDesasignarPermisosTodos);
            this.Controls.Add(this.btnAsignarPermisosTodos);
            this.Controls.Add(this.chcEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lstPermisosAsignados);
            this.Controls.Add(this.lstPermisos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnDesasignarPermisos);
            this.Controls.Add(this.btnAsignarPermisos);
            this.Controls.Add(this.btnCrearContrasenia);
            this.Controls.Add(this.lblDatosDtg);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.lblContrasenia);
            this.Controls.Add(this.grpFiltro);
            this.Controls.Add(this.nmrCambiaCada);
            this.Controls.Add(this.dtgPersonas);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.lblCambiaCada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAltaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de usuario";
            ((System.ComponentModel.ISupportInitialize)(this.dtgPersonas)).EndInit();
            this.grpFiltro.ResumeLayout(false);
            this.grpFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCambiaCada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgPersonas;
        private System.Windows.Forms.GroupBox grpFiltro;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblCuil;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.NumericUpDown nmrCambiaCada;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblCambiaCada;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label lblDatosDtg;
        private System.Windows.Forms.Button btnCrearContrasenia;
        private System.Windows.Forms.Button btnAsignarPermisos;
        private System.Windows.Forms.Button btnDesasignarPermisos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ListBox lstPermisos;
        private System.Windows.Forms.ListBox lstPermisosAsignados;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.CheckBox chcEmail;
        private System.Windows.Forms.Button btnAsignarPermisosTodos;
        private System.Windows.Forms.Button btnDesasignarPermisosTodos;
    }
}