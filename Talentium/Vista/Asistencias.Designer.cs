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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.abrirAlta = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridAlta = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.puestosAltas = new System.Windows.Forms.ComboBox();
            this.buscarAlta = new System.Windows.Forms.Button();
            this.cuilAltas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.areasAltas = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.periodo = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Abrir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlta)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.tabPage1.Controls.Add(this.abrirAlta);
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
            // abrirAlta
            // 
            this.abrirAlta.Location = new System.Drawing.Point(998, 411);
            this.abrirAlta.Name = "abrirAlta";
            this.abrirAlta.Size = new System.Drawing.Size(81, 32);
            this.abrirAlta.TabIndex = 15;
            this.abrirAlta.Text = "Abrir";
            this.abrirAlta.UseVisualStyleBackColor = true;
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
            // groupBox1
            // 
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
            this.puestosAltas.Location = new System.Drawing.Point(57, 70);
            this.puestosAltas.Name = "puestosAltas";
            this.puestosAltas.Size = new System.Drawing.Size(217, 24);
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
            this.areasAltas.Location = new System.Drawing.Point(51, 40);
            this.areasAltas.Name = "areasAltas";
            this.areasAltas.Size = new System.Drawing.Size(223, 24);
            this.areasAltas.TabIndex = 9;
            this.areasAltas.SelectedIndexChanged += new System.EventHandler(this.areasAltas_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button4);
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
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(998, 400);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 32);
            this.button4.TabIndex = 23;
            this.button4.Text = "Abrir";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Location = new System.Drawing.Point(303, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(782, 379);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Personal";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.Location = new System.Drawing.Point(2, 17);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(770, 353);
            this.dataGridView2.TabIndex = 12;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.periodo);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.comboBox5);
            this.groupBox4.Controls.Add(this.comboBox2);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.dateTimePicker3);
            this.groupBox4.Controls.Add(this.dateTimePicker2);
            this.groupBox4.Controls.Add(this.dateTimePicker1);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.textBox4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(7, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(290, 379);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filtros";
            // 
            // periodo
            // 
            this.periodo.AutoSize = true;
            this.periodo.Location = new System.Drawing.Point(8, 147);
            this.periodo.Name = "periodo";
            this.periodo.Size = new System.Drawing.Size(76, 20);
            this.periodo.TabIndex = 29;
            this.periodo.TabStop = true;
            this.periodo.Text = "Periodo";
            this.periodo.UseVisualStyleBackColor = true;
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
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(57, 61);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(217, 24);
            this.comboBox5.TabIndex = 27;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(51, 31);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(223, 24);
            this.comboBox2.TabIndex = 26;
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
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(90, 259);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(184, 22);
            this.dateTimePicker3.TabIndex = 19;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(90, 220);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(184, 22);
            this.dateTimePicker2.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(74, 183);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(203, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 32);
            this.button2.TabIndex = 13;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(51, 103);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(223, 22);
            this.textBox4.TabIndex = 14;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button abrirAlta;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox puestosAltas;
        private System.Windows.Forms.RadioButton periodo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewButtonColumn Abrir;
    }
}