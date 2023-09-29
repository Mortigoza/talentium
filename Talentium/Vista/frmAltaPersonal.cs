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

namespace Vista
{
    public partial class frmAltaPersonal : Form
    {
        CN_AdministracionPersonal logica = new CN_AdministracionPersonal();
        public frmAltaPersonal()
        {
            InitializeComponent();
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
        }

        private void button7_Click(object sender, EventArgs e)
        {
            grbSuperior.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            grbExp1.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            grbExp1.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            grbExp2.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            grbExp2.Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            grbExp3.Visible = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            grbExp3.Visible = false;
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            grbExp2.Visible = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void frmAltaPersonal_Load(object sender, EventArgs e)
        {
  
           
         


            DataTable provincia = logica.ObtenerProvincia();
            cmbProvincia.DataSource = provincia;
            cmbProvincia.DisplayMember = "provincia";
            cmbProvincia.ValueMember = "id_provincia";
            //cmbProvincia.SelectedIndex = -1;


            //DataTable partido = logica.ObtenerPartido();
            //cmbPartido.DataSource = partido;
            //cmbPartido.DisplayMember = "partido";
            //cmbPartido.ValueMember = "id_partido";
            //cmbPartido.SelectedIndex = -1;


            //DataTable localidades = logica.ObtenerLocalidades();
            //cmbLocalidad.DataSource = localidades;
            //cmbLocalidad.DisplayMember = "localidad";
            //cmbLocalidad.ValueMember = "id_localidad";
            //if (cmbLocalidad.SelectedItem != null)
            //{
            //    string codigoPostal = cmbLocalidad.SelectedValue.ToString();
            //    txtCodigoPostal.Text = codigoPostal;
            //}

            //cmbLocalidad.SelectedIndex = -1;

            DataTable genero = logica.ObtenerGenero();
            cmbGenero.DataSource = genero;
            cmbGenero.DisplayMember = "genero";
            cmbGenero.ValueMember = "id_genero";
            //cmbGenero.SelectedIndex = -1;

            DataTable tipotel = logica.ObtenerTipoTel();
            cmbTipoTelAlternativo.DataSource = tipotel;
            cmbTipoTelAlternativo.DisplayMember = "tipo";
            cmbTipoTelAlternativo.ValueMember = "id_tipo";
            //cmbTipoTelAlternativo.SelectedIndex = -1;

            DataTable tipotel1 = logica.ObtenerTipoTel();
            cmbTipoTel.DataSource = tipotel1;
            cmbTipoTel.DisplayMember = "tipo";
            cmbTipoTel.ValueMember = "id_tipo";
            //cmbTipoTel.SelectedIndex = -1;


            DataTable nivelacademico = logica.ObtenerNivelAcademico();
            cmbNivelAcademico.DataSource = nivelacademico;
            cmbNivelAcademico.DisplayMember = "nivel";
            cmbNivelAcademico.ValueMember = "id_nivel";
            //cmbNivelAcademico2.DataSource = nivelacademico;
            //cmbNivelAcademico2.DisplayMember = "nivel";
            //cmbNivelAcademico2.ValueMember = "id_nivel";
            //cmbNivelAcademico.SelectedIndex = -1;

            DataTable estadocivil = logica.ObtenerEstadoCivil();
            cmbEstadoCivil.DataSource = estadocivil;
            cmbEstadoCivil.DisplayMember = "estado_civil";
            cmbEstadoCivil.ValueMember = "id_estado_civil";
            //cmbEstadoCivil.SelectedIndex = -1;


            DataTable nacionalidad = logica.ObtenerNacionalidad();
            cmbNacionalidad.DataSource = nacionalidad;
            cmbNacionalidad.DisplayMember = "nacionalidad";
            cmbNacionalidad.ValueMember = "id_nacionalidad";
            //cmbNacionalidad.SelectedIndex = -1;
            
            DataTable tipodoc = logica.ObtenerTipoDoc();
            cmbTipoDoc.DataSource = tipodoc;
            cmbTipoDoc.DisplayMember = "tipo_doc";
            cmbTipoDoc.ValueMember = "id_tipo_doc";
            //cmbTipoDoc.SelectedIndex = -1;


            DataTable progreso = logica.ObtenerProgreso();
            cmbProgreso.DataSource = progreso;
            cmbProgreso.DisplayMember = "estado_progreso";
            cmbProgreso.ValueMember = "id_progreso";
            //cmbProgreso.SelectedIndex = -1;

            cmbProgreso1.DataSource = progreso;
            cmbProgreso1.DisplayMember = "estado_progreso";
            cmbProgreso1.ValueMember = "id_progreso";
            //cmbProgreso1.SelectedIndex = -1;

            cmbProgreso2.DataSource = progreso;
            cmbProgreso2.DisplayMember = "estado_progreso";
            cmbProgreso2.ValueMember = "id_progreso";
            //cmbProgreso2.SelectedIndex = -1;

            DataTable convenio = logica.ObtenerConvenio();
            cmbConvenio.DataSource = convenio;
            cmbConvenio.DisplayMember = "convenio";
            cmbConvenio.ValueMember = "id_convenio";
            //cmbConvenio.SelectedIndex = -1;
            
            DataTable puesto = logica.ObtenerPuesto();
            cmbPuesto.DataSource = puesto;
            cmbPuesto.DisplayMember = "puesto";
            cmbPuesto.ValueMember = "id_puesto";
            //cmbPuesto.SelectedIndex = -1;
            
            DataTable area = logica.ObtenerArea();
            cmbArea.DataSource = area;
            cmbArea.DisplayMember = "area";
            cmbArea.ValueMember = "id_area";
            //cmbArea.SelectedIndex = -1;

            // Agrega los años desde 1900 hasta el año actual a la lista
            int anioActual = DateTime.Now.Year;
            List<string> listaDeAnios = new List<string>();

            for (int i = anioActual; i >= 1900; i--)
            {
                listaDeAnios.Add(i.ToString());
            }      
            // Selecciona el ComboBox en el cual se cargan los años
            cmbIngreso.Items.AddRange(listaDeAnios.ToArray());
            //ComboBox Solapa Academico
            cmbEgreso.Items.AddRange(listaDeAnios.ToArray());
            cmbIngreso1.Items.AddRange(listaDeAnios.ToArray());
            cmbEgreso1.Items.AddRange(listaDeAnios.ToArray());
            cmbEgreso3.Items.AddRange(listaDeAnios.ToArray());

            //ComboBox Solapa Laboral

            cmbLaboralIngreso.Items.AddRange(listaDeAnios.ToArray());
            cmbLaboralEgreso.Items.AddRange(listaDeAnios.ToArray());
            cmbLaboralIngreso1.Items.AddRange(listaDeAnios.ToArray());
            cmbLaboralEgreso1.Items.AddRange(listaDeAnios.ToArray());
            cmbLaboralIngreso2.Items.AddRange(listaDeAnios.ToArray());
            cmbLaboralEgreso2.Items.AddRange(listaDeAnios.ToArray());
            cmbLaboralIngreso3.Items.AddRange(listaDeAnios.ToArray());
            cmbLaboralEgreso3.Items.AddRange(listaDeAnios.ToArray());
        }

        private void grbExp3_Enter(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            CN_AdministracionDatosPersonal logicaPersona = new CN_AdministracionDatosPersonal();
            Persona insert = new Persona();
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            pctFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            #region Mapeo

            insert. apellidos = txtApellidos.Text;
            insert.nombres = txtNombres.Text;
            insert.id_tipo_doc = int.Parse(cmbTipoDoc.SelectedValue.ToString());
            insert.nro_doc = txtDni.Text;
            insert.cuit_cuil = txtCuitCuil.Text;
            insert.calle = txtCalle.Text;
            insert.nro = txtNro.Text.Length;
            insert.dpto = txtDpto.Text;
            insert.piso = txtPiso.Text;
            insert.id_localidad = int.Parse(cmbLocalidad.SelectedValue.ToString());
            insert.id_puesto = int.Parse (cmbPuesto.SelectedValue.ToString());
            insert.id_area = int.Parse(cmbArea.SelectedValue.ToString());
            insert.email = txtEmail.Text;
            insert.id_nacionalidad = int.Parse(cmbNacionalidad.SelectedValue.ToString());

            insert.id_genero = int.Parse(cmbGenero.SelectedValue.ToString());
            insert.fecha_nacimiento = dtpFechaDeNacimiento.Value;



            insert.id_estado_civil = int.Parse(cmbEstadoCivil.SelectedValue.ToString());
            insert.hijos = nupHijos.Text.Length;
            insert.id_convenio = int.Parse (cmbConvenio.SelectedValue.ToString());
            insert.foto_perfil = ms.GetBuffer();
            //insert.telefono = txtTelefono.Text;
            //insert.tipo = cmbTipoTel.Text;
            //insert.telefono_alternativo = txtTelefonoAlternativo.Text;
            //insert.tipo2 = cmbTipoTel.Text;
            //insert.contacto = txtContacto.Text;
            //insert.codigo_postal = txtCodigoPostal.Text;
            //insert.partido = cmbPartido.Text;
            //insert.provincia = cmbProvincia.Text;



            //ACADEMICOS
            insert.id_nivel = cmbNivelAcademico.Text.Length;
            insert.institucion = txtInsitutcionSuperior.Text;
            insert.carrera = txtCarrera.Text;
            insert.año_ingreso = cmbIngreso.Text.Length;
            insert.año_egreso = cmbEgreso.Text.Length;
            // string año_cursado = txtApellidos.Text;
            insert.titulo = txtTitulo.Text;

            //LABORAL

            insert.puesto = txtPuesto.Text;
            insert.empresa = txtEmpresa.Text;
            insert.fecha_ingreso = cmbLaboralIngreso.Text.Length;
            insert.fecha_egreso = cmbLaboralEgreso.Text.Length;
            insert.personal_a_cargo = nupPersonalACargo.Text.Length;
# endregion

            try
            {
                // Llamar al método de la capa de lógica de negocio para insertar una persona
                logicaPersona.InsertarPersona( insert);
     

                MessageBox.Show("La persona se ha insertado correctamente.");
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir
                MessageBox.Show("Se produjo un error al insertar la persona: " + ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

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
    }
}
