namespace Vista.Gestion_de_Talento
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
            this.tabPreocupacional = new System.Windows.Forms.TabPage();
            this.lblEstadoPreocup = new System.Windows.Forms.Label();
            this.cmbEstadoPreocupacional = new System.Windows.Forms.ComboBox();
            this.lblPatologias = new System.Windows.Forms.Label();
            this.btnGuardarP = new System.Windows.Forms.Button();
            this.lblFechaPreocup = new System.Windows.Forms.Label();
            this.dtpPreocupacional = new System.Windows.Forms.DateTimePicker();
            this.rchPatologias = new System.Windows.Forms.RichTextBox();
            this.grpCandidatoPreocup = new System.Windows.Forms.GroupBox();
            this.lblNombApellidoCandidato = new System.Windows.Forms.Label();
            this.lblNombreApellidoP = new System.Windows.Forms.Label();
            this.lblPuestoCandidatoP = new System.Windows.Forms.Label();
            this.lblPuestoP = new System.Windows.Forms.Label();
            this.tabEtapas = new System.Windows.Forms.TabControl();
            this.tabPreocupacional.SuspendLayout();
            this.grpCandidatoPreocup.SuspendLayout();
            this.tabEtapas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPreocupacional
            // 
            this.tabPreocupacional.Controls.Add(this.grpCandidatoPreocup);
            this.tabPreocupacional.Controls.Add(this.rchPatologias);
            this.tabPreocupacional.Controls.Add(this.dtpPreocupacional);
            this.tabPreocupacional.Controls.Add(this.lblFechaPreocup);
            this.tabPreocupacional.Controls.Add(this.btnGuardarP);
            this.tabPreocupacional.Controls.Add(this.lblPatologias);
            this.tabPreocupacional.Controls.Add(this.cmbEstadoPreocupacional);
            this.tabPreocupacional.Controls.Add(this.lblEstadoPreocup);
            this.tabPreocupacional.Location = new System.Drawing.Point(4, 25);
            this.tabPreocupacional.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPreocupacional.Name = "tabPreocupacional";
            this.tabPreocupacional.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPreocupacional.Size = new System.Drawing.Size(728, 421);
            this.tabPreocupacional.TabIndex = 1;
            this.tabPreocupacional.Text = "Preocupacional";
            this.tabPreocupacional.UseVisualStyleBackColor = true;
            // 
            // lblEstadoPreocup
            // 
            this.lblEstadoPreocup.AutoSize = true;
            this.lblEstadoPreocup.Location = new System.Drawing.Point(124, 198);
            this.lblEstadoPreocup.Name = "lblEstadoPreocup";
            this.lblEstadoPreocup.Size = new System.Drawing.Size(173, 16);
            this.lblEstadoPreocup.TabIndex = 14;
            this.lblEstadoPreocup.Text = "Estado del Preocupacional:";
            // 
            // cmbEstadoPreocupacional
            // 
            this.cmbEstadoPreocupacional.FormattingEnabled = true;
            this.cmbEstadoPreocupacional.Location = new System.Drawing.Point(380, 194);
            this.cmbEstadoPreocupacional.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEstadoPreocupacional.Name = "cmbEstadoPreocupacional";
            this.cmbEstadoPreocupacional.Size = new System.Drawing.Size(200, 24);
            this.cmbEstadoPreocupacional.TabIndex = 15;
            this.cmbEstadoPreocupacional.DropDown += new System.EventHandler(this.cmbEstadoPreocupacional_DropDown);
            // 
            // lblPatologias
            // 
            this.lblPatologias.AutoSize = true;
            this.lblPatologias.Location = new System.Drawing.Point(124, 244);
            this.lblPatologias.Name = "lblPatologias";
            this.lblPatologias.Size = new System.Drawing.Size(138, 16);
            this.lblPatologias.TabIndex = 17;
            this.lblPatologias.Text = "Patologías existentes:";
            // 
            // btnGuardarP
            // 
            this.btnGuardarP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(87)))), ((int)(((byte)(125)))));
            this.btnGuardarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGuardarP.Location = new System.Drawing.Point(616, 366);
            this.btnGuardarP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarP.Name = "btnGuardarP";
            this.btnGuardarP.Size = new System.Drawing.Size(96, 34);
            this.btnGuardarP.TabIndex = 19;
            this.btnGuardarP.Text = "Guardar";
            this.btnGuardarP.UseVisualStyleBackColor = false;
            this.btnGuardarP.Click += new System.EventHandler(this.btnGuardarP_Click);
            // 
            // lblFechaPreocup
            // 
            this.lblFechaPreocup.Location = new System.Drawing.Point(124, 150);
            this.lblFechaPreocup.Name = "lblFechaPreocup";
            this.lblFechaPreocup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFechaPreocup.Size = new System.Drawing.Size(231, 25);
            this.lblFechaPreocup.TabIndex = 25;
            this.lblFechaPreocup.Text = "Fecha programada del examen:";
            // 
            // dtpPreocupacional
            // 
            this.dtpPreocupacional.Location = new System.Drawing.Point(380, 146);
            this.dtpPreocupacional.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpPreocupacional.Name = "dtpPreocupacional";
            this.dtpPreocupacional.Size = new System.Drawing.Size(200, 22);
            this.dtpPreocupacional.TabIndex = 26;
            this.dtpPreocupacional.ValueChanged += new System.EventHandler(this.dtpPreocupacional_ValueChanged);
            // 
            // rchPatologias
            // 
            this.rchPatologias.Location = new System.Drawing.Point(380, 241);
            this.rchPatologias.Margin = new System.Windows.Forms.Padding(4);
            this.rchPatologias.Name = "rchPatologias";
            this.rchPatologias.Size = new System.Drawing.Size(200, 105);
            this.rchPatologias.TabIndex = 27;
            this.rchPatologias.Text = "";
            // 
            // grpCandidatoPreocup
            // 
            this.grpCandidatoPreocup.Controls.Add(this.lblPuestoP);
            this.grpCandidatoPreocup.Controls.Add(this.lblPuestoCandidatoP);
            this.grpCandidatoPreocup.Controls.Add(this.lblNombreApellidoP);
            this.grpCandidatoPreocup.Controls.Add(this.lblNombApellidoCandidato);
            this.grpCandidatoPreocup.Location = new System.Drawing.Point(15, 38);
            this.grpCandidatoPreocup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCandidatoPreocup.Name = "grpCandidatoPreocup";
            this.grpCandidatoPreocup.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCandidatoPreocup.Size = new System.Drawing.Size(697, 69);
            this.grpCandidatoPreocup.TabIndex = 33;
            this.grpCandidatoPreocup.TabStop = false;
            this.grpCandidatoPreocup.Text = "Datos del candidato";
            // 
            // lblNombApellidoCandidato
            // 
            this.lblNombApellidoCandidato.AutoSize = true;
            this.lblNombApellidoCandidato.Location = new System.Drawing.Point(105, 30);
            this.lblNombApellidoCandidato.Name = "lblNombApellidoCandidato";
            this.lblNombApellidoCandidato.Size = new System.Drawing.Size(122, 16);
            this.lblNombApellidoCandidato.TabIndex = 1;
            this.lblNombApellidoCandidato.Text = "Nombre y Apellido:";
            // 
            // lblNombreApellidoP
            // 
            this.lblNombreApellidoP.AutoSize = true;
            this.lblNombreApellidoP.Location = new System.Drawing.Point(229, 30);
            this.lblNombreApellidoP.Name = "lblNombreApellidoP";
            this.lblNombreApellidoP.Size = new System.Drawing.Size(0, 16);
            this.lblNombreApellidoP.TabIndex = 2;
            // 
            // lblPuestoCandidatoP
            // 
            this.lblPuestoCandidatoP.AutoSize = true;
            this.lblPuestoCandidatoP.Location = new System.Drawing.Point(443, 30);
            this.lblPuestoCandidatoP.Name = "lblPuestoCandidatoP";
            this.lblPuestoCandidatoP.Size = new System.Drawing.Size(52, 16);
            this.lblPuestoCandidatoP.TabIndex = 5;
            this.lblPuestoCandidatoP.Text = "Puesto:";
            // 
            // lblPuestoP
            // 
            this.lblPuestoP.AutoSize = true;
            this.lblPuestoP.Location = new System.Drawing.Point(496, 30);
            this.lblPuestoP.Name = "lblPuestoP";
            this.lblPuestoP.Size = new System.Drawing.Size(0, 16);
            this.lblPuestoP.TabIndex = 6;
            // 
            // tabEtapas
            // 
            this.tabEtapas.AccessibleName = "";
            this.tabEtapas.Controls.Add(this.tabPreocupacional);
            this.tabEtapas.Location = new System.Drawing.Point(27, 12);
            this.tabEtapas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabEtapas.Name = "tabEtapas";
            this.tabEtapas.SelectedIndex = 0;
            this.tabEtapas.Size = new System.Drawing.Size(736, 450);
            this.tabEtapas.TabIndex = 0;
            this.tabEtapas.SelectedIndexChanged += new System.EventHandler(this.tabEtapas_SelectedIndexChanged);
            this.tabEtapas.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabEtapas_Selecting);
            // 
            // frmEntrevistaPreocupacionalCapacitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 482);
            this.Controls.Add(this.tabEtapas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmEntrevistaPreocupacionalCapacitacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etapas del proceso de seleccion";
            this.Load += new System.EventHandler(this.frmEntrevistaPreocupacionalCapacitacion_Load);
            this.tabPreocupacional.ResumeLayout(false);
            this.tabPreocupacional.PerformLayout();
            this.grpCandidatoPreocup.ResumeLayout(false);
            this.grpCandidatoPreocup.PerformLayout();
            this.tabEtapas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPreocupacional;
        private System.Windows.Forms.GroupBox grpCandidatoPreocup;
        private System.Windows.Forms.Label lblPuestoP;
        private System.Windows.Forms.Label lblPuestoCandidatoP;
        private System.Windows.Forms.Label lblNombreApellidoP;
        private System.Windows.Forms.Label lblNombApellidoCandidato;
        private System.Windows.Forms.RichTextBox rchPatologias;
        private System.Windows.Forms.DateTimePicker dtpPreocupacional;
        private System.Windows.Forms.Label lblFechaPreocup;
        private System.Windows.Forms.Button btnGuardarP;
        private System.Windows.Forms.Label lblPatologias;
        private System.Windows.Forms.ComboBox cmbEstadoPreocupacional;
        private System.Windows.Forms.Label lblEstadoPreocup;
        private System.Windows.Forms.TabControl tabEtapas;
    }
}