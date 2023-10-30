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
            this.button5 = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dtgCapacitacion = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpModificacion = new System.Windows.Forms.GroupBox();
            this.cmbExternaInternaMod = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbNivelMod = new System.Windows.Forms.ComboBox();
            this.cmbAreaMod = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTiempoEstimadoMod = new System.Windows.Forms.TextBox();
            this.btnCancelarMod = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreMod = new System.Windows.Forms.TextBox();
            this.grpAlta = new System.Windows.Forms.GroupBox();
            this.cmbExternaInternaAlta = new System.Windows.Forms.ComboBox();
            this.cmbAreaAlta = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbNivelAlta = new System.Windows.Forms.ComboBox();
            this.btnCancelarAlta = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAltaCapacitacion = new System.Windows.Forms.Label();
            this.txtTiempoEstimadoAlta = new System.Windows.Forms.TextBox();
            this.txtNombreAlta = new System.Windows.Forms.TextBox();
            this.btnDtgMod = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCapacitacion)).BeginInit();
            this.grpModificacion.SuspendLayout();
            this.grpAlta.SuspendLayout();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button5.Location = new System.Drawing.Point(642, 48);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 27);
            this.button5.TabIndex = 13;
            this.button5.Text = "Buscar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(257, 53);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(364, 22);
            this.txtFiltro.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(211, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Filtrar por nombre de capacitacion";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Location = new System.Drawing.Point(780, 660);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 31);
            this.button3.TabIndex = 10;
            this.button3.Text = "Dar de Baja";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dtgCapacitacion
            // 
            this.dtgCapacitacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCapacitacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dtgCapacitacion.Location = new System.Drawing.Point(41, 127);
            this.dtgCapacitacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgCapacitacion.Name = "dtgCapacitacion";
            this.dtgCapacitacion.RowHeadersWidth = 51;
            this.dtgCapacitacion.RowTemplate.Height = 24;
            this.dtgCapacitacion.Size = new System.Drawing.Size(859, 497);
            this.dtgCapacitacion.TabIndex = 9;
            this.dtgCapacitacion.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCapacitacion_CellDoubleClick);
            this.dtgCapacitacion.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCapacitacion_RowEnter);
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
            this.grpModificacion.Controls.Add(this.cmbExternaInternaMod);
            this.grpModificacion.Controls.Add(this.label6);
            this.grpModificacion.Controls.Add(this.cmbNivelMod);
            this.grpModificacion.Controls.Add(this.cmbAreaMod);
            this.grpModificacion.Controls.Add(this.label7);
            this.grpModificacion.Controls.Add(this.label8);
            this.grpModificacion.Controls.Add(this.label11);
            this.grpModificacion.Controls.Add(this.txtTiempoEstimadoMod);
            this.grpModificacion.Controls.Add(this.btnCancelarMod);
            this.grpModificacion.Controls.Add(this.btnModificar);
            this.grpModificacion.Controls.Add(this.label5);
            this.grpModificacion.Controls.Add(this.txtNombreMod);
            this.grpModificacion.Location = new System.Drawing.Point(908, 386);
            this.grpModificacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpModificacion.Name = "grpModificacion";
            this.grpModificacion.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpModificacion.Size = new System.Drawing.Size(567, 305);
            this.grpModificacion.TabIndex = 8;
            this.grpModificacion.TabStop = false;
            this.grpModificacion.Text = "Modificacion";
            // 
            // cmbExternaInternaMod
            // 
            this.cmbExternaInternaMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExternaInternaMod.FormattingEnabled = true;
            this.cmbExternaInternaMod.Location = new System.Drawing.Point(8, 188);
            this.cmbExternaInternaMod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbExternaInternaMod.Name = "cmbExternaInternaMod";
            this.cmbExternaInternaMod.Size = new System.Drawing.Size(167, 24);
            this.cmbExternaInternaMod.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 37);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Nivel de capacitacion";
            // 
            // cmbNivelMod
            // 
            this.cmbNivelMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNivelMod.FormattingEnabled = true;
            this.cmbNivelMod.Location = new System.Drawing.Point(281, 74);
            this.cmbNivelMod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbNivelMod.Name = "cmbNivelMod";
            this.cmbNivelMod.Size = new System.Drawing.Size(253, 24);
            this.cmbNivelMod.TabIndex = 16;
            // 
            // cmbAreaMod
            // 
            this.cmbAreaMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAreaMod.FormattingEnabled = true;
            this.cmbAreaMod.Location = new System.Drawing.Point(363, 191);
            this.cmbAreaMod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbAreaMod.Name = "cmbAreaMod";
            this.cmbAreaMod.Size = new System.Drawing.Size(195, 24);
            this.cmbAreaMod.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(356, 154);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Área";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 154);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Externa/Interna";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(176, 154);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "Tiempo estimado";
            // 
            // txtTiempoEstimadoMod
            // 
            this.txtTiempoEstimadoMod.Location = new System.Drawing.Point(185, 191);
            this.txtTiempoEstimadoMod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTiempoEstimadoMod.Name = "txtTiempoEstimadoMod";
            this.txtTiempoEstimadoMod.Size = new System.Drawing.Size(140, 22);
            this.txtTiempoEstimadoMod.TabIndex = 16;
            // 
            // btnCancelarMod
            // 
            this.btnCancelarMod.Location = new System.Drawing.Point(351, 239);
            this.btnCancelarMod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelarMod.Name = "btnCancelarMod";
            this.btnCancelarMod.Size = new System.Drawing.Size(100, 36);
            this.btnCancelarMod.TabIndex = 11;
            this.btnCancelarMod.Text = "Cancelar";
            this.btnCancelarMod.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnModificar.Location = new System.Drawing.Point(459, 239);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 36);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Guardar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nombre de capacitacion";
            // 
            // txtNombreMod
            // 
            this.txtNombreMod.Location = new System.Drawing.Point(12, 76);
            this.txtNombreMod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreMod.Name = "txtNombreMod";
            this.txtNombreMod.Size = new System.Drawing.Size(228, 22);
            this.txtNombreMod.TabIndex = 1;
            // 
            // grpAlta
            // 
            this.grpAlta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grpAlta.Controls.Add(this.cmbExternaInternaAlta);
            this.grpAlta.Controls.Add(this.cmbAreaAlta);
            this.grpAlta.Controls.Add(this.label10);
            this.grpAlta.Controls.Add(this.cmbNivelAlta);
            this.grpAlta.Controls.Add(this.btnCancelarAlta);
            this.grpAlta.Controls.Add(this.btnAlta);
            this.grpAlta.Controls.Add(this.label4);
            this.grpAlta.Controls.Add(this.label3);
            this.grpAlta.Controls.Add(this.label2);
            this.grpAlta.Controls.Add(this.lblAltaCapacitacion);
            this.grpAlta.Controls.Add(this.txtTiempoEstimadoAlta);
            this.grpAlta.Controls.Add(this.txtNombreAlta);
            this.grpAlta.Location = new System.Drawing.Point(908, 76);
            this.grpAlta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpAlta.Name = "grpAlta";
            this.grpAlta.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpAlta.Size = new System.Drawing.Size(567, 302);
            this.grpAlta.TabIndex = 7;
            this.grpAlta.TabStop = false;
            this.grpAlta.Text = "Alta";
            // 
            // cmbExternaInternaAlta
            // 
            this.cmbExternaInternaAlta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExternaInternaAlta.FormattingEnabled = true;
            this.cmbExternaInternaAlta.Location = new System.Drawing.Point(8, 196);
            this.cmbExternaInternaAlta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbExternaInternaAlta.Name = "cmbExternaInternaAlta";
            this.cmbExternaInternaAlta.Size = new System.Drawing.Size(159, 24);
            this.cmbExternaInternaAlta.TabIndex = 16;
            // 
            // cmbAreaAlta
            // 
            this.cmbAreaAlta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAreaAlta.FormattingEnabled = true;
            this.cmbAreaAlta.Location = new System.Drawing.Point(363, 196);
            this.cmbAreaAlta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbAreaAlta.Name = "cmbAreaAlta";
            this.cmbAreaAlta.Size = new System.Drawing.Size(195, 24);
            this.cmbAreaAlta.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(356, 159);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "Área";
            // 
            // cmbNivelAlta
            // 
            this.cmbNivelAlta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNivelAlta.FormattingEnabled = true;
            this.cmbNivelAlta.Location = new System.Drawing.Point(304, 81);
            this.cmbNivelAlta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbNivelAlta.Name = "cmbNivelAlta";
            this.cmbNivelAlta.Size = new System.Drawing.Size(253, 24);
            this.cmbNivelAlta.TabIndex = 13;
            // 
            // btnCancelarAlta
            // 
            this.btnCancelarAlta.Location = new System.Drawing.Point(351, 252);
            this.btnCancelarAlta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelarAlta.Name = "btnCancelarAlta";
            this.btnCancelarAlta.Size = new System.Drawing.Size(100, 36);
            this.btnCancelarAlta.TabIndex = 10;
            this.btnCancelarAlta.Text = "Cancelar";
            this.btnCancelarAlta.UseVisualStyleBackColor = true;
            // 
            // btnAlta
            // 
            this.btnAlta.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAlta.Location = new System.Drawing.Point(459, 252);
            this.btnAlta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(100, 36);
            this.btnAlta.TabIndex = 9;
            this.btnAlta.Text = "Guardar";
            this.btnAlta.UseVisualStyleBackColor = false;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nivel de capacitacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Externa/Interna";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tiempo estimado";
            // 
            // lblAltaCapacitacion
            // 
            this.lblAltaCapacitacion.AutoSize = true;
            this.lblAltaCapacitacion.Location = new System.Drawing.Point(8, 39);
            this.lblAltaCapacitacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAltaCapacitacion.Name = "lblAltaCapacitacion";
            this.lblAltaCapacitacion.Size = new System.Drawing.Size(155, 16);
            this.lblAltaCapacitacion.TabIndex = 4;
            this.lblAltaCapacitacion.Text = "Nombre de capacitacion";
            // 
            // txtTiempoEstimadoAlta
            // 
            this.txtTiempoEstimadoAlta.Location = new System.Drawing.Point(185, 196);
            this.txtTiempoEstimadoAlta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTiempoEstimadoAlta.Name = "txtTiempoEstimadoAlta";
            this.txtTiempoEstimadoAlta.Size = new System.Drawing.Size(140, 22);
            this.txtTiempoEstimadoAlta.TabIndex = 1;
            // 
            // txtNombreAlta
            // 
            this.txtNombreAlta.Location = new System.Drawing.Point(12, 84);
            this.txtNombreAlta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreAlta.Name = "txtNombreAlta";
            this.txtNombreAlta.Size = new System.Drawing.Size(228, 22);
            this.txtNombreAlta.TabIndex = 0;
            // 
            // btnDtgMod
            // 
            this.btnDtgMod.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDtgMod.Location = new System.Drawing.Point(601, 660);
            this.btnDtgMod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDtgMod.Name = "btnDtgMod";
            this.btnDtgMod.Size = new System.Drawing.Size(118, 31);
            this.btnDtgMod.TabIndex = 14;
            this.btnDtgMod.Text = "Modificar";
            this.btnDtgMod.UseVisualStyleBackColor = false;
            this.btnDtgMod.Click += new System.EventHandler(this.btnDtgMod_Click);
            // 
            // frmABMCapacitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1561, 747);
            this.Controls.Add(this.btnDtgMod);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dtgCapacitacion);
            this.Controls.Add(this.grpModificacion);
            this.Controls.Add(this.grpAlta);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmABMCapacitaciones";
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

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dtgCapacitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox grpModificacion;
        private System.Windows.Forms.ComboBox cmbAreaMod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTiempoEstimadoMod;
        private System.Windows.Forms.Button btnCancelarMod;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreMod;
        private System.Windows.Forms.GroupBox grpAlta;
        private System.Windows.Forms.ComboBox cmbAreaAlta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbNivelAlta;
        private System.Windows.Forms.Button btnCancelarAlta;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAltaCapacitacion;
        private System.Windows.Forms.TextBox txtTiempoEstimadoAlta;
        private System.Windows.Forms.TextBox txtNombreAlta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbNivelMod;
        private System.Windows.Forms.ComboBox cmbExternaInternaMod;
        private System.Windows.Forms.ComboBox cmbExternaInternaAlta;
        private System.Windows.Forms.Button btnDtgMod;
    }
}