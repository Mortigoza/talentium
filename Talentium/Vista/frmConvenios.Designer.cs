namespace Vista
{
    partial class frmConvenios
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
            this.dtgConvenio = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBaja = new System.Windows.Forms.Button();
            this.grpCrear = new System.Windows.Forms.GroupBox();
            this.btnGuardarCrear = new System.Windows.Forms.Button();
            this.btnCancelarCrear = new System.Windows.Forms.Button();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.txtJornada = new System.Windows.Forms.TextBox();
            this.lblJornada = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblObraSocial = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblSeguridadSalud = new System.Windows.Forms.Label();
            this.txtConvenio = new System.Windows.Forms.TextBox();
            this.lblConvenio = new System.Windows.Forms.Label();
            this.grpModificar = new System.Windows.Forms.GroupBox();
            this.btnGuardarModif = new System.Windows.Forms.Button();
            this.txtSueldoModif = new System.Windows.Forms.TextBox();
            this.btnCancelarModif = new System.Windows.Forms.Button();
            this.lblSueldoModif = new System.Windows.Forms.Label();
            this.txtJornadaModif = new System.Windows.Forms.TextBox();
            this.lblJornadaModif = new System.Windows.Forms.Label();
            this.cmbCategoriaModif = new System.Windows.Forms.ComboBox();
            this.lblCategoriaModif = new System.Windows.Forms.Label();
            this.txtObraSocialModif = new System.Windows.Forms.TextBox();
            this.lblObraSocialModif = new System.Windows.Forms.Label();
            this.txtSeguridadSaludModif = new System.Windows.Forms.TextBox();
            this.lblSeguridadSaludModif = new System.Windows.Forms.Label();
            this.txtConvenioModif = new System.Windows.Forms.TextBox();
            this.lblConvenioModif = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConvenio)).BeginInit();
            this.grpCrear.SuspendLayout();
            this.grpModificar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgConvenio
            // 
            this.dtgConvenio.BackgroundColor = System.Drawing.Color.White;
            this.dtgConvenio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConvenio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dtgConvenio.Location = new System.Drawing.Point(30, 25);
            this.dtgConvenio.Name = "dtgConvenio";
            this.dtgConvenio.Size = new System.Drawing.Size(663, 150);
            this.dtgConvenio.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Convenio";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Categoria";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Obra Social";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Seguridad y Salud";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Jornada";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Sueldo";
            this.Column6.Name = "Column6";
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(700, 151);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(75, 23);
            this.btnBaja.TabIndex = 1;
            this.btnBaja.Text = "Dar de Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // grpCrear
            // 
            this.grpCrear.Controls.Add(this.btnGuardarCrear);
            this.grpCrear.Controls.Add(this.btnCancelarCrear);
            this.grpCrear.Controls.Add(this.txtSueldo);
            this.grpCrear.Controls.Add(this.lblSueldo);
            this.grpCrear.Controls.Add(this.txtJornada);
            this.grpCrear.Controls.Add(this.lblJornada);
            this.grpCrear.Controls.Add(this.cmbCategoria);
            this.grpCrear.Controls.Add(this.lblCategoria);
            this.grpCrear.Controls.Add(this.textBox2);
            this.grpCrear.Controls.Add(this.lblObraSocial);
            this.grpCrear.Controls.Add(this.textBox1);
            this.grpCrear.Controls.Add(this.lblSeguridadSalud);
            this.grpCrear.Controls.Add(this.txtConvenio);
            this.grpCrear.Controls.Add(this.lblConvenio);
            this.grpCrear.Location = new System.Drawing.Point(30, 181);
            this.grpCrear.Name = "grpCrear";
            this.grpCrear.Size = new System.Drawing.Size(300, 238);
            this.grpCrear.TabIndex = 2;
            this.grpCrear.TabStop = false;
            this.grpCrear.Text = "Crear Convenio";
            // 
            // btnGuardarCrear
            // 
            this.btnGuardarCrear.Location = new System.Drawing.Point(190, 209);
            this.btnGuardarCrear.Name = "btnGuardarCrear";
            this.btnGuardarCrear.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarCrear.TabIndex = 13;
            this.btnGuardarCrear.Text = "Guardar";
            this.btnGuardarCrear.UseVisualStyleBackColor = true;
            // 
            // btnCancelarCrear
            // 
            this.btnCancelarCrear.Location = new System.Drawing.Point(21, 209);
            this.btnCancelarCrear.Name = "btnCancelarCrear";
            this.btnCancelarCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarCrear.TabIndex = 12;
            this.btnCancelarCrear.Text = "Cancelar";
            this.btnCancelarCrear.UseVisualStyleBackColor = true;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(198, 102);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.ReadOnly = true;
            this.txtSueldo.Size = new System.Drawing.Size(67, 20);
            this.txtSueldo.TabIndex = 11;
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(152, 105);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(40, 13);
            this.lblSueldo.TabIndex = 10;
            this.lblSueldo.Text = "Sueldo";
            // 
            // txtJornada
            // 
            this.txtJornada.Location = new System.Drawing.Point(77, 102);
            this.txtJornada.Name = "txtJornada";
            this.txtJornada.ReadOnly = true;
            this.txtJornada.Size = new System.Drawing.Size(69, 20);
            this.txtJornada.TabIndex = 9;
            // 
            // lblJornada
            // 
            this.lblJornada.AutoSize = true;
            this.lblJornada.Location = new System.Drawing.Point(18, 105);
            this.lblJornada.Name = "lblJornada";
            this.lblJornada.Size = new System.Drawing.Size(45, 13);
            this.lblJornada.TabIndex = 8;
            this.lblJornada.Text = "Jornada";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(77, 62);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(188, 21);
            this.cmbCategoria.TabIndex = 7;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(18, 71);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 6;
            this.lblCategoria.Text = "Categoria";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(117, 177);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 20);
            this.textBox2.TabIndex = 5;
            // 
            // lblObraSocial
            // 
            this.lblObraSocial.AutoSize = true;
            this.lblObraSocial.Location = new System.Drawing.Point(18, 177);
            this.lblObraSocial.Name = "lblObraSocial";
            this.lblObraSocial.Size = new System.Drawing.Size(62, 13);
            this.lblObraSocial.TabIndex = 4;
            this.lblObraSocial.Text = "Obra Social";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 143);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 20);
            this.textBox1.TabIndex = 3;
            // 
            // lblSeguridadSalud
            // 
            this.lblSeguridadSalud.AutoSize = true;
            this.lblSeguridadSalud.Location = new System.Drawing.Point(18, 143);
            this.lblSeguridadSalud.Name = "lblSeguridadSalud";
            this.lblSeguridadSalud.Size = new System.Drawing.Size(93, 13);
            this.lblSeguridadSalud.TabIndex = 2;
            this.lblSeguridadSalud.Text = "Seguridad y Salud";
            // 
            // txtConvenio
            // 
            this.txtConvenio.Location = new System.Drawing.Point(77, 32);
            this.txtConvenio.Name = "txtConvenio";
            this.txtConvenio.Size = new System.Drawing.Size(188, 20);
            this.txtConvenio.TabIndex = 1;
            // 
            // lblConvenio
            // 
            this.lblConvenio.AutoSize = true;
            this.lblConvenio.Location = new System.Drawing.Point(18, 32);
            this.lblConvenio.Name = "lblConvenio";
            this.lblConvenio.Size = new System.Drawing.Size(52, 13);
            this.lblConvenio.TabIndex = 0;
            this.lblConvenio.Text = "Convenio";
            // 
            // grpModificar
            // 
            this.grpModificar.Controls.Add(this.btnGuardarModif);
            this.grpModificar.Controls.Add(this.txtSueldoModif);
            this.grpModificar.Controls.Add(this.btnCancelarModif);
            this.grpModificar.Controls.Add(this.lblSueldoModif);
            this.grpModificar.Controls.Add(this.txtJornadaModif);
            this.grpModificar.Controls.Add(this.lblJornadaModif);
            this.grpModificar.Controls.Add(this.cmbCategoriaModif);
            this.grpModificar.Controls.Add(this.lblCategoriaModif);
            this.grpModificar.Controls.Add(this.txtObraSocialModif);
            this.grpModificar.Controls.Add(this.lblObraSocialModif);
            this.grpModificar.Controls.Add(this.txtSeguridadSaludModif);
            this.grpModificar.Controls.Add(this.lblSeguridadSaludModif);
            this.grpModificar.Controls.Add(this.txtConvenioModif);
            this.grpModificar.Controls.Add(this.lblConvenioModif);
            this.grpModificar.Location = new System.Drawing.Point(393, 181);
            this.grpModificar.Name = "grpModificar";
            this.grpModificar.Size = new System.Drawing.Size(300, 238);
            this.grpModificar.TabIndex = 12;
            this.grpModificar.TabStop = false;
            this.grpModificar.Text = "Modificar Convenio";
            // 
            // btnGuardarModif
            // 
            this.btnGuardarModif.Location = new System.Drawing.Point(190, 209);
            this.btnGuardarModif.Name = "btnGuardarModif";
            this.btnGuardarModif.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarModif.TabIndex = 15;
            this.btnGuardarModif.Text = "Guardar";
            this.btnGuardarModif.UseVisualStyleBackColor = true;
            // 
            // txtSueldoModif
            // 
            this.txtSueldoModif.Location = new System.Drawing.Point(198, 102);
            this.txtSueldoModif.Name = "txtSueldoModif";
            this.txtSueldoModif.ReadOnly = true;
            this.txtSueldoModif.Size = new System.Drawing.Size(67, 20);
            this.txtSueldoModif.TabIndex = 11;
            // 
            // btnCancelarModif
            // 
            this.btnCancelarModif.Location = new System.Drawing.Point(21, 209);
            this.btnCancelarModif.Name = "btnCancelarModif";
            this.btnCancelarModif.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarModif.TabIndex = 14;
            this.btnCancelarModif.Text = "Cancelar";
            this.btnCancelarModif.UseVisualStyleBackColor = true;
            // 
            // lblSueldoModif
            // 
            this.lblSueldoModif.AutoSize = true;
            this.lblSueldoModif.Location = new System.Drawing.Point(152, 105);
            this.lblSueldoModif.Name = "lblSueldoModif";
            this.lblSueldoModif.Size = new System.Drawing.Size(40, 13);
            this.lblSueldoModif.TabIndex = 10;
            this.lblSueldoModif.Text = "Sueldo";
            // 
            // txtJornadaModif
            // 
            this.txtJornadaModif.Location = new System.Drawing.Point(77, 102);
            this.txtJornadaModif.Name = "txtJornadaModif";
            this.txtJornadaModif.ReadOnly = true;
            this.txtJornadaModif.Size = new System.Drawing.Size(69, 20);
            this.txtJornadaModif.TabIndex = 9;
            // 
            // lblJornadaModif
            // 
            this.lblJornadaModif.AutoSize = true;
            this.lblJornadaModif.Location = new System.Drawing.Point(18, 105);
            this.lblJornadaModif.Name = "lblJornadaModif";
            this.lblJornadaModif.Size = new System.Drawing.Size(45, 13);
            this.lblJornadaModif.TabIndex = 8;
            this.lblJornadaModif.Text = "Jornada";
            // 
            // cmbCategoriaModif
            // 
            this.cmbCategoriaModif.FormattingEnabled = true;
            this.cmbCategoriaModif.Location = new System.Drawing.Point(77, 62);
            this.cmbCategoriaModif.Name = "cmbCategoriaModif";
            this.cmbCategoriaModif.Size = new System.Drawing.Size(188, 21);
            this.cmbCategoriaModif.TabIndex = 7;
            // 
            // lblCategoriaModif
            // 
            this.lblCategoriaModif.AutoSize = true;
            this.lblCategoriaModif.Location = new System.Drawing.Point(18, 71);
            this.lblCategoriaModif.Name = "lblCategoriaModif";
            this.lblCategoriaModif.Size = new System.Drawing.Size(52, 13);
            this.lblCategoriaModif.TabIndex = 6;
            this.lblCategoriaModif.Text = "Categoria";
            // 
            // txtObraSocialModif
            // 
            this.txtObraSocialModif.Location = new System.Drawing.Point(117, 177);
            this.txtObraSocialModif.Name = "txtObraSocialModif";
            this.txtObraSocialModif.Size = new System.Drawing.Size(148, 20);
            this.txtObraSocialModif.TabIndex = 5;
            // 
            // lblObraSocialModif
            // 
            this.lblObraSocialModif.AutoSize = true;
            this.lblObraSocialModif.Location = new System.Drawing.Point(18, 177);
            this.lblObraSocialModif.Name = "lblObraSocialModif";
            this.lblObraSocialModif.Size = new System.Drawing.Size(62, 13);
            this.lblObraSocialModif.TabIndex = 4;
            this.lblObraSocialModif.Text = "Obra Social";
            // 
            // txtSeguridadSaludModif
            // 
            this.txtSeguridadSaludModif.Location = new System.Drawing.Point(117, 143);
            this.txtSeguridadSaludModif.Name = "txtSeguridadSaludModif";
            this.txtSeguridadSaludModif.Size = new System.Drawing.Size(148, 20);
            this.txtSeguridadSaludModif.TabIndex = 3;
            // 
            // lblSeguridadSaludModif
            // 
            this.lblSeguridadSaludModif.AutoSize = true;
            this.lblSeguridadSaludModif.Location = new System.Drawing.Point(18, 143);
            this.lblSeguridadSaludModif.Name = "lblSeguridadSaludModif";
            this.lblSeguridadSaludModif.Size = new System.Drawing.Size(93, 13);
            this.lblSeguridadSaludModif.TabIndex = 2;
            this.lblSeguridadSaludModif.Text = "Seguridad y Salud";
            // 
            // txtConvenioModif
            // 
            this.txtConvenioModif.Location = new System.Drawing.Point(77, 32);
            this.txtConvenioModif.Name = "txtConvenioModif";
            this.txtConvenioModif.Size = new System.Drawing.Size(188, 20);
            this.txtConvenioModif.TabIndex = 1;
            // 
            // lblConvenioModif
            // 
            this.lblConvenioModif.AutoSize = true;
            this.lblConvenioModif.Location = new System.Drawing.Point(18, 32);
            this.lblConvenioModif.Name = "lblConvenioModif";
            this.lblConvenioModif.Size = new System.Drawing.Size(52, 13);
            this.lblConvenioModif.TabIndex = 0;
            this.lblConvenioModif.Text = "Convenio";
            // 
            // frmConvenios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpModificar);
            this.Controls.Add(this.grpCrear);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.dtgConvenio);
            this.Name = "frmConvenios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convenios";
            ((System.ComponentModel.ISupportInitialize)(this.dtgConvenio)).EndInit();
            this.grpCrear.ResumeLayout(false);
            this.grpCrear.PerformLayout();
            this.grpModificar.ResumeLayout(false);
            this.grpModificar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgConvenio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.GroupBox grpCrear;
        private System.Windows.Forms.Button btnGuardarCrear;
        private System.Windows.Forms.Button btnCancelarCrear;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.TextBox txtJornada;
        private System.Windows.Forms.Label lblJornada;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblObraSocial;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblSeguridadSalud;
        private System.Windows.Forms.TextBox txtConvenio;
        private System.Windows.Forms.Label lblConvenio;
        private System.Windows.Forms.GroupBox grpModificar;
        private System.Windows.Forms.Button btnGuardarModif;
        private System.Windows.Forms.TextBox txtSueldoModif;
        private System.Windows.Forms.Button btnCancelarModif;
        private System.Windows.Forms.Label lblSueldoModif;
        private System.Windows.Forms.TextBox txtJornadaModif;
        private System.Windows.Forms.Label lblJornadaModif;
        private System.Windows.Forms.ComboBox cmbCategoriaModif;
        private System.Windows.Forms.Label lblCategoriaModif;
        private System.Windows.Forms.TextBox txtObraSocialModif;
        private System.Windows.Forms.Label lblObraSocialModif;
        private System.Windows.Forms.TextBox txtSeguridadSaludModif;
        private System.Windows.Forms.Label lblSeguridadSaludModif;
        private System.Windows.Forms.TextBox txtConvenioModif;
        private System.Windows.Forms.Label lblConvenioModif;
    }
}