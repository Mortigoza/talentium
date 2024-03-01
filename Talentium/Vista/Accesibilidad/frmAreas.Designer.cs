namespace Vista
{
    partial class frmAreas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAreas));
            this.lstAreas = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelarCrear = new System.Windows.Forms.Button();
            this.btnGuardarCrear = new System.Windows.Forms.Button();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancelarModificar = new System.Windows.Forms.Button();
            this.btnGuardarModificar = new System.Windows.Forms.Button();
            this.txtModifArea = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBaja = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstAreas
            // 
            this.lstAreas.FormattingEnabled = true;
            this.lstAreas.ItemHeight = 16;
            this.lstAreas.Location = new System.Drawing.Point(40, 50);
            this.lstAreas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstAreas.Name = "lstAreas";
            this.lstAreas.Size = new System.Drawing.Size(336, 324);
            this.lstAreas.TabIndex = 0;
            this.lstAreas.SelectedIndexChanged += new System.EventHandler(this.Áreas_SelectedIndexChanged);
            this.lstAreas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstAreas_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.btnCancelarCrear);
            this.groupBox1.Controls.Add(this.btnGuardarCrear);
            this.groupBox1.Controls.Add(this.txtArea);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(403, 66);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(355, 138);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear Área";
            // 
            // btnCancelarCrear
            // 
            this.btnCancelarCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(113)))), ((int)(((byte)(141)))));
            this.btnCancelarCrear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCrear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelarCrear.Location = new System.Drawing.Point(5, 101);
            this.btnCancelarCrear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarCrear.Name = "btnCancelarCrear";
            this.btnCancelarCrear.Size = new System.Drawing.Size(104, 31);
            this.btnCancelarCrear.TabIndex = 3;
            this.btnCancelarCrear.Text = "Cancelar";
            this.btnCancelarCrear.UseVisualStyleBackColor = false;
            this.btnCancelarCrear.Click += new System.EventHandler(this.btnCancelarCrear_Click);
            // 
            // btnGuardarCrear
            // 
            this.btnGuardarCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(113)))), ((int)(((byte)(141)))));
            this.btnGuardarCrear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCrear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardarCrear.Location = new System.Drawing.Point(253, 101);
            this.btnGuardarCrear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarCrear.Name = "btnGuardarCrear";
            this.btnGuardarCrear.Size = new System.Drawing.Size(96, 31);
            this.btnGuardarCrear.TabIndex = 2;
            this.btnGuardarCrear.Text = "Guardar";
            this.btnGuardarCrear.UseVisualStyleBackColor = false;
            this.btnGuardarCrear.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(81, 50);
            this.txtArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(235, 22);
            this.txtArea.TabIndex = 1;
            this.txtArea.TextChanged += new System.EventHandler(this.txtArea_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Área";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.btnCancelarModificar);
            this.groupBox2.Controls.Add(this.btnGuardarModificar);
            this.groupBox2.Controls.Add(this.txtModifArea);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(403, 222);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(355, 138);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modificar Área";
            // 
            // btnCancelarModificar
            // 
            this.btnCancelarModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(113)))), ((int)(((byte)(141)))));
            this.btnCancelarModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarModificar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelarModificar.Location = new System.Drawing.Point(5, 100);
            this.btnCancelarModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarModificar.Name = "btnCancelarModificar";
            this.btnCancelarModificar.Size = new System.Drawing.Size(104, 31);
            this.btnCancelarModificar.TabIndex = 5;
            this.btnCancelarModificar.Text = "Cancelar";
            this.btnCancelarModificar.UseVisualStyleBackColor = false;
            this.btnCancelarModificar.Click += new System.EventHandler(this.btnCancelarModificar_Click);
            // 
            // btnGuardarModificar
            // 
            this.btnGuardarModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(113)))), ((int)(((byte)(141)))));
            this.btnGuardarModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarModificar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardarModificar.Location = new System.Drawing.Point(253, 100);
            this.btnGuardarModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarModificar.Name = "btnGuardarModificar";
            this.btnGuardarModificar.Size = new System.Drawing.Size(96, 31);
            this.btnGuardarModificar.TabIndex = 4;
            this.btnGuardarModificar.Text = "Guardar";
            this.btnGuardarModificar.UseVisualStyleBackColor = false;
            this.btnGuardarModificar.Click += new System.EventHandler(this.btnGuardarModificar_Click);
            // 
            // txtModifArea
            // 
            this.txtModifArea.Location = new System.Drawing.Point(81, 48);
            this.txtModifArea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtModifArea.Name = "txtModifArea";
            this.txtModifArea.Size = new System.Drawing.Size(235, 22);
            this.txtModifArea.TabIndex = 3;
            this.txtModifArea.TextChanged += new System.EventHandler(this.txtModifArea_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Área";
            // 
            // btnBaja
            // 
            this.btnBaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(113)))), ((int)(((byte)(141)))));
            this.btnBaja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaja.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBaja.Location = new System.Drawing.Point(259, 382);
            this.btnBaja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(117, 33);
            this.btnBaja.TabIndex = 6;
            this.btnBaja.Text = "Dar de Baja";
            this.btnBaja.UseVisualStyleBackColor = false;
            this.btnBaja.Click += new System.EventHandler(this.button5_Click);
            // 
            // frmAreas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstAreas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAreas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Areas";
            this.Load += new System.EventHandler(this.frmAreas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstAreas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuardarCrear;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtModifArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelarCrear;
        private System.Windows.Forms.Button btnCancelarModificar;
        private System.Windows.Forms.Button btnGuardarModificar;
        private System.Windows.Forms.Button btnBaja;
    }
}