﻿namespace Vista.Gestion_de_Talento
{
    partial class frmEntrevistaPreocupacionalCapacitacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntrevistaPreocupacionalCapacitacion));
            this.tabEtapas = new System.Windows.Forms.TabControl();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tabEtapas
            // 
            this.tabEtapas.AccessibleName = "";
            this.tabEtapas.Location = new System.Drawing.Point(27, 51);
            this.tabEtapas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabEtapas.Name = "tabEtapas";
            this.tabEtapas.SelectedIndex = 0;
            this.tabEtapas.Size = new System.Drawing.Size(736, 450);
            this.tabEtapas.TabIndex = 0;
            this.tabEtapas.SelectedIndexChanged += new System.EventHandler(this.tabEtapas_SelectedIndexChanged);
            this.tabEtapas.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabEtapas_Selecting);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(27, 23);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 1;
            this.btnAnterior.Text = "<-";
            this.btnAnterior.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(688, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "->";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmEntrevistaPreocupacionalCapacitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 517);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.tabEtapas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmEntrevistaPreocupacionalCapacitacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etapas del proceso de seleccion";
            this.Load += new System.EventHandler(this.frmEntrevistaPreocupacionalCapacitacion_Load);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.TabControl tabEtapas;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button button1;
    }
}