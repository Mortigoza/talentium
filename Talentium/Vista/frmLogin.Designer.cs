﻿namespace Vista
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titulo = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblSesion = new System.Windows.Forms.Label();
            this.lnkRecupero = new System.Windows.Forms.LinkLabel();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.cmbLenguaje = new System.Windows.Forms.ComboBox();
            this.lblLenguaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(83, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 157);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.Color.Transparent;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(72, 272);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(314, 73);
            this.titulo.TabIndex = 1;
            this.titulo.Text = "Talentium";
            // 
            // txtUsername
            // 
            this.txtUsername.AccessibleName = "Usuario";
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUsername.Location = new System.Drawing.Point(423, 170);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(252, 30);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.AccessibleName = "Contraseña";
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassword.Location = new System.Drawing.Point(422, 219);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(252, 30);
            this.txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(87)))), ((int)(((byte)(125)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(67)))), ((int)(((byte)(128)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLogin.Location = new System.Drawing.Point(422, 262);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(252, 30);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Ingresar";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblSesion
            // 
            this.lblSesion.BackColor = System.Drawing.Color.Transparent;
            this.lblSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSesion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSesion.Location = new System.Drawing.Point(422, 128);
            this.lblSesion.Name = "lblSesion";
            this.lblSesion.Size = new System.Drawing.Size(252, 24);
            this.lblSesion.TabIndex = 5;
            this.lblSesion.Text = "Iniciar sesión";
            this.lblSesion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lnkRecupero
            // 
            this.lnkRecupero.BackColor = System.Drawing.Color.Transparent;
            this.lnkRecupero.LinkColor = System.Drawing.Color.DodgerBlue;
            this.lnkRecupero.Location = new System.Drawing.Point(423, 307);
            this.lnkRecupero.Name = "lnkRecupero";
            this.lnkRecupero.Size = new System.Drawing.Size(252, 23);
            this.lnkRecupero.TabIndex = 6;
            this.lnkRecupero.TabStop = true;
            this.lnkRecupero.Text = "Recuperar contraseña";
            this.lnkRecupero.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkRecupero.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.Transparent;
            this.btnMostrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMostrar.BackgroundImage")));
            this.btnMostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMostrar.FlatAppearance.BorderSize = 0;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Location = new System.Drawing.Point(680, 219);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(30, 30);
            this.btnMostrar.TabIndex = 7;
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.btnMostrar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMostrar_MouseUp);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUsuario.Location = new System.Drawing.Point(419, 154);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 8;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.BackColor = System.Drawing.Color.Transparent;
            this.lblContrasenia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblContrasenia.Location = new System.Drawing.Point(419, 203);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(61, 13);
            this.lblContrasenia.TabIndex = 9;
            this.lblContrasenia.Text = "Contraseña";
            // 
            // cmbLenguaje
            // 
            this.cmbLenguaje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLenguaje.FormattingEnabled = true;
            this.cmbLenguaje.Location = new System.Drawing.Point(638, 12);
            this.cmbLenguaje.Name = "cmbLenguaje";
            this.cmbLenguaje.Size = new System.Drawing.Size(121, 21);
            this.cmbLenguaje.TabIndex = 10;
            this.cmbLenguaje.SelectionChangeCommitted += new System.EventHandler(this.cmbLenguaje_SelectionChangeCommitted);
            // 
            // lblLenguaje
            // 
            this.lblLenguaje.BackColor = System.Drawing.Color.Transparent;
            this.lblLenguaje.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLenguaje.Location = new System.Drawing.Point(504, 12);
            this.lblLenguaje.Name = "lblLenguaje";
            this.lblLenguaje.Size = new System.Drawing.Size(128, 21);
            this.lblLenguaje.TabIndex = 11;
            this.lblLenguaje.Text = "Lenguaje";
            this.lblLenguaje.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(771, 471);
            this.Controls.Add(this.lblLenguaje);
            this.Controls.Add(this.cmbLenguaje);
            this.Controls.Add(this.lblContrasenia);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.lnkRecupero);
            this.Controls.Add(this.lblSesion);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.titulo);
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Talentium - Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblSesion;
        private System.Windows.Forms.LinkLabel lnkRecupero;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.ComboBox cmbLenguaje;
        private System.Windows.Forms.Label lblLenguaje;
    }
}

