namespace Vista
{
    partial class frmConsultaProcesoDeSeleccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaProcesoDeSeleccion));
            this.btnIngresarEmpleado = new System.Windows.Forms.Button();
            this.btnEtapas = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbEtapa = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtCuilCuit = new System.Windows.Forms.TextBox();
            this.cmbPuesto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgCandidatos = new System.Windows.Forms.DataGridView();
            this.btnModificarCandidato = new System.Windows.Forms.Button();
            this.Etapa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCandidatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresarEmpleado
            // 
            this.btnIngresarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(87)))), ((int)(((byte)(125)))));
            this.btnIngresarEmpleado.Enabled = false;
            this.btnIngresarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresarEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnIngresarEmpleado.Location = new System.Drawing.Point(146, 314);
            this.btnIngresarEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.btnIngresarEmpleado.Name = "btnIngresarEmpleado";
            this.btnIngresarEmpleado.Size = new System.Drawing.Size(112, 33);
            this.btnIngresarEmpleado.TabIndex = 13;
            this.btnIngresarEmpleado.Text = "Ingresar Empleado";
            this.btnIngresarEmpleado.UseVisualStyleBackColor = false;
            this.btnIngresarEmpleado.Click += new System.EventHandler(this.btnIngresarEmpleado_Click);
            // 
            // btnEtapas
            // 
            this.btnEtapas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(87)))), ((int)(((byte)(125)))));
            this.btnEtapas.Enabled = false;
            this.btnEtapas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEtapas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEtapas.Location = new System.Drawing.Point(756, 314);
            this.btnEtapas.Margin = new System.Windows.Forms.Padding(2);
            this.btnEtapas.Name = "btnEtapas";
            this.btnEtapas.Size = new System.Drawing.Size(78, 33);
            this.btnEtapas.TabIndex = 12;
            this.btnEtapas.Text = "Ir a Etapas";
            this.btnEtapas.UseVisualStyleBackColor = false;
            this.btnEtapas.Click += new System.EventHandler(this.btnEtapas_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbEtapa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnFiltrar);
            this.groupBox1.Controls.Add(this.txtCuilCuit);
            this.groupBox1.Controls.Add(this.cmbPuesto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(216, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(416, 106);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // cmbEtapa
            // 
            this.cmbEtapa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEtapa.FormattingEnabled = true;
            this.cmbEtapa.Location = new System.Drawing.Point(131, 67);
            this.cmbEtapa.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEtapa.Name = "cmbEtapa";
            this.cmbEtapa.Size = new System.Drawing.Size(168, 21);
            this.cmbEtapa.TabIndex = 8;
            this.cmbEtapa.DropDown += new System.EventHandler(this.cmbEtapa_DropDown);
            this.cmbEtapa.TextChanged += new System.EventHandler(this.cmbEtapa_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Etapa";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(87)))), ((int)(((byte)(125)))));
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFiltrar.Location = new System.Drawing.Point(344, 65);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(56, 26);
            this.btnFiltrar.TabIndex = 6;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCuilCuit
            // 
            this.txtCuilCuit.Location = new System.Drawing.Point(131, 15);
            this.txtCuilCuit.Margin = new System.Windows.Forms.Padding(2);
            this.txtCuilCuit.Name = "txtCuilCuit";
            this.txtCuilCuit.Size = new System.Drawing.Size(168, 20);
            this.txtCuilCuit.TabIndex = 5;
            this.txtCuilCuit.TextChanged += new System.EventHandler(this.txtCuilCuit_TextChanged);
            this.txtCuilCuit.Leave += new System.EventHandler(this.txtCuilCuit_Leave);
            // 
            // cmbPuesto
            // 
            this.cmbPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPuesto.FormattingEnabled = true;
            this.cmbPuesto.Location = new System.Drawing.Point(131, 41);
            this.cmbPuesto.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPuesto.Name = "cmbPuesto";
            this.cmbPuesto.Size = new System.Drawing.Size(168, 21);
            this.cmbPuesto.TabIndex = 3;
            this.cmbPuesto.DropDown += new System.EventHandler(this.cmbPuesto_DropDown);
            this.cmbPuesto.TextChanged += new System.EventHandler(this.cmbPuesto_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Puesto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CUIL/CUIT";
            // 
            // dtgCandidatos
            // 
            this.dtgCandidatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCandidatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Etapa,
            this.Estado,
            this.Puesto,
            this.Cuil,
            this.Nombre,
            this.Apellido,
            this.ID});
            this.dtgCandidatos.Location = new System.Drawing.Point(30, 173);
            this.dtgCandidatos.Margin = new System.Windows.Forms.Padding(2);
            this.dtgCandidatos.Name = "dtgCandidatos";
            this.dtgCandidatos.RowHeadersWidth = 51;
            this.dtgCandidatos.RowTemplate.Height = 24;
            this.dtgCandidatos.Size = new System.Drawing.Size(804, 122);
            this.dtgCandidatos.TabIndex = 8;
            this.dtgCandidatos.SelectionChanged += new System.EventHandler(this.dtgCandidatos_SelectionChanged);
            // 
            // btnModificarCandidato
            // 
            this.btnModificarCandidato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(87)))), ((int)(((byte)(125)))));
            this.btnModificarCandidato.Enabled = false;
            this.btnModificarCandidato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCandidato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnModificarCandidato.Location = new System.Drawing.Point(30, 314);
            this.btnModificarCandidato.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarCandidato.Name = "btnModificarCandidato";
            this.btnModificarCandidato.Size = new System.Drawing.Size(112, 33);
            this.btnModificarCandidato.TabIndex = 14;
            this.btnModificarCandidato.Text = "Modificar Candidato";
            this.btnModificarCandidato.UseVisualStyleBackColor = false;
            this.btnModificarCandidato.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // Etapa
            // 
            this.Etapa.HeaderText = "Etapa";
            this.Etapa.MinimumWidth = 6;
            this.Etapa.Name = "Etapa";
            this.Etapa.Width = 95;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.Width = 95;
            // 
            // Puesto
            // 
            this.Puesto.HeaderText = "Puesto a postularse";
            this.Puesto.MinimumWidth = 6;
            this.Puesto.Name = "Puesto";
            this.Puesto.Width = 125;
            // 
            // Cuil
            // 
            this.Cuil.HeaderText = "CUIT/CUIL";
            this.Cuil.MinimumWidth = 6;
            this.Cuil.Name = "Cuil";
            this.Cuil.Width = 105;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 6;
            this.Apellido.Name = "Apellido";
            this.Apellido.Width = 125;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // frmConsultaProcesoDeSeleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 379);
            this.Controls.Add(this.btnModificarCandidato);
            this.Controls.Add(this.btnIngresarEmpleado);
            this.Controls.Add(this.btnEtapas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgCandidatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmConsultaProcesoDeSeleccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Candidatos";
            this.Load += new System.EventHandler(this.frmConsultaProcesoDeSeleccion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCandidatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIngresarEmpleado;
        private System.Windows.Forms.Button btnEtapas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbEtapa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtCuilCuit;
        private System.Windows.Forms.ComboBox cmbPuesto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgCandidatos;
        private System.Windows.Forms.Button btnModificarCandidato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etapa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}