namespace Vista
{
    partial class frmPuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPuesto));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancelarModificar = new System.Windows.Forms.Button();
            this.btnGuardarModificar = new System.Windows.Forms.Button();
            this.txtPuestoModificar = new System.Windows.Forms.TextBox();
            this.lblPuestoModificar = new System.Windows.Forms.Label();
            this.btnBaja = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelarCrear = new System.Windows.Forms.Button();
            this.btnGuardarCrear = new System.Windows.Forms.Button();
            this.txtPuestoCrear = new System.Windows.Forms.TextBox();
            this.lblPuestoCrear = new System.Windows.Forms.Label();
            this.lstPuestos = new System.Windows.Forms.ListBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.btnCancelarModificar);
            this.groupBox2.Controls.Add(this.btnGuardarModificar);
            this.groupBox2.Controls.Add(this.txtPuestoModificar);
            this.groupBox2.Controls.Add(this.lblPuestoModificar);
            this.groupBox2.Location = new System.Drawing.Point(310, 177);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(266, 112);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modificar Puesto";
            // 
            // btnCancelarModificar
            // 
            this.btnCancelarModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(87)))), ((int)(((byte)(125)))));
            this.btnCancelarModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancelarModificar.Location = new System.Drawing.Point(4, 82);
            this.btnCancelarModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelarModificar.Name = "btnCancelarModificar";
            this.btnCancelarModificar.Size = new System.Drawing.Size(78, 25);
            this.btnCancelarModificar.TabIndex = 3;
            this.btnCancelarModificar.Text = "Cancelar";
            this.btnCancelarModificar.UseVisualStyleBackColor = false;
            this.btnCancelarModificar.Click += new System.EventHandler(this.btnCancelarModificar_Click);
            // 
            // btnGuardarModificar
            // 
            this.btnGuardarModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(87)))), ((int)(((byte)(125)))));
            this.btnGuardarModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGuardarModificar.Location = new System.Drawing.Point(190, 82);
            this.btnGuardarModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarModificar.Name = "btnGuardarModificar";
            this.btnGuardarModificar.Size = new System.Drawing.Size(72, 25);
            this.btnGuardarModificar.TabIndex = 2;
            this.btnGuardarModificar.Text = "Guardar";
            this.btnGuardarModificar.UseVisualStyleBackColor = false;
            this.btnGuardarModificar.Click += new System.EventHandler(this.btnGuardarModificar_Click);
            // 
            // txtPuestoModificar
            // 
            this.txtPuestoModificar.Location = new System.Drawing.Point(65, 41);
            this.txtPuestoModificar.Margin = new System.Windows.Forms.Padding(2);
            this.txtPuestoModificar.Name = "txtPuestoModificar";
            this.txtPuestoModificar.Size = new System.Drawing.Size(177, 20);
            this.txtPuestoModificar.TabIndex = 1;
            this.txtPuestoModificar.TextChanged += new System.EventHandler(this.txtPuestoModificar_TextChanged);
            // 
            // lblPuestoModificar
            // 
            this.lblPuestoModificar.AutoSize = true;
            this.lblPuestoModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuestoModificar.Location = new System.Drawing.Point(17, 44);
            this.lblPuestoModificar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPuestoModificar.Name = "lblPuestoModificar";
            this.lblPuestoModificar.Size = new System.Drawing.Size(45, 15);
            this.lblPuestoModificar.TabIndex = 0;
            this.lblPuestoModificar.Text = "Puesto";
            // 
            // btnBaja
            // 
            this.btnBaja.BackColor = System.Drawing.Color.Navy;
            this.btnBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBaja.Location = new System.Drawing.Point(198, 306);
            this.btnBaja.Margin = new System.Windows.Forms.Padding(2);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(88, 27);
            this.btnBaja.TabIndex = 14;
            this.btnBaja.Text = "Dar de Baja";
            this.btnBaja.UseVisualStyleBackColor = false;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.btnCancelarCrear);
            this.groupBox1.Controls.Add(this.btnGuardarCrear);
            this.groupBox1.Controls.Add(this.txtPuestoCrear);
            this.groupBox1.Controls.Add(this.lblPuestoCrear);
            this.groupBox1.Location = new System.Drawing.Point(306, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(266, 112);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear Puesto";
            // 
            // btnCancelarCrear
            // 
            this.btnCancelarCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(87)))), ((int)(((byte)(125)))));
            this.btnCancelarCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCrear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancelarCrear.Location = new System.Drawing.Point(4, 82);
            this.btnCancelarCrear.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelarCrear.Name = "btnCancelarCrear";
            this.btnCancelarCrear.Size = new System.Drawing.Size(78, 25);
            this.btnCancelarCrear.TabIndex = 3;
            this.btnCancelarCrear.Text = "Cancelar";
            this.btnCancelarCrear.UseVisualStyleBackColor = false;
            this.btnCancelarCrear.Click += new System.EventHandler(this.btnCancelarCrear_Click);
            // 
            // btnGuardarCrear
            // 
            this.btnGuardarCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(87)))), ((int)(((byte)(125)))));
            this.btnGuardarCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCrear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGuardarCrear.Location = new System.Drawing.Point(190, 82);
            this.btnGuardarCrear.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarCrear.Name = "btnGuardarCrear";
            this.btnGuardarCrear.Size = new System.Drawing.Size(72, 25);
            this.btnGuardarCrear.TabIndex = 2;
            this.btnGuardarCrear.Text = "Guardar";
            this.btnGuardarCrear.UseVisualStyleBackColor = false;
            this.btnGuardarCrear.Click += new System.EventHandler(this.btnGuardarCrear_Click);
            // 
            // txtPuestoCrear
            // 
            this.txtPuestoCrear.Location = new System.Drawing.Point(65, 41);
            this.txtPuestoCrear.Margin = new System.Windows.Forms.Padding(2);
            this.txtPuestoCrear.Name = "txtPuestoCrear";
            this.txtPuestoCrear.Size = new System.Drawing.Size(177, 20);
            this.txtPuestoCrear.TabIndex = 1;
            this.txtPuestoCrear.TextChanged += new System.EventHandler(this.txtPuestoCrear_TextChanged);
            // 
            // lblPuestoCrear
            // 
            this.lblPuestoCrear.AutoSize = true;
            this.lblPuestoCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuestoCrear.Location = new System.Drawing.Point(17, 44);
            this.lblPuestoCrear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPuestoCrear.Name = "lblPuestoCrear";
            this.lblPuestoCrear.Size = new System.Drawing.Size(45, 15);
            this.lblPuestoCrear.TabIndex = 0;
            this.lblPuestoCrear.Text = "Puesto";
            // 
            // lstPuestos
            // 
            this.lstPuestos.FormattingEnabled = true;
            this.lstPuestos.Location = new System.Drawing.Point(34, 37);
            this.lstPuestos.Margin = new System.Windows.Forms.Padding(2);
            this.lstPuestos.Name = "lstPuestos";
            this.lstPuestos.Size = new System.Drawing.Size(253, 264);
            this.lstPuestos.TabIndex = 11;
            this.lstPuestos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstPuestos_MouseDoubleClick);
            // 
            // frmPuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.fondo_pared_textura_blanca2;
            this.ClientSize = new System.Drawing.Size(607, 359);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstPuestos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPuesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPuesto";
            this.Load += new System.EventHandler(this.frmPuesto_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancelarModificar;
        private System.Windows.Forms.Button btnGuardarModificar;
        private System.Windows.Forms.TextBox txtPuestoModificar;
        private System.Windows.Forms.Label lblPuestoModificar;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelarCrear;
        private System.Windows.Forms.Button btnGuardarCrear;
        private System.Windows.Forms.TextBox txtPuestoCrear;
        private System.Windows.Forms.Label lblPuestoCrear;
        private System.Windows.Forms.ListBox lstPuestos;
    }
}