﻿namespace Vista
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titulo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administraciónDelPersonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDelTalentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearEvaluacionDeDesempenioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeAsistenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nóminaSalarialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.análisisYReportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.certificacionDeServiciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accesibilidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.áreasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asistenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(313, 123);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(432, 229);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // titulo
            // 
            this.titulo.BackColor = System.Drawing.Color.Transparent;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.Color.SteelBlue;
            this.titulo.Location = new System.Drawing.Point(235, 337);
            this.titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(600, 118);
            this.titulo.TabIndex = 19;
            this.titulo.Text = "Talentium";
            this.titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administraciónDelPersonalToolStripMenuItem,
            this.gestiónDelTalentoToolStripMenuItem,
            this.gestiónDeAsistenciasToolStripMenuItem,
            this.nóminaSalarialToolStripMenuItem,
            this.análisisYReportesToolStripMenuItem,
            this.accesibilidadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administraciónDelPersonalToolStripMenuItem
            // 
            this.administraciónDelPersonalToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.administraciónDelPersonalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altasToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.bajasToolStripMenuItem,
            this.consultarToolStripMenuItem});
            this.administraciónDelPersonalToolStripMenuItem.Name = "administraciónDelPersonalToolStripMenuItem";
            this.administraciónDelPersonalToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.administraciónDelPersonalToolStripMenuItem.Text = "Administración del Personal";
            // 
            // altasToolStripMenuItem
            // 
            this.altasToolStripMenuItem.Name = "altasToolStripMenuItem";
            this.altasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.altasToolStripMenuItem.Text = "Altas";
            this.altasToolStripMenuItem.Click += new System.EventHandler(this.altasToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // bajasToolStripMenuItem
            // 
            this.bajasToolStripMenuItem.Name = "bajasToolStripMenuItem";
            this.bajasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bajasToolStripMenuItem.Text = "Bajas";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // gestiónDelTalentoToolStripMenuItem
            // 
            this.gestiónDelTalentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearEvaluacionDeDesempenioToolStripMenuItem});
            this.gestiónDelTalentoToolStripMenuItem.Name = "gestiónDelTalentoToolStripMenuItem";
            this.gestiónDelTalentoToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.gestiónDelTalentoToolStripMenuItem.Text = "Gestión del Talento";
            // 
            // crearEvaluacionDeDesempenioToolStripMenuItem
            // 
            this.crearEvaluacionDeDesempenioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem,
            this.consultarToolStripMenuItem1});
            this.crearEvaluacionDeDesempenioToolStripMenuItem.Name = "crearEvaluacionDeDesempenioToolStripMenuItem";
            this.crearEvaluacionDeDesempenioToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.crearEvaluacionDeDesempenioToolStripMenuItem.Text = "Evaluación de Desempeño";
            this.crearEvaluacionDeDesempenioToolStripMenuItem.Click += new System.EventHandler(this.crearEvaluacionDeDesempenioToolStripMenuItem_Click);
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.crearToolStripMenuItem.Text = "Crear";
            this.crearToolStripMenuItem.Click += new System.EventHandler(this.crearToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem1
            // 
            this.consultarToolStripMenuItem1.Name = "consultarToolStripMenuItem1";
            this.consultarToolStripMenuItem1.Size = new System.Drawing.Size(154, 26);
            this.consultarToolStripMenuItem1.Text = "Consultar";
            this.consultarToolStripMenuItem1.Click += new System.EventHandler(this.consultarToolStripMenuItem1_Click);
            // 
            // gestiónDeAsistenciasToolStripMenuItem
            // 
            this.gestiónDeAsistenciasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asistenciasToolStripMenuItem});
            this.gestiónDeAsistenciasToolStripMenuItem.Name = "gestiónDeAsistenciasToolStripMenuItem";
            this.gestiónDeAsistenciasToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.gestiónDeAsistenciasToolStripMenuItem.Text = "Gestión de Asistencias";
            // 
            // nóminaSalarialToolStripMenuItem
            // 
            this.nóminaSalarialToolStripMenuItem.Name = "nóminaSalarialToolStripMenuItem";
            this.nóminaSalarialToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.nóminaSalarialToolStripMenuItem.Text = "Nómina Salarial";
            // 
            // análisisYReportesToolStripMenuItem
            // 
            this.análisisYReportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.certificacionDeServiciosToolStripMenuItem});
            this.análisisYReportesToolStripMenuItem.Name = "análisisYReportesToolStripMenuItem";
            this.análisisYReportesToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.análisisYReportesToolStripMenuItem.Text = "Análisis y Reportes";
            // 
            // certificacionDeServiciosToolStripMenuItem
            // 
            this.certificacionDeServiciosToolStripMenuItem.Name = "certificacionDeServiciosToolStripMenuItem";
            this.certificacionDeServiciosToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.certificacionDeServiciosToolStripMenuItem.Text = "Certificacion de servicios";
            this.certificacionDeServiciosToolStripMenuItem.Click += new System.EventHandler(this.certificacionDeServiciosToolStripMenuItem_Click);
            // 
            // accesibilidadToolStripMenuItem
            // 
            this.accesibilidadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.áreasToolStripMenuItem,
            this.puestosToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.perfilesToolStripMenuItem});
            this.accesibilidadToolStripMenuItem.Name = "accesibilidadToolStripMenuItem";
            this.accesibilidadToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.accesibilidadToolStripMenuItem.Text = "Accesibilidad";
            // 
            // áreasToolStripMenuItem
            // 
            this.áreasToolStripMenuItem.Name = "áreasToolStripMenuItem";
            this.áreasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.áreasToolStripMenuItem.Text = "Áreas";
            this.áreasToolStripMenuItem.Click += new System.EventHandler(this.áreasToolStripMenuItem_Click);
            // 
            // puestosToolStripMenuItem
            // 
            this.puestosToolStripMenuItem.Name = "puestosToolStripMenuItem";
            this.puestosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.puestosToolStripMenuItem.Text = "Puestos";
            this.puestosToolStripMenuItem.Click += new System.EventHandler(this.puestosToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // perfilesToolStripMenuItem
            // 
            this.perfilesToolStripMenuItem.Name = "perfilesToolStripMenuItem";
            this.perfilesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.perfilesToolStripMenuItem.Text = "Perfiles";
            this.perfilesToolStripMenuItem.Click += new System.EventHandler(this.perfilesToolStripMenuItem_Click);
            // 
            // asistenciasToolStripMenuItem
            // 
            this.asistenciasToolStripMenuItem.Name = "asistenciasToolStripMenuItem";
            this.asistenciasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.asistenciasToolStripMenuItem.Text = "Asistencias";
            this.asistenciasToolStripMenuItem.Click += new System.EventHandler(this.asistenciasToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administraciónDelPersonalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDelTalentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeAsistenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nóminaSalarialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem análisisYReportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accesibilidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem áreasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puestosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearEvaluacionDeDesempenioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem certificacionDeServiciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asistenciasToolStripMenuItem;
    }
}