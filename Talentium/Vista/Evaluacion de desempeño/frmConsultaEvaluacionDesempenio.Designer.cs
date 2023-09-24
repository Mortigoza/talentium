namespace Vista.Evaluacion_de_desempeño
{
    partial class frmConsultaEvaluacionDesempenio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaEvaluacionDesempenio));
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblCantidadEval = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCuil = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbAnio = new System.Windows.Forms.ComboBox();
            this.cmbPersonal = new System.Windows.Forms.ComboBox();
            this.lblNombreYApellido = new System.Windows.Forms.Label();
            this.cmbAreas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgConsultaEvaluacion = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.Anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MesEvaluacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EfectTareas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puntualidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disciplina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RelSup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesempEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultaEvaluacion)).BeginInit();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(321, 95);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(72, 19);
            this.btnBuscar.TabIndex = 34;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCantidadEval
            // 
            this.lblCantidadEval.AutoSize = true;
            this.lblCantidadEval.Location = new System.Drawing.Point(265, 305);
            this.lblCantidadEval.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidadEval.Name = "lblCantidadEval";
            this.lblCantidadEval.Size = new System.Drawing.Size(13, 13);
            this.lblCantidadEval.TabIndex = 33;
            this.lblCantidadEval.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 305);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(241, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "TOTAL DE EVALUACIONES HASTA LA FECHA:";
            // 
            // lblCuil
            // 
            this.lblCuil.AutoSize = true;
            this.lblCuil.Location = new System.Drawing.Point(101, 42);
            this.lblCuil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCuil.Name = "lblCuil";
            this.lblCuil.Size = new System.Drawing.Size(79, 13);
            this.lblCuil.TabIndex = 29;
            this.lblCuil.Text = "20-39123456-0";
            this.lblCuil.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "CUIL/CUIT";
            // 
            // cmbAnio
            // 
            this.cmbAnio.FormattingEnabled = true;
            this.cmbAnio.Location = new System.Drawing.Point(210, 94);
            this.cmbAnio.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAnio.Name = "cmbAnio";
            this.cmbAnio.Size = new System.Drawing.Size(92, 21);
            this.cmbAnio.TabIndex = 27;
            // 
            // cmbPersonal
            // 
            this.cmbPersonal.FormattingEnabled = true;
            this.cmbPersonal.Items.AddRange(new object[] {
            "sdsad"});
            this.cmbPersonal.Location = new System.Drawing.Point(210, 63);
            this.cmbPersonal.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPersonal.Name = "cmbPersonal";
            this.cmbPersonal.Size = new System.Drawing.Size(92, 21);
            this.cmbPersonal.TabIndex = 26;
            // 
            // lblNombreYApellido
            // 
            this.lblNombreYApellido.AutoSize = true;
            this.lblNombreYApellido.Location = new System.Drawing.Point(101, 21);
            this.lblNombreYApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreYApellido.Name = "lblNombreYApellido";
            this.lblNombreYApellido.Size = new System.Drawing.Size(79, 13);
            this.lblNombreYApellido.TabIndex = 25;
            this.lblNombreYApellido.Text = "Facundo Pacci";
            this.lblNombreYApellido.Visible = false;
            // 
            // cmbAreas
            // 
            this.cmbAreas.FormattingEnabled = true;
            this.cmbAreas.Location = new System.Drawing.Point(210, 25);
            this.cmbAreas.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAreas.Name = "cmbAreas";
            this.cmbAreas.Size = new System.Drawing.Size(92, 21);
            this.cmbAreas.TabIndex = 24;
            this.cmbAreas.SelectedIndexChanged += new System.EventHandler(this.cmbAreas_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Nombre y Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Filtro por area *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Filtro por año";
            // 
            // dtgConsultaEvaluacion
            // 
            this.dtgConsultaEvaluacion.BackgroundColor = System.Drawing.Color.White;
            this.dtgConsultaEvaluacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConsultaEvaluacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Anio,
            this.MesEvaluacion,
            this.EfectTareas,
            this.Puntualidad,
            this.Disciplina,
            this.RelSup,
            this.DesempEquipo});
            this.dtgConsultaEvaluacion.Location = new System.Drawing.Point(17, 132);
            this.dtgConsultaEvaluacion.Margin = new System.Windows.Forms.Padding(2);
            this.dtgConsultaEvaluacion.Name = "dtgConsultaEvaluacion";
            this.dtgConsultaEvaluacion.RowHeadersWidth = 51;
            this.dtgConsultaEvaluacion.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgConsultaEvaluacion.RowTemplate.Height = 24;
            this.dtgConsultaEvaluacion.Size = new System.Drawing.Size(707, 162);
            this.dtgConsultaEvaluacion.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Filtro por empleado *";
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.label4);
            this.grpDatos.Controls.Add(this.label6);
            this.grpDatos.Controls.Add(this.lblNombreYApellido);
            this.grpDatos.Controls.Add(this.lblCuil);
            this.grpDatos.Location = new System.Drawing.Point(505, 52);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(195, 63);
            this.grpDatos.TabIndex = 35;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos del empleado";
            // 
            // Anio
            // 
            this.Anio.HeaderText = "Año";
            this.Anio.Name = "Anio";
            this.Anio.Width = 60;
            // 
            // MesEvaluacion
            // 
            this.MesEvaluacion.HeaderText = "Mes de Evaluacion";
            this.MesEvaluacion.MinimumWidth = 6;
            this.MesEvaluacion.Name = "MesEvaluacion";
            this.MesEvaluacion.Width = 90;
            // 
            // EfectTareas
            // 
            this.EfectTareas.HeaderText = "Efectividad en las tareas";
            this.EfectTareas.MinimumWidth = 6;
            this.EfectTareas.Name = "EfectTareas";
            this.EfectTareas.Width = 95;
            // 
            // Puntualidad
            // 
            this.Puntualidad.HeaderText = "Puntualidad";
            this.Puntualidad.MinimumWidth = 6;
            this.Puntualidad.Name = "Puntualidad";
            this.Puntualidad.Width = 95;
            // 
            // Disciplina
            // 
            this.Disciplina.HeaderText = "Disciplina";
            this.Disciplina.MinimumWidth = 6;
            this.Disciplina.Name = "Disciplina";
            this.Disciplina.Width = 95;
            // 
            // RelSup
            // 
            this.RelSup.HeaderText = "Relacion con superiores";
            this.RelSup.MinimumWidth = 6;
            this.RelSup.Name = "RelSup";
            this.RelSup.Width = 95;
            // 
            // DesempEquipo
            // 
            this.DesempEquipo.HeaderText = "Desempeño en equipo";
            this.DesempEquipo.MinimumWidth = 6;
            this.DesempEquipo.Name = "DesempEquipo";
            this.DesempEquipo.Width = 95;
            // 
            // frmConsultaEvaluacionDesempenio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 349);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblCantidadEval);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbAnio);
            this.Controls.Add(this.cmbPersonal);
            this.Controls.Add(this.cmbAreas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgConsultaEvaluacion);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmConsultaEvaluacionDesempenio";
            this.Text = "Consultar Evaluacion de Desempeño";
            this.Load += new System.EventHandler(this.frmConsultaEvaluacionDesempenio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultaEvaluacion)).EndInit();
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblCantidadEval;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCuil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbAnio;
        private System.Windows.Forms.ComboBox cmbPersonal;
        private System.Windows.Forms.Label lblNombreYApellido;
        private System.Windows.Forms.ComboBox cmbAreas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgConsultaEvaluacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn MesEvaluacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn EfectTareas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puntualidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disciplina;
        private System.Windows.Forms.DataGridViewTextBoxColumn RelSup;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesempEquipo;
    }
}