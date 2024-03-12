namespace Vista.Gestion_de_Talento
{
    partial class frmABMCapacitaciones
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
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.btnBaja = new System.Windows.Forms.Button();
            this.dtgCapacitacion = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpModificacion = new System.Windows.Forms.GroupBox();
            this.chcObligatorioMod = new System.Windows.Forms.CheckBox();
            this.txtTiempoEstimadoMod = new System.Windows.Forms.MaskedTextBox();
            this.cmbExternaInternaMod = new System.Windows.Forms.ComboBox();
            this.lblNivelMod = new System.Windows.Forms.Label();
            this.cmbNivelMod = new System.Windows.Forms.ComboBox();
            this.cmbAreaMod = new System.Windows.Forms.ComboBox();
            this.lblAreaMod = new System.Windows.Forms.Label();
            this.lblTipoMod = new System.Windows.Forms.Label();
            this.lblDuracionMod = new System.Windows.Forms.Label();
            this.btnCancelarMod = new System.Windows.Forms.Button();
            this.btnGuardarMod = new System.Windows.Forms.Button();
            this.lblNombreMod = new System.Windows.Forms.Label();
            this.txtNombreMod = new System.Windows.Forms.TextBox();
            this.grpAlta = new System.Windows.Forms.GroupBox();
            this.chcObligatorioAlta = new System.Windows.Forms.CheckBox();
            this.txtTiempoEstimadoAlta = new System.Windows.Forms.MaskedTextBox();
            this.cmbExternaInternaAlta = new System.Windows.Forms.ComboBox();
            this.cmbAreaAlta = new System.Windows.Forms.ComboBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.cmbNivelAlta = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.lblAltaCapacitacion = new System.Windows.Forms.Label();
            this.txtNombreAlta = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lnkAtras = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCapacitacion)).BeginInit();
            this.grpModificacion.SuspendLayout();
            this.grpAlta.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(113)))), ((int)(((byte)(141)))));
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFiltrar.Location = new System.Drawing.Point(712, 64);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(85, 37);
            this.btnFiltrar.TabIndex = 13;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(337, 71);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(364, 22);
            this.txtFiltro.TabIndex = 12;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(81, 71);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(211, 16);
            this.lblFiltro.TabIndex = 11;
            this.lblFiltro.Text = "Filtrar por nombre de capacitacion";
            this.lblFiltro.Click += new System.EventHandler(this.label9_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(113)))), ((int)(((byte)(141)))));
            this.btnBaja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaja.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBaja.Location = new System.Drawing.Point(767, 654);
            this.btnBaja.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(147, 38);
            this.btnBaja.TabIndex = 10;
            this.btnBaja.Text = "Dar de Baja";
            this.btnBaja.UseVisualStyleBackColor = false;
            this.btnBaja.Click += new System.EventHandler(this.button3_Click);
            // 
            // dtgCapacitacion
            // 
            this.dtgCapacitacion.BackgroundColor = System.Drawing.Color.White;
            this.dtgCapacitacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCapacitacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dtgCapacitacion.Location = new System.Drawing.Point(55, 137);
            this.dtgCapacitacion.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dtgCapacitacion.Name = "dtgCapacitacion";
            this.dtgCapacitacion.RowHeadersWidth = 51;
            this.dtgCapacitacion.RowTemplate.Height = 24;
            this.dtgCapacitacion.Size = new System.Drawing.Size(859, 497);
            this.dtgCapacitacion.TabIndex = 9;
            this.dtgCapacitacion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCapacitacion_CellClick);
            this.dtgCapacitacion.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCapacitacion_CellDoubleClick);
            this.dtgCapacitacion.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCapacitacion_RowEnter);
            this.dtgCapacitacion.SelectionChanged += new System.EventHandler(this.dtgCapacitacion_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre de la capacitacion";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tiempo estimado";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Externa/Interna";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nivel de capacitacion";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // grpModificacion
            // 
            this.grpModificacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grpModificacion.Controls.Add(this.chcObligatorioMod);
            this.grpModificacion.Controls.Add(this.txtTiempoEstimadoMod);
            this.grpModificacion.Controls.Add(this.cmbExternaInternaMod);
            this.grpModificacion.Controls.Add(this.lblNivelMod);
            this.grpModificacion.Controls.Add(this.cmbNivelMod);
            this.grpModificacion.Controls.Add(this.cmbAreaMod);
            this.grpModificacion.Controls.Add(this.lblAreaMod);
            this.grpModificacion.Controls.Add(this.lblTipoMod);
            this.grpModificacion.Controls.Add(this.lblDuracionMod);
            this.grpModificacion.Controls.Add(this.btnCancelarMod);
            this.grpModificacion.Controls.Add(this.btnGuardarMod);
            this.grpModificacion.Controls.Add(this.lblNombreMod);
            this.grpModificacion.Controls.Add(this.txtNombreMod);
            this.grpModificacion.Location = new System.Drawing.Point(984, 410);
            this.grpModificacion.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.grpModificacion.Name = "grpModificacion";
            this.grpModificacion.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.grpModificacion.Size = new System.Drawing.Size(756, 363);
            this.grpModificacion.TabIndex = 8;
            this.grpModificacion.TabStop = false;
            this.grpModificacion.Text = "Modificacion";
            // 
            // chcObligatorioMod
            // 
            this.chcObligatorioMod.AutoSize = true;
            this.chcObligatorioMod.Location = new System.Drawing.Point(423, 249);
            this.chcObligatorioMod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chcObligatorioMod.Name = "chcObligatorioMod";
            this.chcObligatorioMod.Size = new System.Drawing.Size(119, 20);
            this.chcObligatorioMod.TabIndex = 19;
            this.chcObligatorioMod.Text = "Es obligatoria?";
            this.chcObligatorioMod.UseVisualStyleBackColor = true;
            // 
            // txtTiempoEstimadoMod
            // 
            this.txtTiempoEstimadoMod.AllowPromptAsInput = false;
            this.txtTiempoEstimadoMod.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtTiempoEstimadoMod.HidePromptOnLeave = true;
            this.txtTiempoEstimadoMod.Location = new System.Drawing.Point(247, 215);
            this.txtTiempoEstimadoMod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTiempoEstimadoMod.Mask = "99999 hs";
            this.txtTiempoEstimadoMod.Name = "txtTiempoEstimadoMod";
            this.txtTiempoEstimadoMod.Size = new System.Drawing.Size(140, 22);
            this.txtTiempoEstimadoMod.TabIndex = 18;
            this.txtTiempoEstimadoMod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTiempoEstimadoMod.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // cmbExternaInternaMod
            // 
            this.cmbExternaInternaMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExternaInternaMod.FormattingEnabled = true;
            this.cmbExternaInternaMod.Location = new System.Drawing.Point(40, 213);
            this.cmbExternaInternaMod.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cmbExternaInternaMod.Name = "cmbExternaInternaMod";
            this.cmbExternaInternaMod.Size = new System.Drawing.Size(159, 24);
            this.cmbExternaInternaMod.TabIndex = 17;
            // 
            // lblNivelMod
            // 
            this.lblNivelMod.AutoSize = true;
            this.lblNivelMod.Location = new System.Drawing.Point(419, 73);
            this.lblNivelMod.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNivelMod.Name = "lblNivelMod";
            this.lblNivelMod.Size = new System.Drawing.Size(38, 16);
            this.lblNivelMod.TabIndex = 16;
            this.lblNivelMod.Text = "Nivel";
            // 
            // cmbNivelMod
            // 
            this.cmbNivelMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNivelMod.FormattingEnabled = true;
            this.cmbNivelMod.Location = new System.Drawing.Point(423, 94);
            this.cmbNivelMod.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cmbNivelMod.Name = "cmbNivelMod";
            this.cmbNivelMod.Size = new System.Drawing.Size(195, 24);
            this.cmbNivelMod.TabIndex = 16;
            // 
            // cmbAreaMod
            // 
            this.cmbAreaMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAreaMod.FormattingEnabled = true;
            this.cmbAreaMod.Location = new System.Drawing.Point(423, 214);
            this.cmbAreaMod.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cmbAreaMod.Name = "cmbAreaMod";
            this.cmbAreaMod.Size = new System.Drawing.Size(195, 24);
            this.cmbAreaMod.TabIndex = 21;
            // 
            // lblAreaMod
            // 
            this.lblAreaMod.AutoSize = true;
            this.lblAreaMod.Location = new System.Drawing.Point(419, 193);
            this.lblAreaMod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAreaMod.Name = "lblAreaMod";
            this.lblAreaMod.Size = new System.Drawing.Size(36, 16);
            this.lblAreaMod.TabIndex = 20;
            this.lblAreaMod.Text = "Área";
            // 
            // lblTipoMod
            // 
            this.lblTipoMod.AutoSize = true;
            this.lblTipoMod.Location = new System.Drawing.Point(36, 193);
            this.lblTipoMod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoMod.Name = "lblTipoMod";
            this.lblTipoMod.Size = new System.Drawing.Size(35, 16);
            this.lblTipoMod.TabIndex = 19;
            this.lblTipoMod.Text = "Tipo";
            // 
            // lblDuracionMod
            // 
            this.lblDuracionMod.AutoSize = true;
            this.lblDuracionMod.Location = new System.Drawing.Point(243, 193);
            this.lblDuracionMod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDuracionMod.Name = "lblDuracionMod";
            this.lblDuracionMod.Size = new System.Drawing.Size(61, 16);
            this.lblDuracionMod.TabIndex = 18;
            this.lblDuracionMod.Text = "Duración";
            // 
            // btnCancelarMod
            // 
            this.btnCancelarMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(113)))), ((int)(((byte)(141)))));
            this.btnCancelarMod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarMod.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelarMod.Location = new System.Drawing.Point(468, 294);
            this.btnCancelarMod.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCancelarMod.Name = "btnCancelarMod";
            this.btnCancelarMod.Size = new System.Drawing.Size(100, 36);
            this.btnCancelarMod.TabIndex = 11;
            this.btnCancelarMod.Text = "Cancelar";
            this.btnCancelarMod.UseVisualStyleBackColor = false;
            this.btnCancelarMod.Click += new System.EventHandler(this.btnCancelarMod_Click);
            // 
            // btnGuardarMod
            // 
            this.btnGuardarMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(113)))), ((int)(((byte)(141)))));
            this.btnGuardarMod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarMod.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarMod.Location = new System.Drawing.Point(612, 294);
            this.btnGuardarMod.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnGuardarMod.Name = "btnGuardarMod";
            this.btnGuardarMod.Size = new System.Drawing.Size(100, 36);
            this.btnGuardarMod.TabIndex = 10;
            this.btnGuardarMod.Text = "Guardar";
            this.btnGuardarMod.UseVisualStyleBackColor = false;
            this.btnGuardarMod.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblNombreMod
            // 
            this.lblNombreMod.AutoSize = true;
            this.lblNombreMod.Location = new System.Drawing.Point(36, 73);
            this.lblNombreMod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreMod.Name = "lblNombreMod";
            this.lblNombreMod.Size = new System.Drawing.Size(56, 16);
            this.lblNombreMod.TabIndex = 5;
            this.lblNombreMod.Text = "Nombre";
            // 
            // txtNombreMod
            // 
            this.txtNombreMod.Location = new System.Drawing.Point(40, 94);
            this.txtNombreMod.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtNombreMod.Name = "txtNombreMod";
            this.txtNombreMod.Size = new System.Drawing.Size(347, 22);
            this.txtNombreMod.TabIndex = 1;
            // 
            // grpAlta
            // 
            this.grpAlta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grpAlta.Controls.Add(this.chcObligatorioAlta);
            this.grpAlta.Controls.Add(this.txtTiempoEstimadoAlta);
            this.grpAlta.Controls.Add(this.cmbExternaInternaAlta);
            this.grpAlta.Controls.Add(this.cmbAreaAlta);
            this.grpAlta.Controls.Add(this.lblArea);
            this.grpAlta.Controls.Add(this.cmbNivelAlta);
            this.grpAlta.Controls.Add(this.btnCancelar);
            this.grpAlta.Controls.Add(this.btnGuardar);
            this.grpAlta.Controls.Add(this.lblNivel);
            this.grpAlta.Controls.Add(this.lblTipo);
            this.grpAlta.Controls.Add(this.lblDuracion);
            this.grpAlta.Controls.Add(this.lblAltaCapacitacion);
            this.grpAlta.Controls.Add(this.txtNombreAlta);
            this.grpAlta.Location = new System.Drawing.Point(984, 71);
            this.grpAlta.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.grpAlta.Name = "grpAlta";
            this.grpAlta.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.grpAlta.Size = new System.Drawing.Size(756, 316);
            this.grpAlta.TabIndex = 7;
            this.grpAlta.TabStop = false;
            this.grpAlta.Text = "Alta";
            // 
            // chcObligatorioAlta
            // 
            this.chcObligatorioAlta.AutoSize = true;
            this.chcObligatorioAlta.Location = new System.Drawing.Point(423, 196);
            this.chcObligatorioAlta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chcObligatorioAlta.Name = "chcObligatorioAlta";
            this.chcObligatorioAlta.Size = new System.Drawing.Size(119, 20);
            this.chcObligatorioAlta.TabIndex = 18;
            this.chcObligatorioAlta.Text = "Es obligatoria?";
            this.chcObligatorioAlta.UseVisualStyleBackColor = true;
            // 
            // txtTiempoEstimadoAlta
            // 
            this.txtTiempoEstimadoAlta.AllowPromptAsInput = false;
            this.txtTiempoEstimadoAlta.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtTiempoEstimadoAlta.HidePromptOnLeave = true;
            this.txtTiempoEstimadoAlta.Location = new System.Drawing.Point(247, 162);
            this.txtTiempoEstimadoAlta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTiempoEstimadoAlta.Mask = "99999 hs";
            this.txtTiempoEstimadoAlta.Name = "txtTiempoEstimadoAlta";
            this.txtTiempoEstimadoAlta.Size = new System.Drawing.Size(140, 22);
            this.txtTiempoEstimadoAlta.TabIndex = 17;
            this.txtTiempoEstimadoAlta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTiempoEstimadoAlta.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // cmbExternaInternaAlta
            // 
            this.cmbExternaInternaAlta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExternaInternaAlta.FormattingEnabled = true;
            this.cmbExternaInternaAlta.Location = new System.Drawing.Point(40, 160);
            this.cmbExternaInternaAlta.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cmbExternaInternaAlta.Name = "cmbExternaInternaAlta";
            this.cmbExternaInternaAlta.Size = new System.Drawing.Size(159, 24);
            this.cmbExternaInternaAlta.TabIndex = 16;
            // 
            // cmbAreaAlta
            // 
            this.cmbAreaAlta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAreaAlta.FormattingEnabled = true;
            this.cmbAreaAlta.Location = new System.Drawing.Point(423, 161);
            this.cmbAreaAlta.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cmbAreaAlta.Name = "cmbAreaAlta";
            this.cmbAreaAlta.Size = new System.Drawing.Size(195, 24);
            this.cmbAreaAlta.TabIndex = 15;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(419, 140);
            this.lblArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(36, 16);
            this.lblArea.TabIndex = 14;
            this.lblArea.Text = "Área";
            // 
            // cmbNivelAlta
            // 
            this.cmbNivelAlta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNivelAlta.FormattingEnabled = true;
            this.cmbNivelAlta.Location = new System.Drawing.Point(423, 71);
            this.cmbNivelAlta.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cmbNivelAlta.Name = "cmbNivelAlta";
            this.cmbNivelAlta.Size = new System.Drawing.Size(195, 24);
            this.cmbNivelAlta.TabIndex = 13;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(113)))), ((int)(((byte)(141)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(468, 251);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 36);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelarAlta_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(113)))), ((int)(((byte)(141)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Location = new System.Drawing.Point(612, 251);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 36);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Location = new System.Drawing.Point(419, 50);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(38, 16);
            this.lblNivel.TabIndex = 7;
            this.lblNivel.Text = "Nivel";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(36, 139);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(35, 16);
            this.lblTipo.TabIndex = 6;
            this.lblTipo.Text = "Tipo";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(243, 140);
            this.lblDuracion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(61, 16);
            this.lblDuracion.TabIndex = 5;
            this.lblDuracion.Text = "Duración";
            // 
            // lblAltaCapacitacion
            // 
            this.lblAltaCapacitacion.AutoSize = true;
            this.lblAltaCapacitacion.Location = new System.Drawing.Point(36, 52);
            this.lblAltaCapacitacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAltaCapacitacion.Name = "lblAltaCapacitacion";
            this.lblAltaCapacitacion.Size = new System.Drawing.Size(56, 16);
            this.lblAltaCapacitacion.TabIndex = 4;
            this.lblAltaCapacitacion.Text = "Nombre";
            // 
            // txtNombreAlta
            // 
            this.txtNombreAlta.Location = new System.Drawing.Point(40, 73);
            this.txtNombreAlta.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtNombreAlta.Name = "txtNombreAlta";
            this.txtNombreAlta.Size = new System.Drawing.Size(347, 22);
            this.txtNombreAlta.TabIndex = 0;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(113)))), ((int)(((byte)(141)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificar.Location = new System.Drawing.Point(611, 654);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(147, 38);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnDtgMod_Click);
            // 
            // lnkAtras
            // 
            this.lnkAtras.AutoSize = true;
            this.lnkAtras.Location = new System.Drawing.Point(16, 11);
            this.lnkAtras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkAtras.Name = "lnkAtras";
            this.lnkAtras.Size = new System.Drawing.Size(38, 16);
            this.lnkAtras.TabIndex = 32;
            this.lnkAtras.TabStop = true;
            this.lnkAtras.Text = "Atrás";
            this.lnkAtras.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAtras_LinkClicked);
            // 
            // frmABMCapacitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1779, 812);
            this.Controls.Add(this.lnkAtras);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.dtgCapacitacion);
            this.Controls.Add(this.grpModificacion);
            this.Controls.Add(this.grpAlta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.Name = "frmABMCapacitaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmABMCapacitaciones";
            this.Load += new System.EventHandler(this.frmABMCapacitaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCapacitacion)).EndInit();
            this.grpModificacion.ResumeLayout(false);
            this.grpModificacion.PerformLayout();
            this.grpAlta.ResumeLayout(false);
            this.grpAlta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.DataGridView dtgCapacitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox grpModificacion;
        private System.Windows.Forms.ComboBox cmbAreaMod;
        private System.Windows.Forms.Label lblAreaMod;
        private System.Windows.Forms.Label lblTipoMod;
        private System.Windows.Forms.Label lblDuracionMod;
        private System.Windows.Forms.Button btnCancelarMod;
        private System.Windows.Forms.Button btnGuardarMod;
        private System.Windows.Forms.Label lblNombreMod;
        private System.Windows.Forms.TextBox txtNombreMod;
        private System.Windows.Forms.GroupBox grpAlta;
        private System.Windows.Forms.ComboBox cmbAreaAlta;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.ComboBox cmbNivelAlta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label lblAltaCapacitacion;
        private System.Windows.Forms.TextBox txtNombreAlta;
        private System.Windows.Forms.Label lblNivelMod;
        private System.Windows.Forms.ComboBox cmbNivelMod;
        private System.Windows.Forms.ComboBox cmbExternaInternaMod;
        private System.Windows.Forms.ComboBox cmbExternaInternaAlta;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.MaskedTextBox txtTiempoEstimadoAlta;
        private System.Windows.Forms.MaskedTextBox txtTiempoEstimadoMod;
        private System.Windows.Forms.CheckBox chcObligatorioAlta;
        private System.Windows.Forms.CheckBox chcObligatorioMod;
        private System.Windows.Forms.LinkLabel lnkAtras;
    }
}