namespace Vista.Accesibilidad
{
    partial class frmPerfiles
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.dtgPerfiles = new System.Windows.Forms.DataGridView();
            this.txtNombrePermiso = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.lblNombrePerfil = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnDesasignarPermisosTodos = new System.Windows.Forms.Button();
            this.btnAsignarPermisosTodos = new System.Windows.Forms.Button();
            this.lstPermisosAsignados = new System.Windows.Forms.ListBox();
            this.lstPermisos = new System.Windows.Forms.ListBox();
            this.btnDesasignarPermisos = new System.Windows.Forms.Button();
            this.btnAsignarPermisos = new System.Windows.Forms.Button();
            this.chcModificar = new System.Windows.Forms.CheckBox();
            this.lblPermisos = new System.Windows.Forms.Label();
            this.lblPermisosAsignados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPerfiles)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAgregar.Location = new System.Drawing.Point(80, 205);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(114, 36);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(80, 257);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(114, 25);
            this.btnBaja.TabIndex = 2;
            this.btnBaja.Text = "Dar de baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            // 
            // dtgPerfiles
            // 
            this.dtgPerfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPerfiles.Location = new System.Drawing.Point(276, 42);
            this.dtgPerfiles.Name = "dtgPerfiles";
            this.dtgPerfiles.Size = new System.Drawing.Size(378, 278);
            this.dtgPerfiles.TabIndex = 4;
            this.dtgPerfiles.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPerfiles_RowEnter);
            // 
            // txtNombrePermiso
            // 
            this.txtNombrePermiso.Location = new System.Drawing.Point(36, 74);
            this.txtNombrePermiso.MaxLength = 30;
            this.txtNombrePermiso.Name = "txtNombrePermiso";
            this.txtNombrePermiso.Size = new System.Drawing.Size(199, 20);
            this.txtNombrePermiso.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(36, 113);
            this.txtDescripcion.MaxLength = 100;
            this.txtDescripcion.Multiline = false;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(199, 86);
            this.txtDescripcion.TabIndex = 6;
            this.txtDescripcion.Text = "";
            // 
            // lblNombrePerfil
            // 
            this.lblNombrePerfil.AutoSize = true;
            this.lblNombrePerfil.Location = new System.Drawing.Point(33, 58);
            this.lblNombrePerfil.Name = "lblNombrePerfil";
            this.lblNombrePerfil.Size = new System.Drawing.Size(86, 13);
            this.lblNombrePerfil.TabIndex = 7;
            this.lblNombrePerfil.Text = "Nombre del perfil";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(33, 97);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 8;
            this.lblDescripcion.Text = "Descripción";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(588, 550);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(83, 26);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnDesasignarPermisosTodos
            // 
            this.btnDesasignarPermisosTodos.Location = new System.Drawing.Point(272, 519);
            this.btnDesasignarPermisosTodos.Name = "btnDesasignarPermisosTodos";
            this.btnDesasignarPermisosTodos.Size = new System.Drawing.Size(40, 40);
            this.btnDesasignarPermisosTodos.TabIndex = 35;
            this.btnDesasignarPermisosTodos.Text = "<<";
            this.btnDesasignarPermisosTodos.UseVisualStyleBackColor = true;
            this.btnDesasignarPermisosTodos.Click += new System.EventHandler(this.btnDesasignarPermisosTodos_Click);
            // 
            // btnAsignarPermisosTodos
            // 
            this.btnAsignarPermisosTodos.Location = new System.Drawing.Point(272, 386);
            this.btnAsignarPermisosTodos.Name = "btnAsignarPermisosTodos";
            this.btnAsignarPermisosTodos.Size = new System.Drawing.Size(40, 40);
            this.btnAsignarPermisosTodos.TabIndex = 34;
            this.btnAsignarPermisosTodos.Text = ">>";
            this.btnAsignarPermisosTodos.UseVisualStyleBackColor = true;
            this.btnAsignarPermisosTodos.Click += new System.EventHandler(this.btnAsignarPermisosTodos_Click);
            // 
            // lstPermisosAsignados
            // 
            this.lstPermisosAsignados.FormattingEnabled = true;
            this.lstPermisosAsignados.Location = new System.Drawing.Point(318, 386);
            this.lstPermisosAsignados.Name = "lstPermisosAsignados";
            this.lstPermisosAsignados.Size = new System.Drawing.Size(216, 173);
            this.lstPermisosAsignados.TabIndex = 33;
            // 
            // lstPermisos
            // 
            this.lstPermisos.FormattingEnabled = true;
            this.lstPermisos.Location = new System.Drawing.Point(50, 386);
            this.lstPermisos.Name = "lstPermisos";
            this.lstPermisos.Size = new System.Drawing.Size(216, 173);
            this.lstPermisos.TabIndex = 32;
            // 
            // btnDesasignarPermisos
            // 
            this.btnDesasignarPermisos.Location = new System.Drawing.Point(272, 473);
            this.btnDesasignarPermisos.Name = "btnDesasignarPermisos";
            this.btnDesasignarPermisos.Size = new System.Drawing.Size(40, 40);
            this.btnDesasignarPermisos.TabIndex = 31;
            this.btnDesasignarPermisos.Text = "<";
            this.btnDesasignarPermisos.UseVisualStyleBackColor = true;
            this.btnDesasignarPermisos.Click += new System.EventHandler(this.btnDesasignarPermisos_Click);
            // 
            // btnAsignarPermisos
            // 
            this.btnAsignarPermisos.Location = new System.Drawing.Point(272, 432);
            this.btnAsignarPermisos.Name = "btnAsignarPermisos";
            this.btnAsignarPermisos.Size = new System.Drawing.Size(40, 40);
            this.btnAsignarPermisos.TabIndex = 30;
            this.btnAsignarPermisos.Text = ">";
            this.btnAsignarPermisos.UseVisualStyleBackColor = true;
            this.btnAsignarPermisos.Click += new System.EventHandler(this.btnAsignarPermisos_Click);
            // 
            // chcModificar
            // 
            this.chcModificar.AutoSize = true;
            this.chcModificar.Location = new System.Drawing.Point(276, 326);
            this.chcModificar.Name = "chcModificar";
            this.chcModificar.Size = new System.Drawing.Size(69, 17);
            this.chcModificar.TabIndex = 36;
            this.chcModificar.Text = "Modificar";
            this.chcModificar.UseVisualStyleBackColor = true;
            this.chcModificar.CheckedChanged += new System.EventHandler(this.chcModificar_CheckedChanged);
            // 
            // lblPermisos
            // 
            this.lblPermisos.AutoSize = true;
            this.lblPermisos.Location = new System.Drawing.Point(47, 370);
            this.lblPermisos.Name = "lblPermisos";
            this.lblPermisos.Size = new System.Drawing.Size(49, 13);
            this.lblPermisos.TabIndex = 37;
            this.lblPermisos.Text = "Permisos";
            // 
            // lblPermisosAsignados
            // 
            this.lblPermisosAsignados.AutoSize = true;
            this.lblPermisosAsignados.Location = new System.Drawing.Point(315, 370);
            this.lblPermisosAsignados.Name = "lblPermisosAsignados";
            this.lblPermisosAsignados.Size = new System.Drawing.Size(100, 13);
            this.lblPermisosAsignados.TabIndex = 38;
            this.lblPermisosAsignados.Text = "Permisos asignados";
            // 
            // frmPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 588);
            this.Controls.Add(this.lblPermisosAsignados);
            this.Controls.Add(this.lblPermisos);
            this.Controls.Add(this.chcModificar);
            this.Controls.Add(this.btnDesasignarPermisosTodos);
            this.Controls.Add(this.btnAsignarPermisosTodos);
            this.Controls.Add(this.lstPermisosAsignados);
            this.Controls.Add(this.lstPermisos);
            this.Controls.Add(this.btnDesasignarPermisos);
            this.Controls.Add(this.btnAsignarPermisos);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombrePerfil);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombrePermiso);
            this.Controls.Add(this.dtgPerfiles);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPerfiles";
            this.Text = "Perfiles";
            ((System.ComponentModel.ISupportInitialize)(this.dtgPerfiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.DataGridView dtgPerfiles;
        private System.Windows.Forms.TextBox txtNombrePermiso;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.Label lblNombrePerfil;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnDesasignarPermisosTodos;
        private System.Windows.Forms.Button btnAsignarPermisosTodos;
        private System.Windows.Forms.ListBox lstPermisosAsignados;
        private System.Windows.Forms.ListBox lstPermisos;
        private System.Windows.Forms.Button btnDesasignarPermisos;
        private System.Windows.Forms.Button btnAsignarPermisos;
        private System.Windows.Forms.CheckBox chcModificar;
        private System.Windows.Forms.Label lblPermisos;
        private System.Windows.Forms.Label lblPermisosAsignados;
    }
}