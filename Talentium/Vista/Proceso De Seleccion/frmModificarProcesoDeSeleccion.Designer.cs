namespace Vista
{
    partial class frmModificarProcesoDeSeleccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificarProcesoDeSeleccion));
            this.lblCuil = new System.Windows.Forms.Label();
            this.lblCuilCuit = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpModificar = new System.Windows.Forms.GroupBox();
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cmbPartido = new System.Windows.Forms.ComboBox();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.txtDpto = new System.Windows.Forms.TextBox();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.txtNro = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtAlternativo = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDpto = new System.Windows.Forms.Label();
            this.lblPiso = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblPartido = new System.Windows.Forms.Label();
            this.cmbPuesto = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblNro = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grpModificar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCuil
            // 
            this.lblCuil.AutoSize = true;
            this.lblCuil.Location = new System.Drawing.Point(118, 26);
            this.lblCuil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCuil.Name = "lblCuil";
            this.lblCuil.Size = new System.Drawing.Size(79, 13);
            this.lblCuil.TabIndex = 11;
            this.lblCuil.Text = "20-39999999-1";
            // 
            // lblCuilCuit
            // 
            this.lblCuilCuit.AutoSize = true;
            this.lblCuilCuit.Location = new System.Drawing.Point(40, 26);
            this.lblCuilCuit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCuilCuit.Name = "lblCuilCuit";
            this.lblCuilCuit.Size = new System.Drawing.Size(64, 13);
            this.lblCuilCuit.TabIndex = 9;
            this.lblCuilCuit.Text = "CUIL/CUIT:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(87)))), ((int)(((byte)(125)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancelar.Location = new System.Drawing.Point(32, 287);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(73, 30);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // grpModificar
            // 
            this.grpModificar.BackColor = System.Drawing.SystemColors.Control;
            this.grpModificar.Controls.Add(this.cmbLocalidad);
            this.grpModificar.Controls.Add(this.dtpNacimiento);
            this.grpModificar.Controls.Add(this.cmbPartido);
            this.grpModificar.Controls.Add(this.cmbProvincia);
            this.grpModificar.Controls.Add(this.txtDpto);
            this.grpModificar.Controls.Add(this.txtPiso);
            this.grpModificar.Controls.Add(this.txtNro);
            this.grpModificar.Controls.Add(this.txtCalle);
            this.grpModificar.Controls.Add(this.txtCorreo);
            this.grpModificar.Controls.Add(this.txtAlternativo);
            this.grpModificar.Controls.Add(this.txtCelular);
            this.grpModificar.Controls.Add(this.txtApellido);
            this.grpModificar.Controls.Add(this.txtNombre);
            this.grpModificar.Controls.Add(this.lblDpto);
            this.grpModificar.Controls.Add(this.lblPiso);
            this.grpModificar.Controls.Add(this.lblLocalidad);
            this.grpModificar.Controls.Add(this.lblPartido);
            this.grpModificar.Controls.Add(this.cmbPuesto);
            this.grpModificar.Controls.Add(this.label13);
            this.grpModificar.Controls.Add(this.lblNro);
            this.grpModificar.Controls.Add(this.label10);
            this.grpModificar.Controls.Add(this.lblProvincia);
            this.grpModificar.Controls.Add(this.label7);
            this.grpModificar.Controls.Add(this.label6);
            this.grpModificar.Controls.Add(this.label5);
            this.grpModificar.Controls.Add(this.label4);
            this.grpModificar.Controls.Add(this.label3);
            this.grpModificar.Controls.Add(this.label8);
            this.grpModificar.Location = new System.Drawing.Point(32, 64);
            this.grpModificar.Margin = new System.Windows.Forms.Padding(2);
            this.grpModificar.Name = "grpModificar";
            this.grpModificar.Padding = new System.Windows.Forms.Padding(2);
            this.grpModificar.Size = new System.Drawing.Size(529, 211);
            this.grpModificar.TabIndex = 24;
            this.grpModificar.TabStop = false;
            this.grpModificar.Text = "Modificar candidato";
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.BackColor = System.Drawing.SystemColors.Window;
            this.cmbLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(399, 82);
            this.cmbLocalidad.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(93, 21);
            this.cmbLocalidad.TabIndex = 52;
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Location = new System.Drawing.Point(141, 173);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(93, 20);
            this.dtpNacimiento.TabIndex = 46;
            // 
            // cmbPartido
            // 
            this.cmbPartido.BackColor = System.Drawing.SystemColors.Window;
            this.cmbPartido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPartido.FormattingEnabled = true;
            this.cmbPartido.Location = new System.Drawing.Point(399, 51);
            this.cmbPartido.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPartido.Name = "cmbPartido";
            this.cmbPartido.Size = new System.Drawing.Size(93, 21);
            this.cmbPartido.TabIndex = 51;
            this.cmbPartido.SelectedIndexChanged += new System.EventHandler(this.cmbPartido_SelectedIndexChanged);
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.BackColor = System.Drawing.SystemColors.Window;
            this.cmbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Location = new System.Drawing.Point(399, 19);
            this.cmbProvincia.Margin = new System.Windows.Forms.Padding(2);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(93, 21);
            this.cmbProvincia.TabIndex = 50;
            this.cmbProvincia.DropDown += new System.EventHandler(this.cmbProvincia_DropDown);
            this.cmbProvincia.SelectedIndexChanged += new System.EventHandler(this.cmbProvincia_SelectedIndexChanged);
            // 
            // txtDpto
            // 
            this.txtDpto.Location = new System.Drawing.Point(467, 142);
            this.txtDpto.Name = "txtDpto";
            this.txtDpto.Size = new System.Drawing.Size(24, 20);
            this.txtDpto.TabIndex = 45;
            // 
            // txtPiso
            // 
            this.txtPiso.Location = new System.Drawing.Point(399, 142);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(24, 20);
            this.txtPiso.TabIndex = 44;
            // 
            // txtNro
            // 
            this.txtNro.Location = new System.Drawing.Point(321, 142);
            this.txtNro.Name = "txtNro";
            this.txtNro.Size = new System.Drawing.Size(33, 20);
            this.txtNro.TabIndex = 43;
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(399, 112);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(93, 20);
            this.txtCalle.TabIndex = 42;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(141, 142);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(93, 20);
            this.txtCorreo.TabIndex = 37;
            // 
            // txtAlternativo
            // 
            this.txtAlternativo.Location = new System.Drawing.Point(141, 113);
            this.txtAlternativo.Name = "txtAlternativo";
            this.txtAlternativo.Size = new System.Drawing.Size(93, 20);
            this.txtAlternativo.TabIndex = 36;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(141, 82);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(93, 20);
            this.txtCelular.TabIndex = 35;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(141, 52);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(93, 20);
            this.txtApellido.TabIndex = 34;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(141, 21);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(93, 20);
            this.txtNombre.TabIndex = 33;
            // 
            // lblDpto
            // 
            this.lblDpto.AutoSize = true;
            this.lblDpto.Location = new System.Drawing.Point(432, 145);
            this.lblDpto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDpto.Name = "lblDpto";
            this.lblDpto.Size = new System.Drawing.Size(30, 13);
            this.lblDpto.TabIndex = 31;
            this.lblDpto.Text = "Dpto";
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Location = new System.Drawing.Point(366, 145);
            this.lblPiso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(27, 13);
            this.lblPiso.TabIndex = 29;
            this.lblPiso.Text = "Piso";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(297, 85);
            this.lblLocalidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(53, 13);
            this.lblLocalidad.TabIndex = 27;
            this.lblLocalidad.Text = "Localidad";
            // 
            // lblPartido
            // 
            this.lblPartido.AutoSize = true;
            this.lblPartido.Location = new System.Drawing.Point(297, 54);
            this.lblPartido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPartido.Name = "lblPartido";
            this.lblPartido.Size = new System.Drawing.Size(40, 13);
            this.lblPartido.TabIndex = 25;
            this.lblPartido.Text = "Partido";
            // 
            // cmbPuesto
            // 
            this.cmbPuesto.BackColor = System.Drawing.SystemColors.Window;
            this.cmbPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPuesto.FormattingEnabled = true;
            this.cmbPuesto.Location = new System.Drawing.Point(399, 173);
            this.cmbPuesto.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPuesto.Name = "cmbPuesto";
            this.cmbPuesto.Size = new System.Drawing.Size(93, 21);
            this.cmbPuesto.TabIndex = 24;
            this.cmbPuesto.DropDown += new System.EventHandler(this.cmbPuesto_DropDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(297, 175);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Puesto a postularse";
            // 
            // lblNro
            // 
            this.lblNro.AutoSize = true;
            this.lblNro.Location = new System.Drawing.Point(297, 145);
            this.lblNro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNro.Name = "lblNro";
            this.lblNro.Size = new System.Drawing.Size(19, 13);
            this.lblNro.TabIndex = 9;
            this.lblNro.Text = "N°";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(297, 115);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Calle";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(297, 23);
            this.lblProvincia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(51, 13);
            this.lblProvincia.TabIndex = 6;
            this.lblProvincia.Text = "Provincia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 175);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Fecha de nacimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 145);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Correo electrónico";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Teléfono alternativo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Teléfono celular";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Apellido/s";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 23);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nombre/s";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(87)))), ((int)(((byte)(125)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Location = new System.Drawing.Point(488, 287);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 30);
            this.button1.TabIndex = 25;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmModificarProcesoDeSeleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 338);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grpModificar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCuil);
            this.Controls.Add(this.lblCuilCuit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmModificarProcesoDeSeleccion";
            this.Text = "Modificar Candidato en Proceso de Seleccion";
            this.Load += new System.EventHandler(this.frmModificarProcesoDeSeleccion_Load);
            this.grpModificar.ResumeLayout(false);
            this.grpModificar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCuil;
        private System.Windows.Forms.Label lblCuilCuit;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox grpModificar;
        private System.Windows.Forms.TextBox txtDpto;
        private System.Windows.Forms.TextBox txtPiso;
        private System.Windows.Forms.TextBox txtNro;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtAlternativo;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDpto;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblPartido;
        private System.Windows.Forms.ComboBox cmbPuesto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblNro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.ComboBox cmbLocalidad;
        private System.Windows.Forms.ComboBox cmbPartido;
        private System.Windows.Forms.ComboBox cmbProvincia;
    }
}