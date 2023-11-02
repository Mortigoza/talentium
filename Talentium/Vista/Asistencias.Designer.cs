﻿namespace Vista
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
            this.modiicacion = new System.Windows.Forms.TabControl();
            this.tbpAlta = new System.Windows.Forms.TabPage();
            this.grbPersonalAlta = new System.Windows.Forms.GroupBox();
            this.dataGridAlta = new System.Windows.Forms.DataGridView();
            this.Abrir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grbFiltrosAlta = new System.Windows.Forms.GroupBox();
            this.lblErrorPuesto = new System.Windows.Forms.Label();
            this.lblErrorArea = new System.Windows.Forms.Label();
            this.lblPuestoAlta = new System.Windows.Forms.Label();
            this.puestosAltas = new System.Windows.Forms.ComboBox();
            this.buscarAlta = new System.Windows.Forms.Button();
            this.cuilAltas = new System.Windows.Forms.TextBox();
            this.lblCuilAlta = new System.Windows.Forms.Label();
            this.lblAreaAlta = new System.Windows.Forms.Label();
            this.areasAltas = new System.Windows.Forms.ComboBox();
            this.tbpModificar = new System.Windows.Forms.TabPage();
            this.btnExcel = new System.Windows.Forms.Button();
            this.grbInasistenciasMod = new System.Windows.Forms.GroupBox();
            this.dataGridModificar = new System.Windows.Forms.DataGridView();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grbFiltroMod = new System.Windows.Forms.GroupBox();
            this.periodo = new System.Windows.Forms.CheckBox();
            this.lblErrorPuestoMod = new System.Windows.Forms.Label();
            this.lblErrorAreaMod = new System.Windows.Forms.Label();
            this.lblPuestoMod = new System.Windows.Forms.Label();
            this.PuestoMod = new System.Windows.Forms.ComboBox();
            this.AreaMod = new System.Windows.Forms.ComboBox();
            this.lblAreaMod = new System.Windows.Forms.Label();
            this.lblFechaMod = new System.Windows.Forms.Label();
            this.lblFechaDesdeMod = new System.Windows.Forms.Label();
            this.lblFechaHastaMod = new System.Windows.Forms.Label();
            this.FechaHastaMod = new System.Windows.Forms.DateTimePicker();
            this.fechaDesdeMod = new System.Windows.Forms.DateTimePicker();
            this.FechaMod = new System.Windows.Forms.DateTimePicker();
            this.buscarMod = new System.Windows.Forms.Button();
            this.CuilMod = new System.Windows.Forms.TextBox();
            this.lblCuilMod = new System.Windows.Forms.Label();
            this.modiicacion.SuspendLayout();
            this.tbpAlta.SuspendLayout();
            this.grbPersonalAlta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlta)).BeginInit();
            this.grbFiltrosAlta.SuspendLayout();
            this.tbpModificar.SuspendLayout();
            this.grbInasistenciasMod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridModificar)).BeginInit();
            this.grbFiltroMod.SuspendLayout();
            this.SuspendLayout();
            // 
            // modiicacion
            // 
            this.modiicacion.AccessibleName = "";
            this.modiicacion.Controls.Add(this.tbpAlta);
            this.modiicacion.Controls.Add(this.tbpModificar);
            this.modiicacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modiicacion.Location = new System.Drawing.Point(0, 0);
            this.modiicacion.Name = "modiicacion";
            this.modiicacion.SelectedIndex = 0;
            this.modiicacion.Size = new System.Drawing.Size(1102, 540);
            this.modiicacion.TabIndex = 7;
            // 
            // tbpAlta
            // 
            this.tbpAlta.Controls.Add(this.grbPersonalAlta);
            this.tbpAlta.Controls.Add(this.grbFiltrosAlta);
            this.tbpAlta.Location = new System.Drawing.Point(4, 22);
            this.tbpAlta.Name = "tbpAlta";
            this.tbpAlta.Padding = new System.Windows.Forms.Padding(2);
            this.tbpAlta.Size = new System.Drawing.Size(1094, 514);
            this.tbpAlta.TabIndex = 0;
            this.tbpAlta.Text = "Alta";
            this.tbpAlta.UseVisualStyleBackColor = true;
            this.tbpAlta.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // grbPersonalAlta
            // 
            this.grbPersonalAlta.Controls.Add(this.dataGridAlta);
            this.grbPersonalAlta.Location = new System.Drawing.Point(303, 25);
            this.grbPersonalAlta.Name = "grbPersonalAlta";
            this.grbPersonalAlta.Size = new System.Drawing.Size(782, 380);
            this.grbPersonalAlta.TabIndex = 11;
            this.grbPersonalAlta.TabStop = false;
            this.grbPersonalAlta.Text = "Personal";
            // 
            // dataGridAlta
            // 
            this.dataGridAlta.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridAlta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAlta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Abrir});
            this.dataGridAlta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridAlta.Location = new System.Drawing.Point(4, 17);
            this.dataGridAlta.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridAlta.Name = "dataGridAlta";
            this.dataGridAlta.RowHeadersWidth = 51;
            this.dataGridAlta.RowTemplate.Height = 24;
            this.dataGridAlta.Size = new System.Drawing.Size(578, 287);
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
            // grbFiltrosAlta
            // 
            this.grbFiltrosAlta.Controls.Add(this.lblErrorPuesto);
            this.grbFiltrosAlta.Controls.Add(this.lblErrorArea);
            this.grbFiltrosAlta.Controls.Add(this.lblPuestoAlta);
            this.grbFiltrosAlta.Controls.Add(this.puestosAltas);
            this.grbFiltrosAlta.Controls.Add(this.buscarAlta);
            this.grbFiltrosAlta.Controls.Add(this.cuilAltas);
            this.grbFiltrosAlta.Controls.Add(this.lblCuilAlta);
            this.grbFiltrosAlta.Controls.Add(this.lblAreaAlta);
            this.grbFiltrosAlta.Controls.Add(this.areasAltas);
            this.grbFiltrosAlta.Location = new System.Drawing.Point(7, 25);
            this.grbFiltrosAlta.Name = "grbFiltrosAlta";
            this.grbFiltrosAlta.Size = new System.Drawing.Size(290, 380);
            this.grbFiltrosAlta.TabIndex = 10;
            this.grbFiltrosAlta.TabStop = false;
            this.grbFiltrosAlta.Text = "Filtros";
            this.grbFiltrosAlta.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblErrorPuesto
            // 
            this.lblErrorPuesto.AutoSize = true;
            this.lblErrorPuesto.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPuesto.Location = new System.Drawing.Point(44, 65);
            this.lblErrorPuesto.Name = "lblErrorPuesto";
            this.lblErrorPuesto.Size = new System.Drawing.Size(11, 13);
            this.lblErrorPuesto.TabIndex = 19;
            this.lblErrorPuesto.Text = "*";
            // 
            // lblErrorArea
            // 
            this.lblErrorArea.AutoSize = true;
            this.lblErrorArea.ForeColor = System.Drawing.Color.Red;
            this.lblErrorArea.Location = new System.Drawing.Point(35, 32);
            this.lblErrorArea.Name = "lblErrorArea";
            this.lblErrorArea.Size = new System.Drawing.Size(11, 13);
            this.lblErrorArea.TabIndex = 17;
            this.lblErrorArea.Text = "*";
            // 
            // lblPuestoAlta
            // 
            this.lblPuestoAlta.AutoSize = true;
            this.lblPuestoAlta.Location = new System.Drawing.Point(6, 70);
            this.lblPuestoAlta.Name = "lblPuestoAlta";
            this.lblPuestoAlta.Size = new System.Drawing.Size(43, 13);
            this.lblPuestoAlta.TabIndex = 16;
            this.lblPuestoAlta.Text = "Puesto:";
            // 
            // puestosAltas
            // 
            this.puestosAltas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.puestosAltas.FormattingEnabled = true;
            this.puestosAltas.Location = new System.Drawing.Point(76, 62);
            this.puestosAltas.Margin = new System.Windows.Forms.Padding(2);
            this.puestosAltas.Name = "puestosAltas";
            this.puestosAltas.Size = new System.Drawing.Size(157, 21);
            this.puestosAltas.TabIndex = 15;
            // 
            // buscarAlta
            // 
            this.buscarAlta.Location = new System.Drawing.Point(172, 156);
            this.buscarAlta.Margin = new System.Windows.Forms.Padding(2);
            this.buscarAlta.Name = "buscarAlta";
            this.buscarAlta.Size = new System.Drawing.Size(61, 26);
            this.buscarAlta.TabIndex = 13;
            this.buscarAlta.Text = "Buscar";
            this.buscarAlta.UseVisualStyleBackColor = true;
            this.buscarAlta.Click += new System.EventHandler(this.button1_Click);
            // 
            // cuilAltas
            // 
            this.cuilAltas.Location = new System.Drawing.Point(76, 108);
            this.cuilAltas.Margin = new System.Windows.Forms.Padding(2);
            this.cuilAltas.Name = "cuilAltas";
            this.cuilAltas.Size = new System.Drawing.Size(157, 20);
            this.cuilAltas.TabIndex = 14;
            // 
            // lblCuilAlta
            // 
            this.lblCuilAlta.AutoSize = true;
            this.lblCuilAlta.Location = new System.Drawing.Point(6, 115);
            this.lblCuilAlta.Name = "lblCuilAlta";
            this.lblCuilAlta.Size = new System.Drawing.Size(34, 13);
            this.lblCuilAlta.TabIndex = 13;
            this.lblCuilAlta.Text = "CUIL:";
            // 
            // lblAreaAlta
            // 
            this.lblAreaAlta.AutoSize = true;
            this.lblAreaAlta.Location = new System.Drawing.Point(6, 35);
            this.lblAreaAlta.Name = "lblAreaAlta";
            this.lblAreaAlta.Size = new System.Drawing.Size(32, 13);
            this.lblAreaAlta.TabIndex = 7;
            this.lblAreaAlta.Text = "Àrea:";
            // 
            // areasAltas
            // 
            this.areasAltas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.areasAltas.FormattingEnabled = true;
            this.areasAltas.Location = new System.Drawing.Point(76, 32);
            this.areasAltas.Margin = new System.Windows.Forms.Padding(2);
            this.areasAltas.Name = "areasAltas";
            this.areasAltas.Size = new System.Drawing.Size(157, 21);
            this.areasAltas.TabIndex = 9;
            this.areasAltas.SelectedIndexChanged += new System.EventHandler(this.areasAltas_SelectedIndexChanged);
            // 
            // tbpModificar
            // 
            this.tbpModificar.Controls.Add(this.grbInasistenciasMod);
            this.tbpModificar.Controls.Add(this.grbFiltroMod);
            this.tbpModificar.Location = new System.Drawing.Point(4, 22);
            this.tbpModificar.Name = "tbpModificar";
            this.tbpModificar.Padding = new System.Windows.Forms.Padding(2);
            this.tbpModificar.Size = new System.Drawing.Size(1094, 514);
            this.tbpModificar.TabIndex = 1;
            this.tbpModificar.Text = "Modificaciòn y consulta";
            this.tbpModificar.UseVisualStyleBackColor = true;
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(484, 321);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(96, 52);
            this.btnExcel.TabIndex = 14;
            this.btnExcel.Text = "Descargar Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // grbInasistenciasMod
            // 
            this.grbInasistenciasMod.Controls.Add(this.btnExcel);
            this.grbInasistenciasMod.Controls.Add(this.dataGridModificar);
            this.grbInasistenciasMod.Location = new System.Drawing.Point(303, 15);
            this.grbInasistenciasMod.Name = "grbInasistenciasMod";
            this.grbInasistenciasMod.Size = new System.Drawing.Size(782, 379);
            this.grbInasistenciasMod.TabIndex = 13;
            this.grbInasistenciasMod.TabStop = false;
            this.grbInasistenciasMod.Text = "Inasistencias";
            // 
            // dataGridModificar
            // 
            this.dataGridModificar.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridModificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridModificar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modificar});
            this.dataGridModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridModificar.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridModificar.Location = new System.Drawing.Point(2, 14);
            this.dataGridModificar.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridModificar.Name = "dataGridModificar";
            this.dataGridModificar.RowHeadersWidth = 51;
            this.dataGridModificar.RowTemplate.Height = 24;
            this.dataGridModificar.Size = new System.Drawing.Size(578, 287);
            this.dataGridModificar.TabIndex = 12;
            this.dataGridModificar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridModificar_CellContentClick);
            // 
            // Modificar
            // 
            this.Modificar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Modificar.HeaderText = "Modificar";
            this.Modificar.MinimumWidth = 6;
            this.Modificar.Name = "Modificar";
            this.Modificar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Modificar.Text = "Abrir";
            this.Modificar.ToolTipText = "Abrir";
            this.Modificar.UseColumnTextForButtonValue = true;
            this.Modificar.Width = 56;
            // 
            // grbFiltroMod
            // 
            this.grbFiltroMod.Controls.Add(this.periodo);
            this.grbFiltroMod.Controls.Add(this.lblErrorPuestoMod);
            this.grbFiltroMod.Controls.Add(this.lblErrorAreaMod);
            this.grbFiltroMod.Controls.Add(this.lblPuestoMod);
            this.grbFiltroMod.Controls.Add(this.PuestoMod);
            this.grbFiltroMod.Controls.Add(this.AreaMod);
            this.grbFiltroMod.Controls.Add(this.lblAreaMod);
            this.grbFiltroMod.Controls.Add(this.lblFechaMod);
            this.grbFiltroMod.Controls.Add(this.lblFechaDesdeMod);
            this.grbFiltroMod.Controls.Add(this.lblFechaHastaMod);
            this.grbFiltroMod.Controls.Add(this.FechaHastaMod);
            this.grbFiltroMod.Controls.Add(this.fechaDesdeMod);
            this.grbFiltroMod.Controls.Add(this.FechaMod);
            this.grbFiltroMod.Controls.Add(this.buscarMod);
            this.grbFiltroMod.Controls.Add(this.CuilMod);
            this.grbFiltroMod.Controls.Add(this.lblCuilMod);
            this.grbFiltroMod.Location = new System.Drawing.Point(7, 15);
            this.grbFiltroMod.Name = "grbFiltroMod";
            this.grbFiltroMod.Size = new System.Drawing.Size(290, 379);
            this.grbFiltroMod.TabIndex = 12;
            this.grbFiltroMod.TabStop = false;
            this.grbFiltroMod.Text = "Filtros";
            this.grbFiltroMod.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // periodo
            // 
            this.periodo.AutoSize = true;
            this.periodo.Location = new System.Drawing.Point(9, 128);
            this.periodo.Margin = new System.Windows.Forms.Padding(2);
            this.periodo.Name = "periodo";
            this.periodo.Size = new System.Drawing.Size(62, 17);
            this.periodo.TabIndex = 32;
            this.periodo.Text = "Periodo";
            this.periodo.UseVisualStyleBackColor = true;
            this.periodo.CheckedChanged += new System.EventHandler(this.periodo_CheckedChanged_1);
            // 
            // lblErrorPuestoMod
            // 
            this.lblErrorPuestoMod.AutoSize = true;
            this.lblErrorPuestoMod.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPuestoMod.Location = new System.Drawing.Point(45, 51);
            this.lblErrorPuestoMod.Name = "lblErrorPuestoMod";
            this.lblErrorPuestoMod.Size = new System.Drawing.Size(11, 13);
            this.lblErrorPuestoMod.TabIndex = 31;
            this.lblErrorPuestoMod.Text = "*";
            // 
            // lblErrorAreaMod
            // 
            this.lblErrorAreaMod.AutoSize = true;
            this.lblErrorAreaMod.ForeColor = System.Drawing.Color.Red;
            this.lblErrorAreaMod.Location = new System.Drawing.Point(32, 28);
            this.lblErrorAreaMod.Name = "lblErrorAreaMod";
            this.lblErrorAreaMod.Size = new System.Drawing.Size(11, 13);
            this.lblErrorAreaMod.TabIndex = 30;
            this.lblErrorAreaMod.Text = "*";
            // 
            // lblPuestoMod
            // 
            this.lblPuestoMod.AutoSize = true;
            this.lblPuestoMod.Location = new System.Drawing.Point(6, 58);
            this.lblPuestoMod.Name = "lblPuestoMod";
            this.lblPuestoMod.Size = new System.Drawing.Size(43, 13);
            this.lblPuestoMod.TabIndex = 28;
            this.lblPuestoMod.Text = "Puesto:";
            // 
            // PuestoMod
            // 
            this.PuestoMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PuestoMod.FormattingEnabled = true;
            this.PuestoMod.Location = new System.Drawing.Point(68, 59);
            this.PuestoMod.Margin = new System.Windows.Forms.Padding(2);
            this.PuestoMod.Name = "PuestoMod";
            this.PuestoMod.Size = new System.Drawing.Size(157, 21);
            this.PuestoMod.TabIndex = 27;
            // 
            // AreaMod
            // 
            this.AreaMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AreaMod.FormattingEnabled = true;
            this.AreaMod.Location = new System.Drawing.Point(68, 20);
            this.AreaMod.Margin = new System.Windows.Forms.Padding(2);
            this.AreaMod.Name = "AreaMod";
            this.AreaMod.Size = new System.Drawing.Size(157, 21);
            this.AreaMod.TabIndex = 26;
            this.AreaMod.SelectedIndexChanged += new System.EventHandler(this.AreaMod_SelectedIndexChanged);
            // 
            // lblAreaMod
            // 
            this.lblAreaMod.AutoSize = true;
            this.lblAreaMod.Location = new System.Drawing.Point(6, 34);
            this.lblAreaMod.Name = "lblAreaMod";
            this.lblAreaMod.Size = new System.Drawing.Size(32, 13);
            this.lblAreaMod.TabIndex = 25;
            this.lblAreaMod.Text = "Àrea:";
            // 
            // lblFechaMod
            // 
            this.lblFechaMod.AutoSize = true;
            this.lblFechaMod.Location = new System.Drawing.Point(6, 156);
            this.lblFechaMod.Name = "lblFechaMod";
            this.lblFechaMod.Size = new System.Drawing.Size(40, 13);
            this.lblFechaMod.TabIndex = 22;
            this.lblFechaMod.Text = "Fecha:";
            // 
            // lblFechaDesdeMod
            // 
            this.lblFechaDesdeMod.AutoSize = true;
            this.lblFechaDesdeMod.Location = new System.Drawing.Point(6, 193);
            this.lblFechaDesdeMod.Name = "lblFechaDesdeMod";
            this.lblFechaDesdeMod.Size = new System.Drawing.Size(72, 13);
            this.lblFechaDesdeMod.TabIndex = 21;
            this.lblFechaDesdeMod.Text = "Fecha desde:";
            // 
            // lblFechaHastaMod
            // 
            this.lblFechaHastaMod.AutoSize = true;
            this.lblFechaHastaMod.Location = new System.Drawing.Point(6, 234);
            this.lblFechaHastaMod.Name = "lblFechaHastaMod";
            this.lblFechaHastaMod.Size = new System.Drawing.Size(69, 13);
            this.lblFechaHastaMod.TabIndex = 20;
            this.lblFechaHastaMod.Text = "Fecha hasta:";
            // 
            // FechaHastaMod
            // 
            this.FechaHastaMod.Location = new System.Drawing.Point(83, 227);
            this.FechaHastaMod.Margin = new System.Windows.Forms.Padding(2);
            this.FechaHastaMod.Name = "FechaHastaMod";
            this.FechaHastaMod.Size = new System.Drawing.Size(157, 20);
            this.FechaHastaMod.TabIndex = 19;
            // 
            // fechaDesdeMod
            // 
            this.fechaDesdeMod.Location = new System.Drawing.Point(83, 187);
            this.fechaDesdeMod.Margin = new System.Windows.Forms.Padding(2);
            this.fechaDesdeMod.Name = "fechaDesdeMod";
            this.fechaDesdeMod.Size = new System.Drawing.Size(157, 20);
            this.fechaDesdeMod.TabIndex = 18;
            // 
            // FechaMod
            // 
            this.FechaMod.Location = new System.Drawing.Point(83, 150);
            this.FechaMod.Margin = new System.Windows.Forms.Padding(2);
            this.FechaMod.Name = "FechaMod";
            this.FechaMod.Size = new System.Drawing.Size(157, 20);
            this.FechaMod.TabIndex = 17;
            // 
            // buscarMod
            // 
            this.buscarMod.Location = new System.Drawing.Point(179, 275);
            this.buscarMod.Margin = new System.Windows.Forms.Padding(2);
            this.buscarMod.Name = "buscarMod";
            this.buscarMod.Size = new System.Drawing.Size(61, 26);
            this.buscarMod.TabIndex = 13;
            this.buscarMod.Text = "Buscar";
            this.buscarMod.UseVisualStyleBackColor = true;
            this.buscarMod.Click += new System.EventHandler(this.button2_Click);
            // 
            // CuilMod
            // 
            this.CuilMod.Location = new System.Drawing.Point(68, 96);
            this.CuilMod.Margin = new System.Windows.Forms.Padding(2);
            this.CuilMod.Name = "CuilMod";
            this.CuilMod.Size = new System.Drawing.Size(157, 20);
            this.CuilMod.TabIndex = 14;
            // 
            // lblCuilMod
            // 
            this.lblCuilMod.AutoSize = true;
            this.lblCuilMod.Location = new System.Drawing.Point(6, 99);
            this.lblCuilMod.Name = "lblCuilMod";
            this.lblCuilMod.Size = new System.Drawing.Size(34, 13);
            this.lblCuilMod.TabIndex = 13;
            this.lblCuilMod.Text = "CUIL:";
            // 
            // Asistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 540);
            this.Controls.Add(this.modiicacion);
            this.Name = "Asistencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asistencias";
            this.modiicacion.ResumeLayout(false);
            this.tbpAlta.ResumeLayout(false);
            this.grbPersonalAlta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlta)).EndInit();
            this.grbFiltrosAlta.ResumeLayout(false);
            this.grbFiltrosAlta.PerformLayout();
            this.tbpModificar.ResumeLayout(false);
            this.grbInasistenciasMod.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridModificar)).EndInit();
            this.grbFiltroMod.ResumeLayout(false);
            this.grbFiltroMod.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl modiicacion;
        private System.Windows.Forms.TabPage tbpAlta;
        private System.Windows.Forms.GroupBox grbPersonalAlta;
        private System.Windows.Forms.DataGridView dataGridAlta;
        private System.Windows.Forms.GroupBox grbFiltrosAlta;
        private System.Windows.Forms.Button buscarAlta;
        private System.Windows.Forms.TextBox cuilAltas;
        private System.Windows.Forms.Label lblCuilAlta;
        private System.Windows.Forms.Label lblAreaAlta;
        private System.Windows.Forms.ComboBox areasAltas;
        private System.Windows.Forms.TabPage tbpModificar;
        private System.Windows.Forms.GroupBox grbInasistenciasMod;
        private System.Windows.Forms.DataGridView dataGridModificar;
        private System.Windows.Forms.GroupBox grbFiltroMod;
        private System.Windows.Forms.Label lblFechaMod;
        private System.Windows.Forms.Label lblFechaDesdeMod;
        private System.Windows.Forms.Label lblFechaHastaMod;
        private System.Windows.Forms.DateTimePicker FechaHastaMod;
        private System.Windows.Forms.DateTimePicker fechaDesdeMod;
        private System.Windows.Forms.DateTimePicker FechaMod;
        private System.Windows.Forms.Button buscarMod;
        private System.Windows.Forms.TextBox CuilMod;
        private System.Windows.Forms.Label lblCuilMod;
        private System.Windows.Forms.Label lblPuestoAlta;
        private System.Windows.Forms.ComboBox puestosAltas;
        private System.Windows.Forms.Label lblPuestoMod;
        private System.Windows.Forms.ComboBox PuestoMod;
        private System.Windows.Forms.ComboBox AreaMod;
        private System.Windows.Forms.Label lblAreaMod;
        private System.Windows.Forms.DataGridViewButtonColumn Abrir;
        private System.Windows.Forms.Label lblErrorPuesto;
        private System.Windows.Forms.Label lblErrorArea;
        private System.Windows.Forms.Label lblErrorPuestoMod;
        private System.Windows.Forms.Label lblErrorAreaMod;
        private System.Windows.Forms.CheckBox periodo;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.Button btnExcel;
    }
}