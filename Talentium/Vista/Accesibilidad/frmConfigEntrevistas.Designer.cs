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
            this.id_entrevista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entrevista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEntrevistas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreEntrevista
            // 
            this.txtNombreEntrevista.Location = new System.Drawing.Point(244, 108);
            this.txtNombreEntrevista.Name = "txtNombreEntrevista";
            this.txtNombreEntrevista.Size = new System.Drawing.Size(100, 20);
            this.txtNombreEntrevista.TabIndex = 0;
            // 
            // lblNombreEntrevista
            // 
            this.lblNombreEntrevista.AutoSize = true;
            this.lblNombreEntrevista.Location = new System.Drawing.Point(110, 111);
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
            this.dtgEntrevistas.Location = new System.Drawing.Point(104, 176);
            this.dtgEntrevistas.Name = "dtgEntrevistas";
            this.dtgEntrevistas.Size = new System.Drawing.Size(240, 150);
            this.dtgEntrevistas.TabIndex = 2;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(382, 105);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // id_entrevista
            // 
            this.id_entrevista.DataPropertyName = "id_entrevista";
            this.id_entrevista.HeaderText = "ID";
            this.id_entrevista.Name = "id_entrevista";
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
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dtgEntrevistas);
            this.Controls.Add(this.lblNombreEntrevista);
            this.Controls.Add(this.txtNombreEntrevista);
            this.Name = "frmConfigEntrevistas";
            this.Text = "Configurar Entrevistas del Proceso de Seleccion";
            ((System.ComponentModel.ISupportInitialize)(this.dtgEntrevistas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreEntrevista;
        private System.Windows.Forms.Label lblNombreEntrevista;
        private System.Windows.Forms.DataGridView dtgEntrevistas;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_entrevista;
        private System.Windows.Forms.DataGridViewTextBoxColumn entrevista;
    }
}