namespace Vista
{
    partial class frmCategorias
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
            this.dtgCategoria = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBaja = new System.Windows.Forms.Button();
            this.grpCrearCategoria = new System.Windows.Forms.GroupBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblJornada = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.btnCancelarCrear = new System.Windows.Forms.Button();
            this.btnGuardarCrear = new System.Windows.Forms.Button();
            this.grpModificarCategoria = new System.Windows.Forms.GroupBox();
            this.btnGuardarModif = new System.Windows.Forms.Button();
            this.btnCancelarModif = new System.Windows.Forms.Button();
            this.txtSueldoModif = new System.Windows.Forms.TextBox();
            this.lblSueldoModif = new System.Windows.Forms.Label();
            this.txtJornadaModif = new System.Windows.Forms.TextBox();
            this.lblJornadaModif = new System.Windows.Forms.Label();
            this.txtCategoriaModif = new System.Windows.Forms.TextBox();
            this.lblCategoriaModif = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategoria)).BeginInit();
            this.grpCrearCategoria.SuspendLayout();
            this.grpModificarCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgCategoria
            // 
            this.dtgCategoria.BackgroundColor = System.Drawing.Color.White;
            this.dtgCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dtgCategoria.Location = new System.Drawing.Point(37, 37);
            this.dtgCategoria.Name = "dtgCategoria";
            this.dtgCategoria.Size = new System.Drawing.Size(357, 352);
            this.dtgCategoria.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Categoria";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Jornada";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Sueldo";
            this.Column3.Name = "Column3";
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(320, 396);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(75, 23);
            this.btnBaja.TabIndex = 1;
            this.btnBaja.Text = "Dar de Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            // 
            // grpCrearCategoria
            // 
            this.grpCrearCategoria.Controls.Add(this.btnGuardarCrear);
            this.grpCrearCategoria.Controls.Add(this.btnCancelarCrear);
            this.grpCrearCategoria.Controls.Add(this.textBox3);
            this.grpCrearCategoria.Controls.Add(this.lblSueldo);
            this.grpCrearCategoria.Controls.Add(this.textBox2);
            this.grpCrearCategoria.Controls.Add(this.lblJornada);
            this.grpCrearCategoria.Controls.Add(this.textBox1);
            this.grpCrearCategoria.Controls.Add(this.lblCategoria);
            this.grpCrearCategoria.Location = new System.Drawing.Point(413, 37);
            this.grpCrearCategoria.Name = "grpCrearCategoria";
            this.grpCrearCategoria.Size = new System.Drawing.Size(250, 172);
            this.grpCrearCategoria.TabIndex = 2;
            this.grpCrearCategoria.TabStop = false;
            this.grpCrearCategoria.Text = "Crear Categoria";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(16, 33);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 0;
            this.lblCategoria.Text = "Categoria";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(86, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(135, 20);
            this.textBox2.TabIndex = 3;
            // 
            // lblJornada
            // 
            this.lblJornada.AutoSize = true;
            this.lblJornada.Location = new System.Drawing.Point(16, 68);
            this.lblJornada.Name = "lblJornada";
            this.lblJornada.Size = new System.Drawing.Size(45, 13);
            this.lblJornada.TabIndex = 2;
            this.lblJornada.Text = "Jornada";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(86, 102);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(135, 20);
            this.textBox3.TabIndex = 5;
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(16, 105);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(40, 13);
            this.lblSueldo.TabIndex = 4;
            this.lblSueldo.Text = "Sueldo";
            // 
            // btnCancelarCrear
            // 
            this.btnCancelarCrear.Location = new System.Drawing.Point(19, 143);
            this.btnCancelarCrear.Name = "btnCancelarCrear";
            this.btnCancelarCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarCrear.TabIndex = 6;
            this.btnCancelarCrear.Text = "Cancelar";
            this.btnCancelarCrear.UseVisualStyleBackColor = true;
            // 
            // btnGuardarCrear
            // 
            this.btnGuardarCrear.Location = new System.Drawing.Point(146, 143);
            this.btnGuardarCrear.Name = "btnGuardarCrear";
            this.btnGuardarCrear.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarCrear.TabIndex = 7;
            this.btnGuardarCrear.Text = "Guardar";
            this.btnGuardarCrear.UseVisualStyleBackColor = true;
            // 
            // grpModificarCategoria
            // 
            this.grpModificarCategoria.Controls.Add(this.btnGuardarModif);
            this.grpModificarCategoria.Controls.Add(this.btnCancelarModif);
            this.grpModificarCategoria.Controls.Add(this.txtSueldoModif);
            this.grpModificarCategoria.Controls.Add(this.lblSueldoModif);
            this.grpModificarCategoria.Controls.Add(this.txtJornadaModif);
            this.grpModificarCategoria.Controls.Add(this.lblJornadaModif);
            this.grpModificarCategoria.Controls.Add(this.txtCategoriaModif);
            this.grpModificarCategoria.Controls.Add(this.lblCategoriaModif);
            this.grpModificarCategoria.Location = new System.Drawing.Point(413, 217);
            this.grpModificarCategoria.Name = "grpModificarCategoria";
            this.grpModificarCategoria.Size = new System.Drawing.Size(250, 172);
            this.grpModificarCategoria.TabIndex = 8;
            this.grpModificarCategoria.TabStop = false;
            this.grpModificarCategoria.Text = "Modificar Categoria";
            // 
            // btnGuardarModif
            // 
            this.btnGuardarModif.Location = new System.Drawing.Point(146, 143);
            this.btnGuardarModif.Name = "btnGuardarModif";
            this.btnGuardarModif.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarModif.TabIndex = 7;
            this.btnGuardarModif.Text = "Guardar";
            this.btnGuardarModif.UseVisualStyleBackColor = true;
            // 
            // btnCancelarModif
            // 
            this.btnCancelarModif.Location = new System.Drawing.Point(19, 143);
            this.btnCancelarModif.Name = "btnCancelarModif";
            this.btnCancelarModif.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarModif.TabIndex = 6;
            this.btnCancelarModif.Text = "Cancelar";
            this.btnCancelarModif.UseVisualStyleBackColor = true;
            // 
            // txtSueldoModif
            // 
            this.txtSueldoModif.Location = new System.Drawing.Point(86, 102);
            this.txtSueldoModif.Name = "txtSueldoModif";
            this.txtSueldoModif.Size = new System.Drawing.Size(135, 20);
            this.txtSueldoModif.TabIndex = 5;
            // 
            // lblSueldoModif
            // 
            this.lblSueldoModif.AutoSize = true;
            this.lblSueldoModif.Location = new System.Drawing.Point(16, 105);
            this.lblSueldoModif.Name = "lblSueldoModif";
            this.lblSueldoModif.Size = new System.Drawing.Size(40, 13);
            this.lblSueldoModif.TabIndex = 4;
            this.lblSueldoModif.Text = "Sueldo";
            // 
            // txtJornadaModif
            // 
            this.txtJornadaModif.Location = new System.Drawing.Point(86, 65);
            this.txtJornadaModif.Name = "txtJornadaModif";
            this.txtJornadaModif.Size = new System.Drawing.Size(135, 20);
            this.txtJornadaModif.TabIndex = 3;
            // 
            // lblJornadaModif
            // 
            this.lblJornadaModif.AutoSize = true;
            this.lblJornadaModif.Location = new System.Drawing.Point(16, 68);
            this.lblJornadaModif.Name = "lblJornadaModif";
            this.lblJornadaModif.Size = new System.Drawing.Size(45, 13);
            this.lblJornadaModif.TabIndex = 2;
            this.lblJornadaModif.Text = "Jornada";
            // 
            // txtCategoriaModif
            // 
            this.txtCategoriaModif.Location = new System.Drawing.Point(86, 30);
            this.txtCategoriaModif.Name = "txtCategoriaModif";
            this.txtCategoriaModif.Size = new System.Drawing.Size(135, 20);
            this.txtCategoriaModif.TabIndex = 1;
            // 
            // lblCategoriaModif
            // 
            this.lblCategoriaModif.AutoSize = true;
            this.lblCategoriaModif.Location = new System.Drawing.Point(16, 33);
            this.lblCategoriaModif.Name = "lblCategoriaModif";
            this.lblCategoriaModif.Size = new System.Drawing.Size(52, 13);
            this.lblCategoriaModif.TabIndex = 0;
            this.lblCategoriaModif.Text = "Categoria";
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 453);
            this.Controls.Add(this.grpModificarCategoria);
            this.Controls.Add(this.grpCrearCategoria);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.dtgCategoria);
            this.Name = "frmCategorias";
            this.Text = "Categorias";
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategoria)).EndInit();
            this.grpCrearCategoria.ResumeLayout(false);
            this.grpCrearCategoria.PerformLayout();
            this.grpModificarCategoria.ResumeLayout(false);
            this.grpModificarCategoria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.GroupBox grpCrearCategoria;
        private System.Windows.Forms.Button btnGuardarCrear;
        private System.Windows.Forms.Button btnCancelarCrear;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblJornada;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.GroupBox grpModificarCategoria;
        private System.Windows.Forms.Button btnGuardarModif;
        private System.Windows.Forms.Button btnCancelarModif;
        private System.Windows.Forms.TextBox txtSueldoModif;
        private System.Windows.Forms.Label lblSueldoModif;
        private System.Windows.Forms.TextBox txtJornadaModif;
        private System.Windows.Forms.Label lblJornadaModif;
        private System.Windows.Forms.TextBox txtCategoriaModif;
        private System.Windows.Forms.Label lblCategoriaModif;
    }
}