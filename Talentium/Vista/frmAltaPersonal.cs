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
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
//using Image = System.Drawing.Image;


namespace Vista
{
    public partial class frmAltaPersonal : Form
    {
        //instancias a clases
        CN_AdministracionPersonalComboBox logica= new CN_AdministracionPersonalComboBox();

        CN_AdministracionDatosPersonal logicaPersona = new CN_AdministracionDatosPersonal();
        private byte[] imagenByte;
        //variables
        private bool inicial = true;
        private int infoLaborales = 0;
        private int infoAcademicos = 1;

        private int nivelEspaniol = -1;
        private int nivelIngles = -1;
        private int imagenBytes;

        private DateTime fn;
        private DateTime fa;
        private bool _mod = false;

        private int _id_persona;
        private int _id_informacion_academica1;
        private int _id_informacion_academica2;
        private int _id_informacion_academica3;

        private int _id_informacion_laboral1;
        private int _id_informacion_laboral2;
        private int _id_informacion_laboral3;
        private int _id_informacion_laboral4;

        byte[] foto;
        public frmAltaPersonal()
        {

          InitializeComponent();
          DeshabilitarCampos();
            
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

        private void frmAltaPersonal_Load(object sender, EventArgs e)
        {
            if (_mod)
            {
                dtpFechaDeNacimiento.Value = fn;
                dttFechaAlta.Value = fa;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

            grpSuperior3.Visible = true;
            infoAcademicos++;
            btnMenosAcademico1.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            grpSuperior3.Visible = false;
            infoAcademicos--;
            btnMenosAcademico1.Visible = true;
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            grpExp2.Visible = true;
            btnMenosLaboral1.Visible = false;
            infoLaborales++;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            grpExp2.Visible = false;
            btnMenosLaboral1.Visible = true;
            infoLaborales--;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            grpExp3.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            grpExp3.Visible = false;
            btnMenosLaboral2.Visible = true;
            infoLaborales--;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            grpExp4.Visible = true;
            btnMenosLaboral3.Visible =false;
            infoLaborales++;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            grpExp4.Visible = false;
            btnMenosLaboral3.Visible =true;
            infoLaborales--;
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            grpExp3.Visible = true;
            btnMenosLaboral2.Visible = false;
            infoLaborales++;
        }

        //validar cuit
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
                            pctFoto.Enabled = true;

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

        //BOTTON PARA MODIFICAR Y GUARDAR
        private void button9_Click(object sender, EventArgs e)
        {
            switch (btnGuardar.Name)
            {
                case "btnGuardar":

                    Tuple<bool, string> validacion = validarTodos();
                     if (validacion.Item1)
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
                insert.fecha_alta = dttFechaAlta.Value;
                
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

                insert.nivel_Es = nivelEspaniol;
                insert.nivel_En = nivelIngles;


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

                lblFaltanCampos2.Visible = false;
                logicaPersona.InsertarPersona(insert, infoLaborales, infoAcademicos);
                MessageBox.Show("Todos los datos se cargaron correctamente.");
                        this.Dispose();


                    }
                     else
            {
                lblFaltanCampos2.Visible = true;
                MessageBox.Show($"Faltan campos obligatorios de:{validacion.Item2}");
            }
                    break;
                case "btnModificar":

                    Tuple<bool, string> validacion1 = validarTodos();
                    if (validacion1.Item1)
                    {
                        #region

                        Persona modify = new Persona();

                    modify.id_informacion_academica1 = _id_informacion_academica1;
                    modify.id_informacion_academica2 = _id_informacion_academica2;
                    modify.id_informacion_academica3 = _id_informacion_academica3;

                    modify.id_informacion_laboral1 = _id_informacion_laboral1;
                    modify.id_informacion_laboral2 = _id_informacion_laboral2;
                    modify.id_informacion_laboral3 = _id_informacion_laboral3;
                    modify.id_informacion_laboral4 = _id_informacion_laboral4;



                    

                        modify.id_persona = _id_persona;
                    modify.nombres = txtNombres.Text;
                    modify.apellidos = txtApellidos.Text;
                    modify.id_tipo_doc = (int)cmbTipoDoc.SelectedValue;
                    modify.nro_doc = txtDni.Text;
                    modify.email = txtEmail.Text;
                    modify.id_nacionalidad = (int)cmbNacionalidad.SelectedValue;
                    modify.id_genero = (int)cmbGenero.SelectedValue;
                    modify.hijos = (int)nupHijos.Value;
                    modify.id_area = (int)cmbArea.SelectedValue;
                    modify.id_convenio = (int)cmbConvenio.SelectedValue;
                    modify.id_localidad = (int)cmbLocalidad.SelectedValue;
                    modify.calle = txtCalle.Text;
                    modify.nro = int.Parse(txtNro.Text);
                    modify.piso = txtPiso.Text;
                    modify.dpto = txtDpto.Text;
                    modify.fecha_nacimiento = dtpFechaDeNacimiento.Value;
                    modify.fecha_alta = dttFechaAlta.Value;
                    modify.id_estado_civil = (int)cmbEstadoCivil.SelectedValue;
                    modify.telefono = txtTelefono.Text;
                    modify.id_tipo = (int)cmbTipoTel.SelectedValue;
                    modify.telefono_alternativo = txtTelefonoAlternativo.Text;
                    modify.id_tipo_alternativo = (int)cmbTipoTelAlternativo.SelectedValue;
                    modify.contacto = txtContacto.Text;

                    //List<Puesto> puesto1 = new List<Puesto>();
                    //foreach (Puesto p in puesto1)
                    //{ 
                    //    puesto1.Add(p);
                    //}
                    //modify.puesto = puesto1.ToArray();

                    //ACADEMICOS
                    modify.id_nivel1 = (cmbNivelAcademico.SelectedValue == null) ? 0 : (int)cmbNivelAcademico.SelectedValue;
                    modify.id_nivel2 = (cmbNivelAcademico1.SelectedValue == null) ? 0 : (int)cmbNivelAcademico1.SelectedValue;
                    modify.id_nivel2 = (cmbNivelAcademico2.SelectedValue == null) ? 0 : (int)cmbNivelAcademico2.SelectedValue;
                    modify.institucion1 = txtInsitutcionSuperior.Text;
                    modify.institucion2 = txtInsitutcionSuperior1.Text;
                    modify.institucion3 = txtInsitutcionSuperior2.Text;
                    modify.titulo1 = txtTitulo.Text;
                    modify.titulo2 = txtTitulo1.Text;
                    modify.titulo3 = txtTitulo2.Text;
                    modify.año_ingreso1 = int.Parse(cmbIngreso.Text);
                    modify.año_ingreso2 = int.Parse(cmbIngreso1.Text);
                    modify.año_ingreso3 = int.Parse(cmbIngreso2.Text);
                    modify.año_egreso1 = int.Parse(cmbEgreso.Text);
                    modify.año_egreso2 = int.Parse(cmbEgreso1.Text);
                    modify.año_egreso3 = int.Parse(cmbEgreso2.Text);
                    modify.id_progreso1 = (cmbProgreso.SelectedValue == null) ? 0 : (int)cmbProgreso.SelectedValue;
                    modify.id_progreso2 = (cmbProgreso1.SelectedValue == null) ? 0 : (int)cmbProgreso1.SelectedValue;
                    modify.id_progreso3 = (cmbProgreso2.SelectedValue == null) ? 0 : (int)cmbProgreso.SelectedValue;
                    modify.nivel_Es = nivelEspaniol;
                    modify.nivel_En = nivelIngles;

                    //LABORALES

                    modify.puesto1 = txtPuesto.Text;
                    modify.puesto2 = txtPuesto1.Text;
                    modify.puesto3 = txtPuesto2.Text;
                    modify.puesto4 = txtPuesto3.Text;

                    modify.empresa1 = txtEmpresa.Text;
                    modify.empresa2 = txtEmpresa1.Text;
                    modify.empresa3 = txtEmpresa2.Text;
                    modify.empresa4 = txtEmpresa3.Text;

                    modify.fecha_ingreso1 = int.Parse(cmbLaboralIngreso1.Text);
                    modify.fecha_ingreso2 = int.Parse(cmbLaboralIngreso1.Text);
                    modify.fecha_ingreso3 = int.Parse(cmbLaboralIngreso2.Text);
                    modify.fecha_ingreso4 = int.Parse(cmbLaboralIngreso3.Text);

                    modify.fecha_egreso1 = int.Parse(cmbLaboralEgreso.Text);
                    modify.fecha_egreso2 = int.Parse(cmbLaboralEgreso1.Text);
                    modify.fecha_egreso3 = int.Parse(cmbLaboralEgreso2.Text);
                    modify.fecha_egreso4 = int.Parse(cmbLaboralEgreso3.Text);

                    modify.personal_a_cargo1 = (int)nupPersonalACargo.Value;
                    modify.personal_a_cargo2 = (int)nupPersonalACargo1.Value;
                    modify.personal_a_cargo3 = (int)nupPersonalACargo2.Value;
                    modify.personal_a_cargo4 = (int)nupPersonalACargo3.Value;


                        if (pctFoto.Image != null)
                        {

                            try
                            {
                                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                                pctFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                                modify.foto_perfil = ms.GetBuffer();
                            }
                            catch
                            {
                                modify.foto_perfil = foto;
                            }



                        }
                        else
                        {

                            modify.foto_perfil = new byte[0];
                        }







                        lblFaltanCampos.Visible = false;
                        lblFaltanCampos1.Visible = false;
                        lblFaltanCampos2.Visible = false;
                    logicaPersona.ActualizarIdioma(modify, _id_persona);
                    logicaPersona.ActualizarTelefono(modify, _id_persona);
                    logicaPersona.ActualizarDatos(modify);
                    logicaPersona.ActualizarDatosAcademicos(modify, infoAcademicos);
                    logicaPersona.ActualizarDatosLaborales(modify, infoLaborales);
                    MessageBox.Show("Los datos se han actualizado correctamente.");
                    this.Dispose();
                    }
                    else
                    {
                        lblFaltanCampos2.Visible = true;
                        MessageBox.Show($"Faltan campos obligatorios de:{validacion1.Item2}");
                    }
                    #endregion
                    break;
            }
        }

       

        //BOTON PARA VALIDAR TAB "INFORMACION ACADEMICA"
        private void button8_Click(object sender, EventArgs e)
        {
           if( validarVacios(tabAcademicos, infoAcademicos))
            {
                lblFaltanCampos1.Visible = false;
                tabControl.TabPages[2].Enabled = true;
                RestaurarColorPredeterminado(tabAcademicos);
                tabControl.SelectedTab = tabLaborales;
            }
            else
            {
                lblFaltanCampos1.Visible = true;
                MessageBox.Show("Faltan campos obligatorios");
            }
        }

        //BOTON PARA VALIDAR TAB "INFORMACION PERSONAL"
        private void button4_Click(object sender, EventArgs e)
        {

            if (validarVacios(tabPersonales))
            {
                lblFaltanCampos.Visible = false;
                tabControl.TabPages[1].Enabled = true;
                RestaurarColorPredeterminado(tabPersonales);
                tabControl.SelectedTab = tabAcademicos;
            }
            else
            {
                lblFaltanCampos.Visible = true;
                MessageBox.Show("Faltan campos obligatorios");
            }
        }
        //BOTON PARA AGREGAR Y ELIMINAR FOTO
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
                    System.Drawing.Image imagen = System.Drawing.Image.FromFile(rutaImagen);

                    // Muestra la imagen en el PictureBox
                    pctFoto.SizeMode = PictureBoxSizeMode.Zoom;
                    pctFoto.Image = imagen;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btbEliminarImagen_Click(object sender, EventArgs e)
        {
            pctFoto.Image = null;
        }

        //METODOS
        #region Metodos
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
                    if (string.IsNullOrWhiteSpace(c.Text))
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
        private Tuple<bool,string> validarTodos()
        {
            string msg = "";
            bool persona = validarVacios(tabPersonales);
            bool academico = validarVacios(tabAcademicos, infoAcademicos);
            bool laboral = validarVacios(tabLaborales, infoLaborales);
            if (!persona) msg += "\n" + tabPersonales.Text;
            if (!academico) msg += "\n" + tabAcademicos.Text;
            if (!laboral) msg += "\n" + tabLaborales.Text;

            return (persona && academico && laboral, msg).ToTuple();
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
        public void HabilitarCampos()
        {


            foreach (TabPage tabPage in tabControl.TabPages)
            {
                foreach (GroupBox groupBox in tabPage.Controls.OfType<GroupBox>())
                {
                    foreach (Control control in groupBox.Controls)
                    {
                        //grpSuperior2.Enabled = true;
                        //grpExp2.Enabled = true;
                        //grpExp4.Enabled = true;
                        grpIngles.Enabled = true;
                        grpEspaniol.Enabled = true;
                        btnContinuar1.Enabled = true;
                        btnEditarImagen.Enabled = true;
                        btnEliminarImagen.Enabled = true;
                        grpSuperior2.Enabled = true;
                        grpSuperior3.Enabled = true;

                        control.Enabled = true; // Habilitar todos los controles dentro del GroupBox
                    }
                }
            }
        }
        public void DeshabilitarCampos()
        {

            foreach (TabPage tabPage in tabControl.TabPages)
            {
                foreach (GroupBox groupBox in tabPage.Controls.OfType<GroupBox>())
                {
                    foreach (Control control in groupBox.Controls)
                    {
                        if ((control is TextBox || control is ComboBox || control is NumericUpDown || control is DateTimePicker) && control != txtCuitCuil)
                        {
                            grpEspaniol.Enabled = false;
                            grpIngles.Enabled = false;
                            grpSuperior2.Enabled = false;
                            grpExp2.Enabled = false;
                            grpExp4.Enabled = false;
                            btnContinuar1.Enabled = false;
                            btnEditarImagen.Enabled = false;
                            btnEliminarImagen.Enabled = false;
                            control.Enabled = false; // Deshabilitar todos los TextBox y ComboBox excepto el TextBox específico
                        }
                    }
                }
            }



        }
        private void BotonesInvisibles()
        {
            Button[] botones = { btnValidar,btnContinuar1,btnContinuar2,btnGuardar,btnEditarImagen,btnEliminarImagen,btnMasAcademico1,btnMenosAcademico1,btnMasAcademico2,btnMenosAcademico2,
            btnMasLaborales1,btnMenosLaboral1,btnMasLaborales2,btnMenosLaboral2,btnMasLaborales3,btnMenosLaboral3,btnMasLaborales4,btnMenosLaboral4};

            // Ocultar todos los botones en el arreglo
            foreach (Button boton in botones)
            {
                boton.Visible = false;
            }
        }
        private void BotonesInvisiblesModificacion()
        {

            Button[] botonesOcultar = {btnValidar,btnMasAcademico1,btnMasAcademico2,btnMenosAcademico1,btnMenosAcademico2,
            btnMasLaborales1,btnMasLaborales2,btnMasLaborales3,btnMasLaborales4,btnMenosLaboral1,btnMenosLaboral2,btnMenosLaboral3,btnMenosLaboral4};
            foreach (Button botonOcultar in botonesOcultar)
            {
                botonOcultar.Visible = false;
            }
        }
        private void BotonesVisibles()
        {
            Button[] botones = { btnValidar,btnContinuar1,btnContinuar2,btnGuardar,btnEditarImagen,btnEliminarImagen,btnMasAcademico1,btnMenosAcademico1,btnMasAcademico2,btnMenosAcademico2,
            btnMasLaborales1,btnMenosLaboral1,btnMasLaborales2,btnMenosLaboral2,btnMasLaborales3,btnMenosLaboral3,btnMasLaborales4,btnMenosLaboral4};

            foreach (Button boton in botones)
            {
                boton.Visible = true;
            }
        }
        public void Visibilizar(string nombreControl, int len)
        {
            for (int i = 1; i <= len; i++)
            {
                string groupName = nombreControl + i;
                Control control = Controls.Find(groupName, true).FirstOrDefault();

                if (control != null && control is GroupBox)
                {
                    GroupBox groupBox = (GroupBox)control;
                    groupBox.Visible = true;
                }
            }
        }
        #endregion

        //LLENAR LOS COMBOBOX Localidad,Partido y Provincia + CodigoPostal.
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
        private void cmbLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView partidoSeleccionada = cmbLocalidad.SelectedItem as DataRowView;
            string variable = partidoSeleccionada["cod_postal"].ToString();
            txtCodigoPostal.Text = variable;
        }


        //CONTROLES MODIFICADOS
        private void button16_Click(object sender, EventArgs e)
        {
            grpSuperior2.Visible = true;
            infoAcademicos++;
        }
        private void button17_Click(object sender, EventArgs e)
        {
            grpExp1.Visible = true;
            btnMasLaborales1.Visible = false;
            lblAgregarExperienciaLaboral.Visible = false;

            infoLaborales++;
        }
        private void button18_Click(object sender, EventArgs e)
        {
            grpExp1.Visible = false;
            btnMasLaborales1.Visible = true;
            lblAgregarExperienciaLaboral.Visible = true;
            infoLaborales--;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            grpSuperior2.Visible = false;
            infoAcademicos--;
        }


        //CONTROLES CON EVENTOS
        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!e.TabPage.Enabled)
            {
                e.Cancel = true;
            }
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
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada de caracteres no alfabéticos
                MessageBox.Show("En este campo solo debe ingresar letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada de caracteres no alfabéticos
                MessageBox.Show("En este campo solo debe ingresar letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtCalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && !char.IsControl(e.KeyChar))
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
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada de caracteres no alfabéticos
                MessageBox.Show("En este campo solo debe ingresar letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtTitulo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada de caracteres no alfabéticos
                MessageBox.Show("En este campo solo debe ingresar letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtTitulo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada de caracteres no alfabéticos
                MessageBox.Show("En este campo solo debe ingresar letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Espaniol_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBasico.Checked)
            {
                nivelEspaniol = 0;
            }
            if (rdbIntermedio.Checked)
            {
                nivelEspaniol = 1;
            }
            if (rdbAvanzado.Checked)
            {
                nivelEspaniol = 2;
            }
            if (rdbNativo.Checked)
            {
                nivelEspaniol = 3;
            }
            if (btnContinuar2.Enabled == false && nivelEspaniol != -1 && nivelIngles != -1)
            {
                btnContinuar2.Enabled = true;
            }
        }

        private void Ingles_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbBasicoEn.Checked)
            {
                nivelIngles = 0;
            }
            if (rdbIntermedioEn.Checked)
            {
                nivelIngles = 1;
            }
            if (rdbAvanzadoEn.Checked)
            {
                nivelIngles = 2;
            }
            if (rdbNativoEn.Checked)
            {
                nivelIngles = 3;
            }
            if (btnContinuar2.Enabled == false && nivelEspaniol != -1 && nivelIngles != -1)
            {
                btnContinuar2.Enabled = true;
            }
        }



        //Consulta

        public void CargarDatosPersona(int id_persona, Persona modify = null)
        {
            _mod = true;
            tabControl.TabPages[1].Enabled = true;
            tabControl.TabPages[2].Enabled = true;
            DeshabilitarCampos();
            BotonesInvisibles();
            txtCuitCuil.Enabled = false;
            


            Persona insert = new Persona();
  
            logicaPersona.ObtenerPersona(insert, id_persona, ref infoAcademicos, ref infoLaborales);

            if (modify != null)
            {
                modify.id_informacion_academica1 = insert.id_informacion_academica1;
                modify.id_informacion_academica2 = insert.id_informacion_academica2;
                modify.id_informacion_academica3 = insert.id_informacion_academica3;
                modify.id_informacion_laboral1= insert.id_informacion_laboral1;
                modify.id_informacion_laboral1 = insert.id_informacion_laboral1;
                modify.id_informacion_laboral1 = insert.id_informacion_laboral1;
                modify.id_informacion_laboral1 = insert.id_informacion_laboral1;
            }

            //PERSONAL
            //TextBox
            txtCuitCuil.Text = insert.cuit_cuil;
            txtApellidos.Text = insert.apellidos;
            txtNombres.Text = insert.nombres;
            txtDni.Text = insert.nro_doc;
            txtEmail.Text = insert.email;
            txtTelefono.Text = insert.telefono;
            txtTelefonoAlternativo.Text = insert.telefono_alternativo;
            txtContacto.Text = insert.contacto;
            txtCalle.Text = insert.calle;
            txtNro.Text = insert.nro.ToString();
            txtDpto.Text = insert.dpto;
            txtPiso.Text = insert.piso;
            //ComboBox
            cmbTipoDoc.SelectedValue = insert.id_tipo_doc;
            cmbTipoTel.SelectedValue = insert.id_tipo;
            cmbTipoTelAlternativo.SelectedValue = insert.id_tipo_alternativo;
            cmbNacionalidad.SelectedValue = insert.id_nacionalidad;
            cmbGenero.SelectedValue = insert.id_genero;
            cmbEstadoCivil.SelectedValue = insert.id_estado_civil;
            cmbArea.SelectedValue = insert.id_area;
            cmbPuesto.SelectedValue = insert.id_puesto;
            cmbConvenio.SelectedValue = insert.id_convenio;
            cmbProvincia.SelectedValue = insert.id_provincia;
            cmbPartido.SelectedValue = insert.id_partido;
            cmbLocalidad.SelectedValue = insert.id_localidad;
            //DateTime y Numeric
            nupHijos.Value = insert.hijos;
         
            fn = insert.fecha_nacimiento;
            fa = insert.fecha_alta;

            if (insert.foto_perfil != null && insert.foto_perfil.Length > 0)

            {
                imagenByte = (byte[])insert.foto_perfil;
                using (MemoryStream stream = new MemoryStream(imagenByte))
                {
                    System.Drawing.Image imagen = System.Drawing.Image.FromStream(stream);
                    pctFoto.Image = imagen;
                    pctFoto.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }



            //Academicos

            txtInsitutcionSuperior.Text = insert.institucion1;
            txtInsitutcionSuperior1.Text = insert.institucion2;
            txtInsitutcionSuperior2.Text = insert.institucion3;
            txtTitulo.Text = insert.titulo1;
            txtTitulo1.Text = insert.titulo2;
            txtTitulo2.Text = insert.titulo3;

            switch (insert.nivel_Es)
            {
                case 0:
                    rdbBasico.Checked = true;
                    break;
                case 1:
                    rdbIntermedio.Checked = true;
                    break;
                case 2:
                    rdbAvanzado.Checked = true;
                    break;
                case 3:
                    rdbNativo.Checked = true;
                    break;
            }


            switch (insert.nivel_En)
            {
                case 0:
                    rdbBasicoEn.Checked = true;
                    break;
                case 1:
                    rdbIntermedioEn.Checked = true;
                    break;
                case 2:
                    rdbAvanzadoEn.Checked = true;
                    break;
                case 3:
                    rdbNativoEn.Checked = true;
                    break;
            }


            //ComboBox
            cmbNivelAcademico.SelectedValue = insert.id_nivel1;
            cmbNivelAcademico1.SelectedValue = (insert.id_nivel2 == null) ? 0 : insert.id_nivel2;
            cmbNivelAcademico2.SelectedValue = (insert.id_nivel3 == null) ? 0 : insert.id_nivel3;
            cmbIngreso.Text = insert.año_ingreso1.ToString();
            cmbIngreso1.Text = insert.año_ingreso2.ToString();
            cmbIngreso2.Text = insert.año_ingreso3.ToString();
            cmbEgreso.Text = insert.año_egreso1.ToString();
            cmbEgreso1.Text = insert.año_egreso2.ToString();
            cmbEgreso2.Text = insert.año_egreso3.ToString();
            cmbProgreso.SelectedValue = insert.id_progreso1;
            cmbProgreso1.SelectedValue = (insert.id_progreso2 == null) ? 0 : insert.id_progreso2;
            cmbProgreso2.SelectedValue = (insert.id_progreso3 == null) ? 0 : insert.id_progreso3;

            Visibilizar("grpSuperior", infoAcademicos);


            //laborales
            //TextBox
            txtPuesto.Text = insert.puesto1;
            txtPuesto1.Text = insert.puesto2;
            txtPuesto2.Text = insert.puesto3;
            txtPuesto3.Text = insert.puesto4;
            txtEmpresa.Text = insert.empresa1;
            txtEmpresa1.Text = insert.empresa2;
            txtEmpresa2.Text = insert.empresa3;
            txtEmpresa3.Text = insert.empresa4;
            //ComboBox
            cmbLaboralIngreso.Text = insert.fecha_ingreso1.ToString();
            cmbLaboralIngreso1.Text = insert.fecha_ingreso2.ToString();
            cmbLaboralIngreso2.Text = insert.fecha_ingreso3.ToString();
            cmbLaboralIngreso3.Text = insert.fecha_ingreso4.ToString();
            cmbLaboralEgreso.Text = insert.fecha_egreso1.ToString();
            cmbLaboralEgreso1.Text = insert.fecha_egreso2.ToString();
            cmbLaboralEgreso2.Text = insert.fecha_egreso3.ToString();
            cmbLaboralEgreso3.Text = insert.fecha_egreso4.ToString();
            //Numeric
            nupPersonalACargo.Value = insert.personal_a_cargo1;
            nupPersonalACargo1.Value = insert.personal_a_cargo2;
            nupPersonalACargo2.Value = insert.personal_a_cargo3;
            nupPersonalACargo3.Value = insert.personal_a_cargo4;

            if (infoLaborales == 0)
            {
                lblAgregarExperienciaLaboral.Visible = true;
                lblAgregarExperienciaLaboral.Text = "No cuenta con experiencia laboral.";

            }
            else
            {
                grpExp1.Text = "";
                lblAgregarExperienciaLaboral.Text = "Experiencia laboral.";
            }
            Visibilizar("grpExp", infoLaborales);
        }


        //Modificacion
        public void CargarDatosModificacion(int id_persona)
        {


            Persona modify = new Persona();
            
            btnGuardar.Name = "btnModificar";
            btnGuardar.Text = "Modificar";
            
            _id_persona = id_persona;
            CargarDatosPersona(id_persona, modify);
            _id_informacion_academica1 = modify.id_informacion_academica1;
            _id_informacion_academica2 = modify.id_informacion_academica2;
            _id_informacion_academica3 = modify.id_informacion_academica3;

            _id_informacion_laboral1 = modify.id_informacion_laboral1;
            _id_informacion_laboral2 = modify.id_informacion_laboral2;
            _id_informacion_laboral3 = modify.id_informacion_laboral3;
            _id_informacion_laboral4 = modify.id_informacion_laboral4;

            foto = modify.foto_perfil;
            BotonesInvisiblesModificacion();
            HabilitarCampos();
            btnEditarImagen.Visible = true;
            btnEliminarImagen.Visible = true;
            btnValidar.Visible = false;
            btnGuardar.Visible = true;
            txtCuitCuil.Enabled = false;
            dttFechaAlta.Enabled = false;
        }

        //Controles vacios
        #region

      
        private void txtContacto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCalle_TextChanged(object sender, EventArgs e)
        {

        }
        private void tabLaborales_Click(object sender, EventArgs e)
        {

        }

        private void grbSuperior_Enter(object sender, EventArgs e)
        {

        }
        private void cmbNacionalidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void label59_Click(object sender, EventArgs e)
        {

        }
        private void grbExp3_Enter(object sender, EventArgs e)
        {

        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void tabAcademicos_Click(object sender, EventArgs e)
        {

        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            
            try
            {
                /* string iniciofecha = dtpFecDesde.Value.ToString("dd-MM-yyyy");
                 string finfecha = dtpFecHasta.Value.ToString("dd-MM-yyyy");*/
                
                SaveFileDialog Guardar = new SaveFileDialog();
                Guardar.FileName = string.Format("Reporte " + DateTime.Now.ToString("ddMMyyyy") + ".pdf");

                string paginaHtmlTexto = Properties.Resources.PantillaEmpleadoPdf.ToString();

                paginaHtmlTexto = paginaHtmlTexto.Replace("@NOMYAPE", txtNombres.Text.ToString()+" "+txtApellidos.Text.ToString());
                paginaHtmlTexto = paginaHtmlTexto.Replace("@CUIL", txtCuitCuil.Text.ToString());
                paginaHtmlTexto = paginaHtmlTexto.Replace("@DOC", txtNombres.Text.ToString());
                paginaHtmlTexto = paginaHtmlTexto.Replace("@TIPODOC", txtNombres.Text.ToString());
                paginaHtmlTexto = paginaHtmlTexto.Replace("@GENERO", txtNombres.Text.ToString());
                paginaHtmlTexto = paginaHtmlTexto.Replace("@FECHANAC", txtNombres.Text.ToString());
                paginaHtmlTexto = paginaHtmlTexto.Replace("@ECIVIL", txtNombres.Text.ToString());
                paginaHtmlTexto = paginaHtmlTexto.Replace("@HIJOS", txtNombres.Text.ToString());
                paginaHtmlTexto = paginaHtmlTexto.Replace("@NAC", txtNombres.Text.ToString());
                paginaHtmlTexto = paginaHtmlTexto.Replace("@EMAIL", txtNombres.Text.ToString());
                paginaHtmlTexto = paginaHtmlTexto.Replace("@TEL", txtNombres.Text.ToString());
                paginaHtmlTexto = paginaHtmlTexto.Replace("@ALTERTEL", txtNombres.Text.ToString());
                paginaHtmlTexto = paginaHtmlTexto.Replace("@NOMALTERTEL", txtNombres.Text.ToString());
                
                paginaHtmlTexto = paginaHtmlTexto.Replace("@PROV", txtNombres.Text.ToString());
                paginaHtmlTexto = paginaHtmlTexto.Replace("@PART", txtNombres.Text.ToString());
                paginaHtmlTexto = paginaHtmlTexto.Replace("@LOC", txtNombres.Text.ToString());
                paginaHtmlTexto = paginaHtmlTexto.Replace("@CODPOSTAL", txtNombres.Text.ToString());
                paginaHtmlTexto = paginaHtmlTexto.Replace("@CALLE", txtNombres.Text.ToString());
                paginaHtmlTexto = paginaHtmlTexto.Replace("@ALTURA", txtNombres.Text.ToString());
                paginaHtmlTexto = paginaHtmlTexto.Replace("@PISO", txtNombres.Text.ToString());
                paginaHtmlTexto = paginaHtmlTexto.Replace("@DEPTO", txtNombres.Text.ToString());

                paginaHtmlTexto = paginaHtmlTexto.Replace("@AREA", txtNombres.Text.ToString());
                paginaHtmlTexto = paginaHtmlTexto.Replace("@PUESTO", txtNombres.Text.ToString());
                paginaHtmlTexto = paginaHtmlTexto.Replace("@CONVENIO", txtNombres.Text.ToString());
                paginaHtmlTexto = paginaHtmlTexto.Replace("@FECHAING", txtNombres.Text.ToString());
                paginaHtmlTexto = paginaHtmlTexto.Replace("@PUESTO2", txtNombres.Text.ToString());
                paginaHtmlTexto = paginaHtmlTexto.Replace("@EMPRESA", txtCuitCuil.Text.ToString());
                paginaHtmlTexto = paginaHtmlTexto.Replace("@DURACION", txtNombres.Text.ToString());
                paginaHtmlTexto = paginaHtmlTexto.Replace("@ESP", txtNombres.Text.ToString());
                paginaHtmlTexto = paginaHtmlTexto.Replace("@ING", txtNombres.Text.ToString());
                paginaHtmlTexto = paginaHtmlTexto.Replace("@FECHAEMIT", txtNombres.Text.ToString());



                /*  string filas = string.Empty;
                  for (int i = 0; i < dgvListaEventos.RowCount - 1; i++)
                  {
                      filas += "<tr>";
                      filas += "<td>" + dgvListaEventos.Rows[i].Cells[0].Value.ToString() + "</td>";
                      filas += "<td>" + dgvListaEventos.Rows[i].Cells[1].Value.ToString() + "</td>";
                      filas += "<td>" + dgvListaEventos.Rows[i].Cells[2].Value.ToString() + "</td>";
                      filas += "<td>" + dgvListaEventos.Rows[i].Cells[3].Value.ToString() + "</td>";
                      filas += "<td>" + dgvListaEventos.Rows[i].Cells[4].Value.ToString() + "</td>";
                      filas += "<td>" + dgvListaEventos.Rows[i].Cells[5].Value.ToString() + "</td>";
                      filas += "</tr>";

                  }

                  paginaHtmlTexto = paginaHtmlTexto.Replace("@FILAS", filas);*/

                if (Guardar.ShowDialog() == DialogResult.OK)
                {

                    using (FileStream stream = new FileStream(Guardar.FileName, FileMode.Create))
                    {
                        Document PDF = new Document(PageSize.A4, 25, 25, 25, 25);

                        PdfWriter writer = PdfWriter.GetInstance(PDF, stream);
                        PDF.Open();

                        PDF.Add(new Phrase(""));
                        //se agrega la imagen al pdf
                        using (MemoryStream streamm = new MemoryStream(imagenByte))
                        {
                            System.Drawing.Image imagen = System.Drawing.Image.FromStream(streamm);
                            // Convertir la imagen de System.Drawing.Image a iTextSharp.text.Image
                            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(imagen, System.Drawing.Imaging.ImageFormat.Jpeg);

                            img.ScaleToFit(80, 80);
                            float x = PDF.PageSize.Width - PDF.RightMargin - img.ScaledWidth;
                            float y = PDF.PageSize.Height - PDF.TopMargin - img.ScaledHeight;

                            // Establecer la posición absoluta de la imagen
                            img.SetAbsolutePosition(x, y);
                            //img.Alignment = iTextSharp.text.Image.UNDERLYING;
                            //img.SetAbsolutePosition(PDF.RightMargin, PDF.Top -70);
                            PDF.Add(img);

                        }


                        using (StringReader sr = new StringReader(paginaHtmlTexto))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, PDF, sr);
                        }

                        PDF.Close();
                        stream.Close();

                    }
                }
                MessageBox.Show("La descarga fue realizada con éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar descargar el Pdf" + ex);
            }
        }
    }
}
