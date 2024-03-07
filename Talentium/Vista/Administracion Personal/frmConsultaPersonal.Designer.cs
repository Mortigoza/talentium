namespace Vista
{
    partial class frmConsultaPersonal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgEmpleados = new System.Windows.Forms.DataGridView();
            this.lblCuit = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnDetalles = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.grpFiltro = new System.Windows.Forms.GroupBox();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.rdbActivos = new System.Windows.Forms.RadioButton();
            this.rdbInactivos = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleados)).BeginInit();
            this.grpFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgEmpleados
            // 
            this.dtgEmpleados.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEmpleados.Location = new System.Drawing.Point(264, 57);
            this.dtgEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.dtgEmpleados.Name = "dtgEmpleados";
            this.dtgEmpleados.ReadOnly = true;
            this.dtgEmpleados.RowHeadersWidth = 51;
            this.dtgEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgEmpleados.Size = new System.Drawing.Size(833, 443);
            this.dtgEmpleados.TabIndex = 0;
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(19, 31);
            this.lblCuit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(71, 16);
            this.lblCuit.TabIndex = 1;
            this.lblCuit.Text = "CUIT/CUIL";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(19, 127);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(57, 16);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(19, 79);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(23, 50);
            this.txtCuit.Margin = new System.Windows.Forms.Padding(4);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(132, 22);
            this.txtCuit.TabIndex = 4;
            this.txtCuit.TextChanged += new System.EventHandler(this.txtCuit_TextChanged);
            this.txtCuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuit_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(23, 146);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(132, 22);
            this.txtApellido.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(23, 98);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 22);
            this.txtNombre.TabIndex = 6;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(142)))), ((int)(((byte)(171)))));
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltrar.Location = new System.Drawing.Point(23, 238);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(133, 28);
            this.btnFiltrar.TabIndex = 7;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDetalles
            // 
            this.btnDetalles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(142)))), ((int)(((byte)(171)))));
            this.btnDetalles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDetalles.Location = new System.Drawing.Point(56, 354);
            this.btnDetalles.Margin = new System.Windows.Forms.Padding(4);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(133, 28);
            this.btnDetalles.TabIndex = 8;
            this.btnDetalles.Text = "Visualizar";
            this.btnDetalles.UseVisualStyleBackColor = false;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(142)))), ((int)(((byte)(171)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Location = new System.Drawing.Point(56, 416);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(133, 28);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(142)))), ((int)(((byte)(171)))));
            this.btnBaja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBaja.Location = new System.Drawing.Point(56, 452);
            this.btnBaja.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(133, 28);
            this.btnBaja.TabIndex = 10;
            this.btnBaja.Text = "Dar de baja";
            this.btnBaja.UseVisualStyleBackColor = false;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // grpFiltro
            // 
            this.grpFiltro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpFiltro.Controls.Add(this.cmbArea);
            this.grpFiltro.Controls.Add(this.btnFiltrar);
            this.grpFiltro.Controls.Add(this.txtApellido);
            this.grpFiltro.Controls.Add(this.lblArea);
            this.grpFiltro.Controls.Add(this.lblCuit);
            this.grpFiltro.Controls.Add(this.txtNombre);
            this.grpFiltro.Controls.Add(this.lblApellido);
            this.grpFiltro.Controls.Add(this.txtCuit);
            this.grpFiltro.Controls.Add(this.lblNombre);
            this.grpFiltro.Location = new System.Drawing.Point(32, 57);
            this.grpFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.grpFiltro.Name = "grpFiltro";
            this.grpFiltro.Padding = new System.Windows.Forms.Padding(4);
            this.grpFiltro.Size = new System.Drawing.Size(183, 273);
            this.grpFiltro.TabIndex = 11;
            this.grpFiltro.TabStop = false;
            this.grpFiltro.Text = "Filtro";
            // 
            // cmbArea
            // 
            this.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(23, 194);
            this.cmbArea.Margin = new System.Windows.Forms.Padding(4);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(132, 24);
            this.cmbArea.TabIndex = 9;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(19, 175);
            this.lblArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(36, 16);
            this.lblArea.TabIndex = 8;
            this.lblArea.Text = "Area";
            // 
            // rdbActivos
            // 
            this.rdbActivos.AutoSize = true;
            this.rdbActivos.BackColor = System.Drawing.Color.Transparent;
            this.rdbActivos.Checked = true;
            this.rdbActivos.Location = new System.Drawing.Point(923, 507);
            this.rdbActivos.Margin = new System.Windows.Forms.Padding(4);
            this.rdbActivos.Name = "rdbActivos";
            this.rdbActivos.Size = new System.Drawing.Size(72, 20);
            this.rdbActivos.TabIndex = 12;
            this.rdbActivos.TabStop = true;
            this.rdbActivos.Text = "Activos";
            this.rdbActivos.UseVisualStyleBackColor = false;
            this.rdbActivos.CheckedChanged += new System.EventHandler(this.Filtro_CheckedChanged);
            // 
            // rdbInactivos
            // 
            this.rdbInactivos.AutoSize = true;
            this.rdbInactivos.BackColor = System.Drawing.Color.Transparent;
            this.rdbInactivos.Location = new System.Drawing.Point(1011, 507);
            this.rdbInactivos.Margin = new System.Windows.Forms.Padding(4);
            this.rdbInactivos.Name = "rdbInactivos";
            this.rdbInactivos.Size = new System.Drawing.Size(81, 20);
            this.rdbInactivos.TabIndex = 13;
            this.rdbInactivos.Text = "Inactivos";
            this.rdbInactivos.UseVisualStyleBackColor = false;
            this.rdbInactivos.CheckedChanged += new System.EventHandler(this.Filtro_CheckedChanged);
            // 
            // frmConsultaPersonal
            // 
            this.AcceptButton = this.btnFiltrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.fondo_pared_textura_blanca2;
            this.ClientSize = new System.Drawing.Size(1147, 559);
            this.Controls.Add(this.rdbInactivos);
            this.Controls.Add(this.rdbActivos);
            this.Controls.Add(this.grpFiltro);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnDetalles);
            this.Controls.Add(this.dtgEmpleados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmConsultaPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda de empleados";
            this.Load += new System.EventHandler(this.frmConsultaPersonal_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleados)).EndInit();
            this.grpFiltro.ResumeLayout(false);
            this.grpFiltro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgEmpleados;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnDetalles;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.GroupBox grpFiltro;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.RadioButton rdbActivos;
        private System.Windows.Forms.RadioButton rdbInactivos;
    }
}

