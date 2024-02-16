﻿namespace Vista
{
    partial class ConfigPoliticasPass
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
            this.chcChar = new System.Windows.Forms.CheckBox();
            this.chcMay = new System.Windows.Forms.CheckBox();
            this.chcNum = new System.Windows.Forms.CheckBox();
            this.chcEsp = new System.Windows.Forms.CheckBox();
            this.chcPass = new System.Windows.Forms.CheckBox();
            this.chcDatos = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCrearBakup = new System.Windows.Forms.Button();
            this.btnCargarBakup = new System.Windows.Forms.Button();
            this.opnBakup = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // chcChar
            // 
            this.chcChar.AutoSize = true;
            this.chcChar.Location = new System.Drawing.Point(196, 60);
            this.chcChar.Margin = new System.Windows.Forms.Padding(2);
            this.chcChar.Name = "chcChar";
            this.chcChar.Size = new System.Drawing.Size(138, 17);
            this.chcChar.TabIndex = 0;
            this.chcChar.Text = "minimo de 8 caracteres.";
            this.chcChar.UseVisualStyleBackColor = true;
            this.chcChar.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chcMay
            // 
            this.chcMay.AutoSize = true;
            this.chcMay.Location = new System.Drawing.Point(196, 101);
            this.chcMay.Margin = new System.Windows.Forms.Padding(2);
            this.chcMay.Name = "chcMay";
            this.chcMay.Size = new System.Drawing.Size(226, 17);
            this.chcMay.TabIndex = 1;
            this.chcMay.Text = "Combinación de minúsculas y mayúsculas.";
            this.chcMay.UseVisualStyleBackColor = true;
            // 
            // chcNum
            // 
            this.chcNum.AutoSize = true;
            this.chcNum.Location = new System.Drawing.Point(196, 139);
            this.chcNum.Margin = new System.Windows.Forms.Padding(2);
            this.chcNum.Name = "chcNum";
            this.chcNum.Size = new System.Drawing.Size(151, 17);
            this.chcNum.TabIndex = 2;
            this.chcNum.Text = "Contener números y letras.";
            this.chcNum.UseVisualStyleBackColor = true;
            // 
            // chcEsp
            // 
            this.chcEsp.AutoSize = true;
            this.chcEsp.Location = new System.Drawing.Point(196, 175);
            this.chcEsp.Margin = new System.Windows.Forms.Padding(2);
            this.chcEsp.Name = "chcEsp";
            this.chcEsp.Size = new System.Drawing.Size(216, 17);
            this.chcEsp.TabIndex = 3;
            this.chcEsp.Text = "Contener al menos un caracter especial.";
            this.chcEsp.UseVisualStyleBackColor = true;
            // 
            // chcPass
            // 
            this.chcPass.AutoSize = true;
            this.chcPass.Location = new System.Drawing.Point(196, 216);
            this.chcPass.Margin = new System.Windows.Forms.Padding(2);
            this.chcPass.Name = "chcPass";
            this.chcPass.Size = new System.Drawing.Size(205, 17);
            this.chcPass.TabIndex = 4;
            this.chcPass.Text = "Permitir repetir contraseñas anteriores.";
            this.chcPass.UseVisualStyleBackColor = true;
            // 
            // chcDatos
            // 
            this.chcDatos.AutoSize = true;
            this.chcDatos.Location = new System.Drawing.Point(196, 257);
            this.chcDatos.Margin = new System.Windows.Forms.Padding(2);
            this.chcDatos.Name = "chcDatos";
            this.chcDatos.Size = new System.Drawing.Size(210, 17);
            this.chcDatos.TabIndex = 5;
            this.chcDatos.Text = "Verificar no contener datos personales.";
            this.chcDatos.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(113)))), ((int)(((byte)(141)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(496, 316);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(76, 31);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCrearBakup
            // 
            this.btnCrearBakup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(113)))), ((int)(((byte)(141)))));
            this.btnCrearBakup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrearBakup.ForeColor = System.Drawing.Color.White;
            this.btnCrearBakup.Location = new System.Drawing.Point(23, 268);
            this.btnCrearBakup.Name = "btnCrearBakup";
            this.btnCrearBakup.Size = new System.Drawing.Size(115, 31);
            this.btnCrearBakup.TabIndex = 7;
            this.btnCrearBakup.Text = "Crear Bakup";
            this.btnCrearBakup.UseVisualStyleBackColor = false;
            this.btnCrearBakup.Click += new System.EventHandler(this.btnCrearBakup_Click);
            // 
            // btnCargarBakup
            // 
            this.btnCargarBakup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(113)))), ((int)(((byte)(141)))));
            this.btnCargarBakup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCargarBakup.ForeColor = System.Drawing.Color.White;
            this.btnCargarBakup.Location = new System.Drawing.Point(23, 316);
            this.btnCargarBakup.Name = "btnCargarBakup";
            this.btnCargarBakup.Size = new System.Drawing.Size(115, 31);
            this.btnCargarBakup.TabIndex = 8;
            this.btnCargarBakup.Text = "Cargar Bakup";
            this.btnCargarBakup.UseVisualStyleBackColor = false;
            this.btnCargarBakup.Click += new System.EventHandler(this.btnCargarBakup_Click);
            // 
            // opnBakup
            // 
            this.opnBakup.Filter = "*.bak|";
            // 
            // ConfigPoliticasPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnCargarBakup);
            this.Controls.Add(this.btnCrearBakup);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.chcDatos);
            this.Controls.Add(this.chcPass);
            this.Controls.Add(this.chcEsp);
            this.Controls.Add(this.chcNum);
            this.Controls.Add(this.chcMay);
            this.Controls.Add(this.chcChar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ConfigPoliticasPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Politicas de contraseñas";
            this.Load += new System.EventHandler(this.ConfigPoliticasPass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chcChar;
        private System.Windows.Forms.CheckBox chcMay;
        private System.Windows.Forms.CheckBox chcNum;
        private System.Windows.Forms.CheckBox chcEsp;
        private System.Windows.Forms.CheckBox chcPass;
        private System.Windows.Forms.CheckBox chcDatos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCrearBakup;
        private System.Windows.Forms.Button btnCargarBakup;
        private System.Windows.Forms.OpenFileDialog opnBakup;
    }
}