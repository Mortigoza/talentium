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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.modiicacion = new System.Windows.Forms.TabControl();
            this.tbpAlta = new System.Windows.Forms.TabPage();
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
            this.tbpModificar = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridModificar = new System.Windows.Forms.DataGridView();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.tabReporte = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarReporte = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.modiicacion.SuspendLayout();
            this.tbpAlta.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlta)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tbpModificar.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridModificar)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabReporte.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // modiicacion
            // 
            this.modiicacion.AccessibleName = "";
            this.modiicacion.Controls.Add(this.tbpAlta);
            this.modiicacion.Controls.Add(this.tbpModificar);
            this.modiicacion.Controls.Add(this.tabReporte);
            this.modiicacion.Location = new System.Drawing.Point(1, 0);
            this.modiicacion.Name = "modiicacion";
            this.modiicacion.SelectedIndex = 0;
            this.modiicacion.Size = new System.Drawing.Size(1104, 541);
            this.modiicacion.TabIndex = 7;
            // 
            // tbpAlta
            // 
            this.tbpAlta.Controls.Add(this.groupBox2);
            this.tbpAlta.Controls.Add(this.groupBox1);
            this.tbpAlta.Location = new System.Drawing.Point(4, 25);
            this.tbpAlta.Name = "tbpAlta";
            this.tbpAlta.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAlta.Size = new System.Drawing.Size(1096, 512);
            this.tbpAlta.TabIndex = 0;
            this.tbpAlta.Text = "Alta";
            this.tbpAlta.UseVisualStyleBackColor = true;
            this.tbpAlta.Click += new System.EventHandler(this.tabPage1_Click);
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
            this.puestosAltas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.areasAltas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.areasAltas.FormattingEnabled = true;
            this.areasAltas.Location = new System.Drawing.Point(66, 40);
            this.areasAltas.Name = "areasAltas";
            this.areasAltas.Size = new System.Drawing.Size(208, 24);
            this.areasAltas.TabIndex = 9;
            this.areasAltas.SelectedIndexChanged += new System.EventHandler(this.areasAltas_SelectedIndexChanged);
            // 
            // tbpModificar
            // 
            this.tbpModificar.Controls.Add(this.btnExcel);
            this.tbpModificar.Controls.Add(this.groupBox3);
            this.tbpModificar.Controls.Add(this.groupBox4);
            this.tbpModificar.Location = new System.Drawing.Point(4, 25);
            this.tbpModificar.Name = "tbpModificar";
            this.tbpModificar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpModificar.Size = new System.Drawing.Size(1096, 512);
            this.tbpModificar.TabIndex = 1;
            this.tbpModificar.Text = "Modificaciòn";
            this.tbpModificar.UseVisualStyleBackColor = true;
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
            // Modificar
            // 
            this.Modificar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.Modificar.DefaultCellStyle = dataGridViewCellStyle1;
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
            this.PuestoMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PuestoMod.FormattingEnabled = true;
            this.PuestoMod.Location = new System.Drawing.Point(66, 61);
            this.PuestoMod.Name = "PuestoMod";
            this.PuestoMod.Size = new System.Drawing.Size(208, 24);
            this.PuestoMod.TabIndex = 27;
            // 
            // AreaMod
            // 
            this.AreaMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            // tabReporte
            // 
            this.tabReporte.Controls.Add(this.groupBox5);
            this.tabReporte.Controls.Add(this.groupBox6);
            this.tabReporte.Location = new System.Drawing.Point(4, 25);
            this.tabReporte.Name = "tabReporte";
            this.tabReporte.Padding = new System.Windows.Forms.Padding(3);
            this.tabReporte.Size = new System.Drawing.Size(1096, 512);
            this.tabReporte.TabIndex = 2;
            this.tabReporte.Text = "Reporte";
            this.tabReporte.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView1);
            this.groupBox5.Location = new System.Drawing.Point(308, 28);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(782, 379);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Personal";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(2, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(770, 353);
            this.dataGridView1.TabIndex = 12;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.checkBox1);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.comboBox1);
            this.groupBox6.Controls.Add(this.comboBox2);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.dateTimePicker1);
            this.groupBox6.Controls.Add(this.dateTimePicker2);
            this.groupBox6.Controls.Add(this.dateTimePicker3);
            this.groupBox6.Controls.Add(this.btnBuscarReporte);
            this.groupBox6.Controls.Add(this.textBox1);
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Location = new System.Drawing.Point(12, 28);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(290, 379);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Filtros";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(0, 148);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 20);
            this.checkBox1.TabIndex = 32;
            this.checkBox1.Text = "Periodo";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(48, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 16);
            this.label9.TabIndex = 31;
            this.label9.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(40, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(12, 16);
            this.label15.TabIndex = 30;
            this.label15.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(0, 64);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 16);
            this.label16.TabIndex = 28;
            this.label16.Text = "Puesto:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(66, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(208, 24);
            this.comboBox1.TabIndex = 27;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(66, 31);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(208, 24);
            this.comboBox2.TabIndex = 26;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 34);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 16);
            this.label17.TabIndex = 25;
            this.label17.Text = "Àrea:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(0, 183);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 16);
            this.label18.TabIndex = 22;
            this.label18.Text = "Fecha:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(-1, 220);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 16);
            this.label19.TabIndex = 21;
            this.label19.Text = "Fecha desde:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(0, 264);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(84, 16);
            this.label20.TabIndex = 20;
            this.label20.Text = "Fecha hasta:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(90, 259);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(184, 22);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(90, 220);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(184, 22);
            this.dateTimePicker2.TabIndex = 18;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(74, 183);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker3.TabIndex = 17;
            // 
            // btnBuscarReporte
            // 
            this.btnBuscarReporte.Location = new System.Drawing.Point(203, 341);
            this.btnBuscarReporte.Name = "btnBuscarReporte";
            this.btnBuscarReporte.Size = new System.Drawing.Size(81, 32);
            this.btnBuscarReporte.TabIndex = 13;
            this.btnBuscarReporte.Text = "Buscar";
            this.btnBuscarReporte.UseVisualStyleBackColor = true;
            this.btnBuscarReporte.Click += new System.EventHandler(this.btnBuscarReporte_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(51, 103);
            this.textBox1.MaxLength = 12;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 22);
            this.textBox1.TabIndex = 14;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 109);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(39, 16);
            this.label21.TabIndex = 13;
            this.label21.Text = "CUIL:";
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(1014, 452);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(75, 23);
            this.btnExcel.TabIndex = 14;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // Asistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 540);
            this.Controls.Add(this.modiicacion);
            this.Name = "Asistencias";
            this.Text = "Asistencias";
            this.modiicacion.ResumeLayout(false);
            this.tbpAlta.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbpModificar.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridModificar)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabReporte.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl modiicacion;
        private System.Windows.Forms.TabPage tbpAlta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridAlta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buscarAlta;
        private System.Windows.Forms.TextBox cuilAltas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox areasAltas;
        private System.Windows.Forms.TabPage tbpModificar;
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
        private System.Windows.Forms.TabPage tabReporte;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Button btnBuscarReporte;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnExcel;
    }
}