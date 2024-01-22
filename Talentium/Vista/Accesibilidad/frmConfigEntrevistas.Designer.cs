namespace Vista.Accesibilidad
{
    partial class frmConfigEntrevistas
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
            this.txtNombreEntrevista = new System.Windows.Forms.TextBox();
            this.lblNombreEntrevista = new System.Windows.Forms.Label();
            this.dtgEntrevistas = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grpAltaEntrevista = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpModEntrevista = new System.Windows.Forms.GroupBox();
            this.btnModCancelar = new System.Windows.Forms.Button();
            this.btnModGuardar = new System.Windows.Forms.Button();
            this.lblModEntrevista = new System.Windows.Forms.Label();
            this.txtModNombre = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.id_entrevista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entrevista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEntrevistas)).BeginInit();
            this.grpAltaEntrevista.SuspendLayout();
            this.grpModEntrevista.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombreEntrevista
            // 
            this.txtNombreEntrevista.Location = new System.Drawing.Point(146, 34);
            this.txtNombreEntrevista.Name = "txtNombreEntrevista";
            this.txtNombreEntrevista.Size = new System.Drawing.Size(235, 20);
            this.txtNombreEntrevista.TabIndex = 0;
            // 
            // lblNombreEntrevista
            // 
            this.lblNombreEntrevista.AutoSize = true;
            this.lblNombreEntrevista.Location = new System.Drawing.Point(12, 37);
            this.lblNombreEntrevista.Name = "lblNombreEntrevista";
            this.lblNombreEntrevista.Size = new System.Drawing.Size(120, 13);
            this.lblNombreEntrevista.TabIndex = 1;
            this.lblNombreEntrevista.Text = "Nombre de la Entrevista";
            // 
            // dtgEntrevistas
            // 
            this.dtgEntrevistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEntrevistas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_entrevista,
            this.entrevista});
            this.dtgEntrevistas.Location = new System.Drawing.Point(33, 50);
            this.dtgEntrevistas.Name = "dtgEntrevistas";
            this.dtgEntrevistas.Size = new System.Drawing.Size(240, 287);
            this.dtgEntrevistas.TabIndex = 2;
            this.dtgEntrevistas.DoubleClick += new System.EventHandler(this.dtgEntrevistas_DoubleClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(307, 71);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // grpAltaEntrevista
            // 
            this.grpAltaEntrevista.Controls.Add(this.btnCancelar);
            this.grpAltaEntrevista.Controls.Add(this.btnGuardar);
            this.grpAltaEntrevista.Controls.Add(this.lblNombreEntrevista);
            this.grpAltaEntrevista.Controls.Add(this.txtNombreEntrevista);
            this.grpAltaEntrevista.Location = new System.Drawing.Point(304, 50);
            this.grpAltaEntrevista.Name = "grpAltaEntrevista";
            this.grpAltaEntrevista.Size = new System.Drawing.Size(398, 100);
            this.grpAltaEntrevista.TabIndex = 4;
            this.grpAltaEntrevista.TabStop = false;
            this.grpAltaEntrevista.Text = "Alta de Entrevista";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(147, 71);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // grpModEntrevista
            // 
            this.grpModEntrevista.Controls.Add(this.btnModCancelar);
            this.grpModEntrevista.Controls.Add(this.btnModGuardar);
            this.grpModEntrevista.Controls.Add(this.lblModEntrevista);
            this.grpModEntrevista.Controls.Add(this.txtModNombre);
            this.grpModEntrevista.Location = new System.Drawing.Point(304, 237);
            this.grpModEntrevista.Name = "grpModEntrevista";
            this.grpModEntrevista.Size = new System.Drawing.Size(398, 100);
            this.grpModEntrevista.TabIndex = 5;
            this.grpModEntrevista.TabStop = false;
            this.grpModEntrevista.Text = "Modificar Entrevista";
            // 
            // btnModCancelar
            // 
            this.btnModCancelar.Location = new System.Drawing.Point(147, 71);
            this.btnModCancelar.Name = "btnModCancelar";
            this.btnModCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnModCancelar.TabIndex = 4;
            this.btnModCancelar.Text = "Cancelar";
            this.btnModCancelar.UseVisualStyleBackColor = true;
            this.btnModCancelar.Click += new System.EventHandler(this.btnModCancelar_Click);
            // 
            // btnModGuardar
            // 
            this.btnModGuardar.Location = new System.Drawing.Point(307, 71);
            this.btnModGuardar.Name = "btnModGuardar";
            this.btnModGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnModGuardar.TabIndex = 3;
            this.btnModGuardar.Text = "Guardar";
            this.btnModGuardar.UseVisualStyleBackColor = true;
            this.btnModGuardar.Click += new System.EventHandler(this.btnModGuardar_Click);
            // 
            // lblModEntrevista
            // 
            this.lblModEntrevista.AutoSize = true;
            this.lblModEntrevista.Location = new System.Drawing.Point(12, 37);
            this.lblModEntrevista.Name = "lblModEntrevista";
            this.lblModEntrevista.Size = new System.Drawing.Size(120, 13);
            this.lblModEntrevista.TabIndex = 1;
            this.lblModEntrevista.Text = "Nombre de la Entrevista";
            // 
            // txtModNombre
            // 
            this.txtModNombre.Location = new System.Drawing.Point(146, 34);
            this.txtModNombre.Name = "txtModNombre";
            this.txtModNombre.Size = new System.Drawing.Size(235, 20);
            this.txtModNombre.TabIndex = 0;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(198, 343);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(33, 343);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // id_entrevista
            // 
            this.id_entrevista.DataPropertyName = "id_entrevista";
            this.id_entrevista.HeaderText = "ID";
            this.id_entrevista.Name = "id_entrevista";
            this.id_entrevista.Width = 80;
            // 
            // entrevista
            // 
            this.entrevista.DataPropertyName = "entrevista";
            this.entrevista.HeaderText = "Entrevista";
            this.entrevista.Name = "entrevista";
            // 
            // frmConfigEntrevistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 395);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.grpModEntrevista);
            this.Controls.Add(this.dtgEntrevistas);
            this.Controls.Add(this.grpAltaEntrevista);
            this.Name = "frmConfigEntrevistas";
            this.Text = "Configurar Entrevistas del Proceso de Seleccion";
            ((System.ComponentModel.ISupportInitialize)(this.dtgEntrevistas)).EndInit();
            this.grpAltaEntrevista.ResumeLayout(false);
            this.grpAltaEntrevista.PerformLayout();
            this.grpModEntrevista.ResumeLayout(false);
            this.grpModEntrevista.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreEntrevista;
        private System.Windows.Forms.Label lblNombreEntrevista;
        private System.Windows.Forms.DataGridView dtgEntrevistas;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox grpAltaEntrevista;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox grpModEntrevista;
        private System.Windows.Forms.Button btnModCancelar;
        private System.Windows.Forms.Button btnModGuardar;
        private System.Windows.Forms.Label lblModEntrevista;
        private System.Windows.Forms.TextBox txtModNombre;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_entrevista;
        private System.Windows.Forms.DataGridViewTextBoxColumn entrevista;
    }
}