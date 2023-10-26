using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comun;
using LogicaNegocio.Administracion_Del_Personal;
using LogicaNegocio;


namespace Vista
{
    public partial class frmAltaPersonal : Form
    {
        CN_AdministracionPersonalComboBox logica= new CN_AdministracionPersonalComboBox();

        CN_AdministracionDatosPersonal logicaPersona = new CN_AdministracionDatosPersonal();


        private bool inicial = true;
        private int infoLaborales = 0;
        private int infoAcademicos = 1;


        

        public frmAltaPersonal()
        {
            InitializeComponent();
          
            DeshabilitarCampos();
            lblFaltanLlenarCampos.Visible = false;


        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            grbSuperior.Visible = true;
            infoAcademicos++;
            button1.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            grbSuperior.Visible = false;
            infoAcademicos--;
            button1.Visible = true;
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            grbExp1.Visible = true;
            button18.Visible = false;
            infoLaborales++;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            grbExp1.Visible = false;
            button18.Visible = true;
            infoLaborales--;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            grbExp2.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            grbExp2.Visible = false;
            button10.Visible = true;
            infoLaborales--;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            grbExp3.Visible = true;
            button12.Visible =false;
            infoLaborales++;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            grbExp3.Visible = false;
            button12.Visible =true;
            infoLaborales--;
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            grbExp2.Visible = true;
            button10.Visible = false;
            infoLaborales++;
        }

        private void btbValidarCuil(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtCuitCuil.Text))
            {
                MessageBox.Show("El campo no puede estar vacío.");
            }
            else
            {
                // Verificar si la entrada contiene solo números y tiene exactamente 11 dígitos
                if (EsNumero(txtCuitCuil.Text))
                {
                    if (txtCuitCuil.Text.Length == 11)
                    {
                        bool valor = logicaPersona.ValidarCuit(txtCuitCuil.Text.Trim());
                        if (valor)
                        {
                            DeshabilitarCampos();
                            MessageBox.Show("El Cuit/Cuil ya esta asociado a un empleado");

                        }
                        else
                        {
                            MessageBox.Show("Cuil Disponible");
                            HabilitarCampos();
                            txtCuitCuil.Enabled = false;

                        }
                    }
                    else
                    {
                        DeshabilitarCampos();
                        MessageBox.Show("El campo debe contener 11 digitos.");
                    }
                }
                else
                {
                    DeshabilitarCampos();
                    MessageBox.Show("La entrada debe contener solamente numeros.");
                }
            }
        }

        private bool EsNumero(string input )
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                {
                    return false; // La cadena contiene caracteres que no son números
                }
            }
            return true; // La cadena contiene solo números
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void frmAltaPersonal_Load(object sender, EventArgs e)
        {
            tabControl.TabPages[1].Enabled = false;
            tabControl.TabPages[2].Enabled = false;
            

            DataTable provincia = logica.ObtenerProvincia();
            cmbProvincia.DataSource = provincia;
            cmbProvincia.DisplayMember = "provincia";
            cmbProvincia.ValueMember = "id_provincia";
            cmbProvincia.SelectedIndex = -1;

            DataTable genero = logica.ObtenerGenero();
            cmbGenero.DataSource = genero;
            cmbGenero.DisplayMember = "genero";
            cmbGenero.ValueMember = "id_genero";
            cmbGenero.SelectedIndex = -1;

            DataTable tipotel = logica.ObtenerTipoTel();
            cmbTipoTelAlternativo.DataSource = tipotel;
            cmbTipoTelAlternativo.DisplayMember = "tipo";
            cmbTipoTelAlternativo.ValueMember = "id_tipo";
            cmbTipoTelAlternativo.SelectedIndex = -1;
            cmbTipoTel.DataSource = tipotel.Copy();
            cmbTipoTel.DisplayMember = "tipo";
            cmbTipoTel.ValueMember = "id_tipo";
            cmbTipoTel.SelectedIndex = -1;

            DataTable estadocivil = logica.ObtenerEstadoCivil();
            cmbEstadoCivil.DataSource = estadocivil;
            cmbEstadoCivil.DisplayMember = "estado_civil";
            cmbEstadoCivil.ValueMember = "id_estado_civil";
            cmbEstadoCivil.SelectedIndex = -1;


            DataTable nacionalidad = logica.ObtenerNacionalidad();
            cmbNacionalidad.DataSource = nacionalidad;
            cmbNacionalidad.DisplayMember = "nacionalidad";
            cmbNacionalidad.ValueMember = "id_nacionalidad";
            cmbNacionalidad.SelectedIndex = -1;

            DataTable tipodoc = logica.ObtenerTipoDoc();
            cmbTipoDoc.DataSource = tipodoc;
            cmbTipoDoc.DisplayMember = "tipo_doc";
            cmbTipoDoc.ValueMember = "id_tipo_doc";
            cmbTipoDoc.SelectedIndex = -1;

            cmbPartido.SelectedIndex = -1;

            DataTable progreso = logica.ObtenerProgreso();
            cmbProgreso.DataSource = progreso;
            cmbProgreso.DisplayMember = "estado_progreso";
            cmbProgreso.ValueMember = "id_progreso";
            //cmbProgreso.SelectedIndex = -1;
            cmbProgreso1.DataSource = progreso.Copy();
            cmbProgreso1.DisplayMember = "estado_progreso";
            cmbProgreso1.ValueMember = "id_progreso";
            //cmbProgreso.SelectedIndex = -1;
            cmbProgreso2.DataSource = progreso.Copy();
            cmbProgreso2.DisplayMember = "estado_progreso";
            cmbProgreso2.ValueMember = "id_progreso";
            //cmbProgreso1.SelectedIndex = -1;

            DataTable convenio = logica.ObtenerConvenio();
            cmbConvenio.DataSource = convenio;
            cmbConvenio.DisplayMember = "convenio";
            cmbConvenio.ValueMember = "id_convenio";
            cmbConvenio.SelectedIndex = -1;

            DataTable puesto = logica.ObtenerPuesto();
            cmbPuesto.DataSource = puesto;
            cmbPuesto.DisplayMember = "puesto";
            cmbPuesto.ValueMember = "id_puesto";
            cmbPuesto.SelectedIndex = -1;

            DataTable area = logica.ObtenerArea();
            cmbArea.DataSource = area;
            cmbArea.DisplayMember = "area";
            cmbArea.ValueMember = "id_area";
            cmbArea.SelectedIndex = -1;


            //ComboBox Solapa Academico*************

            // Agrega los años desde 1900 hasta el año actual a la lista
            int anioActual = DateTime.Now.Year;
            List<string> listaDeAnios = new List<string>();

            for (int i = anioActual; i >= 1900; i--)
            {
                listaDeAnios.Add(i.ToString());
            }
            // Selecciona el ComboBox en el cual se cargan los años
            cmbIngreso.Items.AddRange(listaDeAnios.ToArray());
            cmbIngreso1.Items.AddRange(listaDeAnios.ToArray());
            cmbIngreso2.Items.AddRange(listaDeAnios.ToArray());
            cmbEgreso.Items.AddRange(listaDeAnios.ToArray());
            cmbEgreso1.Items.AddRange(listaDeAnios.ToArray());
            cmbEgreso2.Items.AddRange(listaDeAnios.ToArray());

            cmbIngreso.SelectedIndex = 0;
            cmbIngreso1.SelectedIndex = 0;
            cmbIngreso2.SelectedIndex = 0;
            cmbEgreso.SelectedIndex = 0;
            cmbEgreso1.SelectedIndex = 0;
            cmbEgreso2.SelectedIndex = 0;

            DataTable nivelacademico = logica.ObtenerNivelAcademico();
            cmbNivelAcademico.DataSource = nivelacademico;
            cmbNivelAcademico.DisplayMember = "nivel";
            cmbNivelAcademico.ValueMember = "id_nivel";

            cmbNivelAcademico1.DataSource = nivelacademico.Copy();
            cmbNivelAcademico1.DisplayMember = "nivel";
            cmbNivelAcademico1.ValueMember = "id_nivel";
        
            cmbNivelAcademico2.DataSource = nivelacademico.Copy();
            cmbNivelAcademico2.DisplayMember = "nivel";
            cmbNivelAcademico2.ValueMember = "id_nivel";
          


            //ComboBox Solapa Laboral
            cmbLaboralIngreso.Items.AddRange(listaDeAnios.ToArray());
            cmbLaboralEgreso.Items.AddRange(listaDeAnios.ToArray());
            cmbLaboralIngreso1.Items.AddRange(listaDeAnios.ToArray());
            cmbLaboralEgreso1.Items.AddRange(listaDeAnios.ToArray());
            cmbLaboralIngreso2.Items.AddRange(listaDeAnios.ToArray());
            cmbLaboralEgreso2.Items.AddRange(listaDeAnios.ToArray());
            cmbLaboralIngreso3.Items.AddRange(listaDeAnios.ToArray());
            cmbLaboralEgreso3.Items.AddRange(listaDeAnios.ToArray());

            cmbLaboralIngreso.SelectedIndex = 0;
            cmbLaboralEgreso.SelectedIndex = 0;
            cmbLaboralIngreso1.SelectedIndex = 0;
            cmbLaboralEgreso1.SelectedIndex = 0;
            cmbLaboralIngreso2.SelectedIndex = 0;
            cmbLaboralEgreso2.SelectedIndex = 0;
            cmbLaboralIngreso3.SelectedIndex = 0;
            cmbLaboralEgreso3.SelectedIndex = 0;


        }

        private void grbExp3_Enter(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
           
  
            if (validarTodos())
            {
                #region Mapeo
                Persona insert = new Persona();
             
                if (pctFoto.Image != null)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    pctFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    insert.foto_perfil = ms.GetBuffer();
                }
                else
                {
                    insert.foto_perfil = new byte[0];
                }
               

               


                insert.apellidos = txtApellidos.Text;
                insert.nombres = txtNombres.Text;
                insert.id_tipo_doc = int.Parse(cmbTipoDoc.SelectedValue.ToString());
                insert.nro_doc = txtDni.Text;
                insert.cuit_cuil = txtCuitCuil.Text;
                insert.calle = txtCalle.Text;
                insert.nro = txtNro.Text.Length;
                insert.dpto = txtDpto.Text;
                insert.piso = txtPiso.Text;
                insert.id_localidad = int.Parse(cmbLocalidad.SelectedValue.ToString());
                insert.id_puesto = int.Parse(cmbPuesto.SelectedValue.ToString());
                insert.id_area = int.Parse(cmbArea.SelectedValue.ToString());
                insert.email = txtEmail.Text;
                insert.id_nacionalidad = int.Parse(cmbNacionalidad.SelectedValue.ToString());
                insert.id_genero = int.Parse(cmbGenero.SelectedValue.ToString());
                insert.fecha_nacimiento = dtpFechaDeNacimiento.Value;
                insert.id_estado_civil = int.Parse(cmbEstadoCivil.SelectedValue.ToString());
                insert.hijos = (int)nupHijos.Value;
                insert.id_convenio = int.Parse(cmbConvenio.SelectedValue.ToString());
                
                insert.telefono = txtTelefono.Text;
                insert.id_tipo = (int)cmbTipoTel.SelectedValue;
                insert.telefono_alternativo = txtTelefonoAlternativo.Text;
                insert.id_tipo_alternativo = (int)cmbTipoTelAlternativo.SelectedValue;
                insert.contacto = txtContacto.Text;


                //ACADEMICOS
                insert.id_nivel1 = (int)cmbNivelAcademico.SelectedValue;
                insert.id_nivel2 = (int)cmbNivelAcademico1.SelectedValue;
                insert.id_nivel3 = (int)cmbNivelAcademico2.SelectedValue;
                insert.institucion1 = txtInsitutcionSuperior.Text;
                insert.institucion2 = txtInsitutcionSuperior1.Text;
                insert.institucion3 = txtInsitutcionSuperior2.Text;
                insert.carrera1 = txtTitulo.Text;
                insert.carrera2 = txtTitulo1.Text;
                insert.carrera3 = txtTitulo2.Text;
                insert.año_ingreso1 = int.Parse(cmbIngreso.SelectedItem.ToString());
                insert.año_ingreso2 = int.Parse(cmbIngreso1.SelectedItem.ToString());
                insert.año_ingreso3 = int.Parse(cmbIngreso2.SelectedItem.ToString());
                insert.año_egreso1 = int.Parse(cmbEgreso.SelectedItem.ToString());
                insert.año_egreso2 = int.Parse(cmbEgreso1.SelectedItem.ToString());
                insert.año_egreso3 = int.Parse(cmbEgreso2.SelectedItem.ToString());
                insert.titulo1 = txtTitulo.Text;
                insert.titulo2 = txtTitulo1.Text;
                insert.titulo3 = txtTitulo2.Text;
                insert.id_progreso1 = int.Parse(cmbProgreso.SelectedValue.ToString());
                insert.id_progreso2 = int.Parse(cmbProgreso1.SelectedValue.ToString());
                insert.id_progreso3 = int.Parse(cmbProgreso2.SelectedValue.ToString());


                //LABORAL

                insert.puesto1 = txtPuesto.Text;
                insert.puesto2 = txtPuesto1.Text;
                insert.puesto3 = txtPuesto2.Text;
                insert.puesto4 = txtPuesto3.Text;
                insert.empresa1 = txtEmpresa.Text;
                insert.empresa2 = txtEmpresa1.Text;
                insert.empresa3 = txtEmpresa2.Text;
                insert.empresa4 = txtEmpresa3.Text;
                insert.fecha_ingreso1 = int.Parse(cmbLaboralIngreso.SelectedItem.ToString());
                insert.fecha_ingreso2 = int.Parse(cmbLaboralIngreso1.SelectedItem.ToString());
                insert.fecha_ingreso3 = int.Parse(cmbLaboralIngreso2.SelectedItem.ToString());
                insert.fecha_ingreso4 = int.Parse(cmbLaboralIngreso3.SelectedItem.ToString());
                insert.fecha_egreso1 = int.Parse(cmbLaboralEgreso.SelectedItem.ToString());
                insert.fecha_egreso2 = int.Parse(cmbLaboralEgreso1.SelectedItem.ToString());
                insert.fecha_egreso3 = int.Parse(cmbLaboralEgreso2.SelectedItem.ToString());
                insert.fecha_egreso4 = int.Parse(cmbLaboralEgreso3.SelectedItem.ToString());
                insert.personal_a_cargo1 = (int)nupPersonalACargo.Value;
                insert.personal_a_cargo2 = (int)nupPersonalACargo1.Value;
                insert.personal_a_cargo3 = (int)nupPersonalACargo2.Value;
                insert.personal_a_cargo4 = (int)nupPersonalACargo3.Value;
                #endregion
                logicaPersona.InsertarPersona(insert, infoLaborales, infoAcademicos);
                MessageBox.Show("Valido");
            }
            else
            {
                MessageBox.Show("Faltan llenar campos obligatorios");
            }
   
        }
    
        private void button8_Click(object sender, EventArgs e)
        {
           if( validarVacios(tabAcademicos, infoAcademicos))
            {
                tabControl.TabPages[2].Enabled = true;
                RestaurarColorPredeterminado(tabAcademicos);
                MessageBox.Show("Todos los campos obligatorios estan completos");
                tabControl.SelectedTab = tabLaborales;
            }
            else
            {
                MessageBox.Show("Faltan campos obligatorios");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            if (validarVacios(tabPersonales))
            {
               
                tabControl.TabPages[1].Enabled = true;
                RestaurarColorPredeterminado(tabPersonales);
                MessageBox.Show("Todos los campos obligatorios estan completos");
                tabControl.SelectedTab = tabAcademicos;
            }
            else
            {
                MessageBox.Show("Faltan campos obligatorios");
            }
        }

        private void RestaurarColorPredeterminado(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is GroupBox)
                {
                    RestaurarColorPredeterminado((GroupBox)c);
                }
                if (c is TextBox)
                {
                    if (string.IsNullOrEmpty(c.Text))
                    {
                        errorProvider1.SetError(c,""); // Limpia el mensaje de error
                    }
                }
            }
        }

        private bool validarVacios(Control control, int count = -1)
        {
            bool todosCompletos = true;
            foreach (Control c in control.Controls)
            {
                if (c is GroupBox grp)
                {
                    if (!validarVacios(grp, count))
                    {
                        todosCompletos = false;
                    }
                }
                if (c is TextBox txt &&
                    !string.IsNullOrEmpty(c.AccessibleDescription) &&
                    (count == -1 | c.AccessibleDescription.Length - 1 < count))
                {
                    if (string.IsNullOrEmpty(c.Text))
                    {
                        //errorProvider1.SetError(txt, "Oblicatiorio");
                        cambiarColorLabel(txt, Color.Red);
                        todosCompletos = false;
                    }
                    else
                    {
                        cambiarColorLabel(txt, Color.Black);
                        //errorProvider1.SetError(txt, "");
                    }
                }
                if (c is ComboBox cmb &&
                    !string.IsNullOrEmpty(c.AccessibleDescription) &&
                    (count == -1 | c.AccessibleDescription.Length - 1 < count))
                {
                    if (cmb.SelectedIndex == -1)
                    {
                        //errorProvider1.SetError(c, "Oblicatiorio");
                        cambiarColorLabel(cmb, Color.Red);
                        todosCompletos = false;
                    }
                    else
                    {
                        cambiarColorLabel(cmb, Color.Black);
                        //errorProvider1.SetError(c, "");
                    }
                }
            }
            return todosCompletos;
        }
        private bool validarTodos()
        {
            bool persona = validarVacios(tabPersonales);
            bool academico = validarVacios(tabAcademicos, infoAcademicos);
            bool laboral = validarVacios(tabLaborales, infoLaborales);

            return persona && academico && laboral;
        }

        private void cambiarColorLabel(Control control, Color color)
        {
            foreach (Control c in control.Parent.Controls)
            {
                if (c is Label lbl && lbl.Tag != null &&
                    lbl.Tag.ToString() == control.Name)
                {
                    lbl.ForeColor = color;
                }
            }            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Configura el cuadro de diálogo para seleccionar archivos de imagen
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.png;*.bmp;*.gif|Todos los archivos|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Lee la imagen seleccionada
                    string rutaImagen = openFileDialog.FileName;
                    Image imagen = Image.FromFile(rutaImagen);

                    // Muestra la imagen en el PictureBox
                    pctFoto.Image = imagen;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView provinciaSeleccionada = cmbProvincia.SelectedItem as DataRowView;
            if (provinciaSeleccionada != null)
            {
                int idProvinciaSeleccionada = Convert.ToInt32(provinciaSeleccionada["id_provincia"]);
                DataTable DTPartidos = logica.ObtenerPartido(idProvinciaSeleccionada);

                if (DTPartidos != null && DTPartidos.Rows.Count > 0)
                {
                    cmbPartido.DataSource = DTPartidos;
                    cmbPartido.DisplayMember = "partido";
                    cmbPartido.ValueMember = "id_partido";
                }
                else
                {
                    cmbPartido.DataSource = null;
                    cmbPartido.Items.Clear();
                }
            }

        }

        private void cmbPartido_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView partidoSeleccionada = cmbPartido.SelectedItem as DataRowView;
            if (partidoSeleccionada != null)
            {
                int idPartidoSeleccionada = Convert.ToInt32(partidoSeleccionada["id_partido"]);
                DataTable DTLocalidades = logica.ObtenerLocalidades(idPartidoSeleccionada);

                if (DTLocalidades != null && DTLocalidades.Rows.Count > 0)
                {
                    cmbLocalidad.DataSource = DTLocalidades;
                    cmbLocalidad.DisplayMember = "localidad";
                    cmbLocalidad.ValueMember = "id_localidad";
                }
                else
                {
                    cmbLocalidad.DataSource = null;
                    cmbLocalidad.Items.Clear();
                }
            }
        }


        public void HabilitarCampos()
        {
            

            foreach (TabPage tabPage in tabControl.TabPages)
            {
                foreach (GroupBox groupBox in tabPage.Controls.OfType<GroupBox>())
                {
                    foreach (Control control in groupBox.Controls)
                    {
                        button4.Enabled = true;
                        btbBuscarImagen.Enabled = true;
                        btbEditarImagen.Enabled = true;
                        btbEliminarImagen.Enabled = true;
                      
                        control.Enabled = true; // Habilitar todos los controles dentro del GroupBox
                    }
                }
            }
        }
        public void DeshabilitarCampos ()
        {
       
            foreach (TabPage tabPage in tabControl.TabPages)
            {
                foreach (GroupBox groupBox in tabPage.Controls.OfType<GroupBox>())
                {
                    foreach (Control control in groupBox.Controls)
                    {
                        if ((control is TextBox || control is ComboBox || control is NumericUpDown || control is DateTimePicker ) && control != txtCuitCuil)
                        {
                            button4.Enabled = false;
                            btbBuscarImagen.Enabled = false;
                            btbEditarImagen.Enabled = false;
                            btbEliminarImagen.Enabled = false;
                            control.Enabled = false; // Deshabilitar todos los TextBox y ComboBox excepto el TextBox específico
                        }
                    }
                }
            }



        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
       
        }

        private void button16_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = true;
            infoAcademicos++;
        }

        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!e.TabPage.Enabled)
            {
                e.Cancel = true;
            }
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {
           
        }

        private void label59_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            groupBox6.Visible = true;
            button17.Visible = false;
            label74.Visible = false;

            infoLaborales++;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            groupBox6.Visible = false;
            button17.Visible = true;
            label74.Visible = true;
            infoLaborales--;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            groupBox4.Visible = false;
            infoAcademicos--;
        }

        private void cmbNacionalidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Configura el cuadro de diálogo para seleccionar archivos de imagen
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.png;*.bmp;*.gif|Todos los archivos|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Lee la imagen seleccionada
                    string rutaImagen = openFileDialog.FileName;
                    Image imagen = Image.FromFile(rutaImagen);

                    // Muestra la imagen en el PictureBox
                    pctFoto.Image = imagen;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView partidoSeleccionada = cmbLocalidad.SelectedItem as DataRowView;
            string variable = partidoSeleccionada["cod_postal"].ToString();
            txtCodigoPostal.Text = variable;
        }

        private void tabLaborales_Click(object sender, EventArgs e)
        {

        }

        private void grbSuperior_Enter(object sender, EventArgs e)
        {

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Cancela la entrada de caracteres no numéricos
                MessageBox.Show("En este campo solo debe ingresar números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTelefonoAlternativo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Cancela la entrada de caracteres no numéricos
                MessageBox.Show("En este campo solo debe ingresar números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Cancela la entrada de caracteres no numéricos
                MessageBox.Show("En este campo solo debe ingresar números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Cancela la entrada de caracteres no numéricos
                MessageBox.Show("En este campo solo debe ingresar números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada de caracteres no alfabéticos
                MessageBox.Show("En este campo solo debe ingresar letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada de caracteres no alfabéticos
                MessageBox.Show("En este campo solo debe ingresar letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtContacto_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void txtCalle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada de caracteres no alfabéticos
                MessageBox.Show("En este campo solo debe ingresar letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada de caracteres no alfabéticos
                MessageBox.Show("En este campo solo debe ingresar letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada de caracteres no alfabéticos
                MessageBox.Show("En este campo solo debe ingresar letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtTitulo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada de caracteres no alfabéticos
                MessageBox.Show("En este campo solo debe ingresar letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtTitulo2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

     
    }
}
