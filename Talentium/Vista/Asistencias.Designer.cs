namespace Vista
{
    partial class Asistencias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridAlta = new System.Windows.Forms.DataGridView();
            this.Abrir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.puestosAltas = new System.Windows.Forms.ComboBox();
            this.buscarAlta = new System.Windows.Forms.Button();
            this.cuilAltas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.areasAltas = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridModificar = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.periodo = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.PuestoMod = new System.Windows.Forms.ComboBox();
            this.AreaMod = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.FechaHastaMod = new System.Windows.Forms.DateTimePicker();
            this.fechaDesdeMod = new System.Windows.Forms.DateTimePicker();
            this.FechaMod = new System.Windows.Forms.DateTimePicker();
            this.buscarMod = new System.Windows.Forms.Button();
            this.CuilMod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlta)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridModificar)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleName = "";
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1104, 541);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1096, 512);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Alta";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridAlta);
            this.groupBox2.Location = new System.Drawing.Point(303, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(782, 380);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personal";
            // 
            // dataGridAlta
            // 
            this.dataGridAlta.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridAlta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAlta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Abrir});
            this.dataGridAlta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridAlta.Location = new System.Drawing.Point(6, 21);
            this.dataGridAlta.Name = "dataGridAlta";
            this.dataGridAlta.RowHeadersWidth = 51;
            this.dataGridAlta.RowTemplate.Height = 24;
            this.dataGridAlta.Size = new System.Drawing.Size(770, 353);
            this.dataGridAlta.TabIndex = 12;
            this.dataGridAlta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridAlta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Abrir
            // 
            this.Abrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Abrir.HeaderText = "Abrir";
            this.Abrir.MinimumWidth = 6;
            this.Abrir.Name = "Abrir";
            this.Abrir.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Abrir.Text = "Abrir";
            this.Abrir.ToolTipText = "Click";
            this.Abrir.UseColumnTextForButtonValue = true;
            this.Abrir.Width = 80;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.puestosAltas);
            this.groupBox1.Controls.Add(this.buscarAlta);
            this.groupBox1.Controls.Add(this.cuilAltas);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.areasAltas);
            this.groupBox1.Location = new System.Drawing.Point(7, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 380);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(48, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(40, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(0, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 16);
            this.label13.TabIndex = 16;
            this.label13.Text = "Puesto:";
            // 
            // puestosAltas
            // 
            this.puestosAltas.FormattingEnabled = true;
            this.puestosAltas.Location = new System.Drawing.Point(66, 70);
            this.puestosAltas.Name = "puestosAltas";
            this.puestosAltas.Size = new System.Drawing.Size(208, 24);
            this.puestosAltas.TabIndex = 15;
            // 
            // buscarAlta
            // 
            this.buscarAlta.Location = new System.Drawing.Point(193, 306);
            this.buscarAlta.Name = "buscarAlta";
            this.buscarAlta.Size = new System.Drawing.Size(81, 32);
            this.buscarAlta.TabIndex = 13;
            this.buscarAlta.Text = "Buscar";
            this.buscarAlta.UseVisualStyleBackColor = true;
            this.buscarAlta.Click += new System.EventHandler(this.button1_Click);
            // 
            // cuilAltas
            // 
            this.cuilAltas.Location = new System.Drawing.Point(51, 132);
            this.cuilAltas.Name = "cuilAltas";
            this.cuilAltas.Size = new System.Drawing.Size(223, 22);
            this.cuilAltas.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "CUIL:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Àrea:";
            // 
            // areasAltas
            // 
            this.areasAltas.FormattingEnabled = true;
            this.areasAltas.Location = new System.Drawing.Point(66, 40);
            this.areasAltas.Name = "areasAltas";
            this.areasAltas.Size = new System.Drawing.Size(208, 24);
            this.areasAltas.TabIndex = 9;
            this.areasAltas.SelectedIndexChanged += new System.EventHandler(this.areasAltas_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1096, 512);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificaciòn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridModificar);
            this.groupBox3.Location = new System.Drawing.Point(303, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(782, 379);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Personal";
            // 
            // dataGridModificar
            // 
            this.dataGridModificar.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridModificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridModificar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modificar});
            this.dataGridModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridModificar.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridModificar.Location = new System.Drawing.Point(2, 17);
            this.dataGridModificar.Name = "dataGridModificar";
            this.dataGridModificar.RowHeadersWidth = 51;
            this.dataGridModificar.RowTemplate.Height = 24;
            this.dataGridModificar.Size = new System.Drawing.Size(770, 353);
            this.dataGridModificar.TabIndex = 12;
            this.dataGridModificar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridModificar_CellContentClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.periodo);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.PuestoMod);
            this.groupBox4.Controls.Add(this.AreaMod);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.FechaHastaMod);
            this.groupBox4.Controls.Add(this.fechaDesdeMod);
            this.groupBox4.Controls.Add(this.FechaMod);
            this.groupBox4.Controls.Add(this.buscarMod);
            this.groupBox4.Controls.Add(this.CuilMod);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(7, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(290, 379);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filtros";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // periodo
            // 
            this.periodo.AutoSize = true;
            this.periodo.Location = new System.Drawing.Point(0, 148);
            this.periodo.Name = "periodo";
            this.periodo.Size = new System.Drawing.Size(77, 20);
            this.periodo.TabIndex = 32;
            this.periodo.Text = "Periodo";
            this.periodo.UseVisualStyleBackColor = true;
            this.periodo.CheckedChanged += new System.EventHandler(this.periodo_CheckedChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(48, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(40, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(0, 64);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 16);
            this.label14.TabIndex = 28;
            this.label14.Text = "Puesto:";
            // 
            // PuestoMod
            // 
            this.PuestoMod.FormattingEnabled = true;
            this.PuestoMod.Location = new System.Drawing.Point(66, 61);
            this.PuestoMod.Name = "PuestoMod";
            this.PuestoMod.Size = new System.Drawing.Size(208, 24);
            this.PuestoMod.TabIndex = 27;
            // 
            // AreaMod
            // 
            this.AreaMod.FormattingEnabled = true;
            this.AreaMod.Location = new System.Drawing.Point(66, 31);
            this.AreaMod.Name = "AreaMod";
            this.AreaMod.Size = new System.Drawing.Size(208, 24);
            this.AreaMod.TabIndex = 26;
            this.AreaMod.SelectedIndexChanged += new System.EventHandler(this.AreaMod_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Àrea:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(0, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 16);
            this.label12.TabIndex = 22;
            this.label12.Text = "Fecha:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(-1, 220);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Fecha desde:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(0, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Fecha hasta:";
            // 
            // FechaHastaMod
            // 
            this.FechaHastaMod.Location = new System.Drawing.Point(90, 259);
            this.FechaHastaMod.Name = "FechaHastaMod";
            this.FechaHastaMod.Size = new System.Drawing.Size(184, 22);
            this.FechaHastaMod.TabIndex = 19;
            // 
            // fechaDesdeMod
            // 
            this.fechaDesdeMod.Location = new System.Drawing.Point(90, 220);
            this.fechaDesdeMod.Name = "fechaDesdeMod";
            this.fechaDesdeMod.Size = new System.Drawing.Size(184, 22);
            this.fechaDesdeMod.TabIndex = 18;
            // 
            // FechaMod
            // 
            this.FechaMod.Location = new System.Drawing.Point(74, 183);
            this.FechaMod.Name = "FechaMod";
            this.FechaMod.Size = new System.Drawing.Size(200, 22);
            this.FechaMod.TabIndex = 17;
            // 
            // buscarMod
            // 
            this.buscarMod.Location = new System.Drawing.Point(203, 341);
            this.buscarMod.Name = "buscarMod";
            this.buscarMod.Size = new System.Drawing.Size(81, 32);
            this.buscarMod.TabIndex = 13;
            this.buscarMod.Text = "Buscar";
            this.buscarMod.UseVisualStyleBackColor = true;
            this.buscarMod.Click += new System.EventHandler(this.button2_Click);
            // 
            // CuilMod
            // 
            this.CuilMod.Location = new System.Drawing.Point(51, 103);
            this.CuilMod.Name = "CuilMod";
            this.CuilMod.Size = new System.Drawing.Size(223, 22);
            this.CuilMod.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "CUIL:";
            // 
            // Modificar
            // 
            this.Modificar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.Modificar.DefaultCellStyle = dataGridViewCellStyle2;
            this.Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Modificar.HeaderText = "Modificar";
            this.Modificar.MinimumWidth = 6;
            this.Modificar.Name = "Modificar";
            this.Modificar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Modificar.Text = "Abrir";
            this.Modificar.ToolTipText = "Abrir";
            this.Modificar.UseColumnTextForButtonValue = true;
            this.Modificar.Width = 68;
            // 
            // Asistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 540);
            this.Controls.Add(this.tabControl1);
            this.Name = "Asistencias";
            this.Text = "Asistencias";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridModificar)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridAlta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buscarAlta;
        private System.Windows.Forms.TextBox cuilAltas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox areasAltas;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridModificar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker FechaHastaMod;
        private System.Windows.Forms.DateTimePicker fechaDesdeMod;
        private System.Windows.Forms.DateTimePicker FechaMod;
        private System.Windows.Forms.Button buscarMod;
        private System.Windows.Forms.TextBox CuilMod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox puestosAltas;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox PuestoMod;
        private System.Windows.Forms.ComboBox AreaMod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewButtonColumn Abrir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox periodo;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
    }
}