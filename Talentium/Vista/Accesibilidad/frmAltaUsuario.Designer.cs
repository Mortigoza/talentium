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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.lblDatosDtg = new System.Windows.Forms.Label();
            this.btnCrearContrasenia = new System.Windows.Forms.Button();
            this.btnAsignarPermisos = new System.Windows.Forms.Button();
            this.btnDesasignarPermisos = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPersonas)).BeginInit();
            this.grpFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCambiaCada)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgPersonas
            // 
            this.dtgPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPersonas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Area});
            this.dtgPersonas.Location = new System.Drawing.Point(184, 36);
            this.dtgPersonas.Name = "dtgPersonas";
            this.dtgPersonas.ReadOnly = true;
            this.dtgPersonas.Size = new System.Drawing.Size(648, 231);
            this.dtgPersonas.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Apellido";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "CUIT/CUIL";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Area
            // 
            this.Area.HeaderText = "Area";
            this.Area.Name = "Area";
            this.Area.ReadOnly = true;
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
            this.cmbArea.Items.AddRange(new object[] {
            "RRHH",
            ""});
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
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(17, 119);
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
            this.txtUsuario.Location = new System.Drawing.Point(59, 352);
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
            this.nmrCambiaCada.Location = new System.Drawing.Point(59, 470);
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
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(59, 391);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.ReadOnly = true;
            this.txtContrasenia.Size = new System.Drawing.Size(167, 20);
            this.txtContrasenia.TabIndex = 2;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreUsuario.Location = new System.Drawing.Point(56, 336);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(96, 13);
            this.lblNombreUsuario.TabIndex = 3;
            this.lblNombreUsuario.Text = "Nombre de usuario";
            // 
            // lblCambiaCada
            // 
            this.lblCambiaCada.AutoSize = true;
            this.lblCambiaCada.BackColor = System.Drawing.Color.Transparent;
            this.lblCambiaCada.Location = new System.Drawing.Point(56, 454);
            this.lblCambiaCada.Name = "lblCambiaCada";
            this.lblCambiaCada.Size = new System.Drawing.Size(128, 13);
            this.lblCambiaCada.TabIndex = 4;
            this.lblCambiaCada.Text = "Cambiar contraseña cada";
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.BackColor = System.Drawing.Color.Transparent;
            this.lblContrasenia.Location = new System.Drawing.Point(56, 375);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(61, 13);
            this.lblContrasenia.TabIndex = 5;
            this.lblContrasenia.Text = "Contraseña";
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.BackColor = System.Drawing.Color.Transparent;
            this.lblPerfil.Location = new System.Drawing.Point(56, 414);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(81, 13);
            this.lblPerfil.TabIndex = 6;
            this.lblPerfil.Text = "Perfil (Permisos)";
            // 
            // cmbRol
            // 
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(58, 430);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(168, 21);
            this.cmbRol.TabIndex = 7;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Alta_usuario",
            "Mdf_usuario",
            "Baja_usuario"});
            this.checkedListBox1.Location = new System.Drawing.Point(297, 336);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(216, 154);
            this.checkedListBox1.TabIndex = 15;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "Alta_personas"});
            this.checkedListBox2.Location = new System.Drawing.Point(565, 336);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(216, 154);
            this.checkedListBox2.TabIndex = 16;
            // 
            // lblDatosDtg
            // 
            this.lblDatosDtg.AutoSize = true;
            this.lblDatosDtg.BackColor = System.Drawing.Color.Transparent;
            this.lblDatosDtg.Location = new System.Drawing.Point(192, 279);
            this.lblDatosDtg.Name = "lblDatosDtg";
            this.lblDatosDtg.Size = new System.Drawing.Size(159, 13);
            this.lblDatosDtg.TabIndex = 17;
            this.lblDatosDtg.Text = "Juan     Perez     20-44789418-2";
            // 
            // btnCrearContrasenia
            // 
            this.btnCrearContrasenia.Location = new System.Drawing.Point(232, 385);
            this.btnCrearContrasenia.Name = "btnCrearContrasenia";
            this.btnCrearContrasenia.Size = new System.Drawing.Size(30, 30);
            this.btnCrearContrasenia.TabIndex = 18;
            this.btnCrearContrasenia.Text = "R";
            this.btnCrearContrasenia.UseVisualStyleBackColor = true;
            // 
            // btnAsignarPermisos
            // 
            this.btnAsignarPermisos.Location = new System.Drawing.Point(519, 348);
            this.btnAsignarPermisos.Name = "btnAsignarPermisos";
            this.btnAsignarPermisos.Size = new System.Drawing.Size(40, 40);
            this.btnAsignarPermisos.TabIndex = 19;
            this.btnAsignarPermisos.Text = ">";
            this.btnAsignarPermisos.UseVisualStyleBackColor = true;
            // 
            // btnDesasignarPermisos
            // 
            this.btnDesasignarPermisos.Location = new System.Drawing.Point(519, 440);
            this.btnDesasignarPermisos.Name = "btnDesasignarPermisos";
            this.btnDesasignarPermisos.Size = new System.Drawing.Size(40, 40);
            this.btnDesasignarPermisos.TabIndex = 20;
            this.btnDesasignarPermisos.Text = "<";
            this.btnDesasignarPermisos.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(232, 424);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(30, 30);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(655, 520);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmAltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.fondo_pared_textura_blanca2;
            this.ClientSize = new System.Drawing.Size(857, 555);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDesasignarPermisos);
            this.Controls.Add(this.btnAsignarPermisos);
            this.Controls.Add(this.btnCrearContrasenia);
            this.Controls.Add(this.lblDatosDtg);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.checkedListBox1);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
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
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Label lblDatosDtg;
        private System.Windows.Forms.Button btnCrearContrasenia;
        private System.Windows.Forms.Button btnAsignarPermisos;
        private System.Windows.Forms.Button btnDesasignarPermisos;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancelar;
    }
}