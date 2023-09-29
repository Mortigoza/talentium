﻿namespace Vista.Analisis_y_reportes
{
    partial class frmCertificacionServicios
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
            this.dtgCertificados = new System.Windows.Forms.DataGridView();
            this.rdbEnProceso = new System.Windows.Forms.RadioButton();
            this.rdbFinalizados = new System.Windows.Forms.RadioButton();
            this.grpFiltro = new System.Windows.Forms.GroupBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblCuil = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCertificados)).BeginInit();
            this.grpFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgCertificados
            // 
            this.dtgCertificados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCertificados.Location = new System.Drawing.Point(179, 50);
            this.dtgCertificados.Name = "dtgCertificados";
            this.dtgCertificados.ReadOnly = true;
            this.dtgCertificados.RowHeadersVisible = false;
            this.dtgCertificados.Size = new System.Drawing.Size(714, 357);
            this.dtgCertificados.TabIndex = 0;
            this.dtgCertificados.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCertificados_RowEnter);
            // 
            // rdbEnProceso
            // 
            this.rdbEnProceso.AutoSize = true;
            this.rdbEnProceso.BackColor = System.Drawing.Color.Transparent;
            this.rdbEnProceso.Checked = true;
            this.rdbEnProceso.Location = new System.Drawing.Point(731, 413);
            this.rdbEnProceso.Name = "rdbEnProceso";
            this.rdbEnProceso.Size = new System.Drawing.Size(79, 17);
            this.rdbEnProceso.TabIndex = 1;
            this.rdbEnProceso.TabStop = true;
            this.rdbEnProceso.Text = "En proceso";
            this.rdbEnProceso.UseVisualStyleBackColor = false;
            this.rdbEnProceso.CheckedChanged += new System.EventHandler(this.rdbEnProceso_CheckedChanged);
            // 
            // rdbFinalizados
            // 
            this.rdbFinalizados.AutoSize = true;
            this.rdbFinalizados.BackColor = System.Drawing.Color.Transparent;
            this.rdbFinalizados.Location = new System.Drawing.Point(816, 413);
            this.rdbFinalizados.Name = "rdbFinalizados";
            this.rdbFinalizados.Size = new System.Drawing.Size(77, 17);
            this.rdbFinalizados.TabIndex = 2;
            this.rdbFinalizados.Text = "Finalizados";
            this.rdbFinalizados.UseVisualStyleBackColor = false;
            this.rdbFinalizados.CheckedChanged += new System.EventHandler(this.rdbFinalizados_CheckedChanged);
            // 
            // grpFiltro
            // 
            this.grpFiltro.BackColor = System.Drawing.Color.Transparent;
            this.grpFiltro.Controls.Add(this.btnFiltrar);
            this.grpFiltro.Controls.Add(this.txtApellido);
            this.grpFiltro.Controls.Add(this.lblCuil);
            this.grpFiltro.Controls.Add(this.txtNombre);
            this.grpFiltro.Controls.Add(this.lblApellido);
            this.grpFiltro.Controls.Add(this.txtCuit);
            this.grpFiltro.Controls.Add(this.lblNombre);
            this.grpFiltro.Location = new System.Drawing.Point(21, 50);
            this.grpFiltro.Name = "grpFiltro";
            this.grpFiltro.Size = new System.Drawing.Size(137, 201);
            this.grpFiltro.TabIndex = 13;
            this.grpFiltro.TabStop = false;
            this.grpFiltro.Text = "Filtro";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(17, 161);
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
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(38, 307);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 23);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(38, 336);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 23);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // frmCertificacionServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.fondo_pared_textura_blanca2;
            this.ClientSize = new System.Drawing.Size(924, 475);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.grpFiltro);
            this.Controls.Add(this.rdbFinalizados);
            this.Controls.Add(this.rdbEnProceso);
            this.Controls.Add(this.dtgCertificados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCertificacionServicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Certificacion de servicios";
            ((System.ComponentModel.ISupportInitialize)(this.dtgCertificados)).EndInit();
            this.grpFiltro.ResumeLayout(false);
            this.grpFiltro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgCertificados;
        private System.Windows.Forms.RadioButton rdbEnProceso;
        private System.Windows.Forms.RadioButton rdbFinalizados;
        private System.Windows.Forms.GroupBox grpFiltro;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblCuil;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
    }
}