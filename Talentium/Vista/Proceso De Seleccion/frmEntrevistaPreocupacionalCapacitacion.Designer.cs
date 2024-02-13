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
            this.tabEtapas = new System.Windows.Forms.TabControl();
            this.SuspendLayout();
            // 
            // tabEtapas
            // 
            this.tabEtapas.AccessibleName = "";
            this.tabEtapas.Location = new System.Drawing.Point(20, 10);
            this.tabEtapas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabEtapas.Name = "tabEtapas";
            this.tabEtapas.SelectedIndex = 0;
            this.tabEtapas.Size = new System.Drawing.Size(552, 366);
            this.tabEtapas.TabIndex = 0;
            this.tabEtapas.SelectedIndexChanged += new System.EventHandler(this.tabEtapas_SelectedIndexChanged);
            this.tabEtapas.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabEtapas_Selecting);
            // 
            // frmEntrevistaPreocupacionalCapacitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 392);
            this.Controls.Add(this.tabEtapas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmEntrevistaPreocupacionalCapacitacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etapas del proceso de seleccion";
            this.Load += new System.EventHandler(this.frmEntrevistaPreocupacionalCapacitacion_Load);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.TabControl tabEtapas;
    }
}