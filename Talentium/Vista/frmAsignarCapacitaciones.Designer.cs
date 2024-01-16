namespace Vista
{
    partial class frmAsignarCapacitaciones
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
            this.lblArea = new System.Windows.Forms.Label();
            this.lblCuit = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblPersona = new System.Windows.Forms.Label();
            this.lstCapacitaciones = new System.Windows.Forms.ListBox();
            this.lstCapacitacionesAsignadas = new System.Windows.Forms.ListBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblCapacitaciones = new System.Windows.Forms.Label();
            this.lblCapacitacionesAsignadas = new System.Windows.Forms.Label();
            this.btnDesasignarCapacitacion = new System.Windows.Forms.Button();
            this.btnAsignarCapacitacion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPersonas)).BeginInit();
            this.grpFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgPersonas
            // 
            this.dtgPersonas.AllowUserToAddRows = false;
            this.dtgPersonas.AllowUserToDeleteRows = false;
            this.dtgPersonas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPersonas.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtgPersonas.Location = new System.Drawing.Point(222, 39);
            this.dtgPersonas.Name = "dtgPersonas";
            this.dtgPersonas.ReadOnly = true;
            this.dtgPersonas.Size = new System.Drawing.Size(650, 235);
            this.dtgPersonas.TabIndex = 0;
            // 
            // grpFiltro
            // 
            this.grpFiltro.BackColor = System.Drawing.Color.Transparent;
            this.grpFiltro.Controls.Add(this.cmbArea);
            this.grpFiltro.Controls.Add(this.btnFiltrar);
            this.grpFiltro.Controls.Add(this.lblArea);
            this.grpFiltro.Controls.Add(this.lblCuit);
            this.grpFiltro.Controls.Add(this.txtNombre);
            this.grpFiltro.Controls.Add(this.txtUsuario);
            this.grpFiltro.Controls.Add(this.lblNombre);
            this.grpFiltro.Location = new System.Drawing.Point(37, 39);
            this.grpFiltro.Name = "grpFiltro";
            this.grpFiltro.Size = new System.Drawing.Size(137, 204);
            this.grpFiltro.TabIndex = 13;
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
            this.cmbArea.Location = new System.Drawing.Point(17, 119);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(100, 21);
            this.cmbArea.TabIndex = 9;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(17, 166);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(100, 23);
            this.btnFiltrar.TabIndex = 7;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.BackColor = System.Drawing.Color.Transparent;
            this.lblArea.Location = new System.Drawing.Point(14, 103);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(29, 13);
            this.lblArea.TabIndex = 8;
            this.lblArea.Text = "Area";
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.BackColor = System.Drawing.Color.Transparent;
            this.lblCuit.Location = new System.Drawing.Point(14, 25);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(67, 13);
            this.lblCuit.TabIndex = 1;
            this.lblCuit.Text = "CUIT / CUIL";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(17, 41);
            this.txtUsuario.MaxLength = 30;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 4;
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
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(17, 80);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // lblPersona
            // 
            this.lblPersona.AutoSize = true;
            this.lblPersona.BackColor = System.Drawing.Color.Transparent;
            this.lblPersona.Location = new System.Drawing.Point(219, 286);
            this.lblPersona.Name = "lblPersona";
            this.lblPersona.Size = new System.Drawing.Size(209, 13);
            this.lblPersona.TabIndex = 19;
            this.lblPersona.Text = "Nombre Apellido CUIT/CUIL | Area: RRHH";
            // 
            // lstCapacitaciones
            // 
            this.lstCapacitaciones.FormattingEnabled = true;
            this.lstCapacitaciones.Location = new System.Drawing.Point(163, 369);
            this.lstCapacitaciones.Name = "lstCapacitaciones";
            this.lstCapacitaciones.Size = new System.Drawing.Size(238, 238);
            this.lstCapacitaciones.TabIndex = 20;
            // 
            // lstCapacitacionesAsignadas
            // 
            this.lstCapacitacionesAsignadas.FormattingEnabled = true;
            this.lstCapacitacionesAsignadas.Location = new System.Drawing.Point(502, 369);
            this.lstCapacitacionesAsignadas.Name = "lstCapacitacionesAsignadas";
            this.lstCapacitacionesAsignadas.Size = new System.Drawing.Size(238, 238);
            this.lstCapacitacionesAsignadas.TabIndex = 21;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(828, 596);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // lblCapacitaciones
            // 
            this.lblCapacitaciones.AutoSize = true;
            this.lblCapacitaciones.Location = new System.Drawing.Point(160, 353);
            this.lblCapacitaciones.Name = "lblCapacitaciones";
            this.lblCapacitaciones.Size = new System.Drawing.Size(80, 13);
            this.lblCapacitaciones.TabIndex = 23;
            this.lblCapacitaciones.Text = "Capacitaciones";
            // 
            // lblCapacitacionesAsignadas
            // 
            this.lblCapacitacionesAsignadas.AutoSize = true;
            this.lblCapacitacionesAsignadas.Location = new System.Drawing.Point(499, 353);
            this.lblCapacitacionesAsignadas.Name = "lblCapacitacionesAsignadas";
            this.lblCapacitacionesAsignadas.Size = new System.Drawing.Size(132, 13);
            this.lblCapacitacionesAsignadas.TabIndex = 24;
            this.lblCapacitacionesAsignadas.Text = "Capacitaciones Asignadas";
            // 
            // btnDesasignarCapacitacion
            // 
            this.btnDesasignarCapacitacion.Location = new System.Drawing.Point(430, 494);
            this.btnDesasignarCapacitacion.Name = "btnDesasignarCapacitacion";
            this.btnDesasignarCapacitacion.Size = new System.Drawing.Size(40, 40);
            this.btnDesasignarCapacitacion.TabIndex = 26;
            this.btnDesasignarCapacitacion.Text = "<";
            this.btnDesasignarCapacitacion.UseVisualStyleBackColor = true;
            // 
            // btnAsignarCapacitacion
            // 
            this.btnAsignarCapacitacion.Location = new System.Drawing.Point(430, 435);
            this.btnAsignarCapacitacion.Name = "btnAsignarCapacitacion";
            this.btnAsignarCapacitacion.Size = new System.Drawing.Size(40, 40);
            this.btnAsignarCapacitacion.TabIndex = 25;
            this.btnAsignarCapacitacion.Text = ">";
            this.btnAsignarCapacitacion.UseVisualStyleBackColor = true;
            // 
            // frmAsignarCapacitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 645);
            this.Controls.Add(this.btnDesasignarCapacitacion);
            this.Controls.Add(this.btnAsignarCapacitacion);
            this.Controls.Add(this.lblCapacitacionesAsignadas);
            this.Controls.Add(this.lblCapacitaciones);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lstCapacitacionesAsignadas);
            this.Controls.Add(this.lstCapacitaciones);
            this.Controls.Add(this.lblPersona);
            this.Controls.Add(this.grpFiltro);
            this.Controls.Add(this.dtgPersonas);
            this.Name = "frmAsignarCapacitaciones";
            this.Text = "Asignar Capacitaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dtgPersonas)).EndInit();
            this.grpFiltro.ResumeLayout(false);
            this.grpFiltro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgPersonas;
        private System.Windows.Forms.GroupBox grpFiltro;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPersona;
        private System.Windows.Forms.ListBox lstCapacitaciones;
        private System.Windows.Forms.ListBox lstCapacitacionesAsignadas;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblCapacitaciones;
        private System.Windows.Forms.Label lblCapacitacionesAsignadas;
        private System.Windows.Forms.Button btnDesasignarCapacitacion;
        private System.Windows.Forms.Button btnAsignarCapacitacion;
    }
}