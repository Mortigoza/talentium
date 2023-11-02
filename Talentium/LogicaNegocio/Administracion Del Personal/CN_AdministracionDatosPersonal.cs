using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using System.Data;
using System.Data.SqlClient;
using Comun;
using AccesoDatos.Administracion_Personal;
namespace LogicaNegocio.Administracion_Del_Personal
{
    public class CN_AdministracionDatosPersonal
    {
        private CD_AccesoBDPersonacs AccesoDatos = new CD_AccesoBDPersonacs();
        public void InsertarTelefono (Persona insert,int id_persona)
        {
            
            AccesoDatos.InsertarTelefono(id_persona,insert.telefono,insert.id_tipo,true);
            AccesoDatos.InsertarTelefono(id_persona, insert.telefono_alternativo, insert.id_tipo_alternativo, false ,insert.contacto);
        }

        public void InsertIdioma(Persona insert, int id_persona)
        {
            AccesoDatos.InsertarIdioma(id_persona, 2, insert.nivel_Es);
            AccesoDatos.InsertarIdioma(id_persona, 1,insert.nivel_En );
        }

        public void InsertarPersona(Persona insert, int infoLaborales, int infoAcademicos)
        {
            try
            {
                DataTable dt = AccesoDatos.InsertarPersona(insert);
                int id_persona = Convert.ToInt32(dt.Rows[0][0]);
                InsertarTelefono(insert, id_persona);
                InsertIdioma(insert,id_persona);
                InsertarInformacionLaboral(insert,id_persona,infoLaborales);
                InsertarInformacionAcademica(insert,id_persona,infoAcademicos);

    
            }
            catch (Exception ex)
            {
                
                throw new Exception("Error al insertar persona en la base de datos: " + ex.Message);
            }

        }

        public void InsertarInformacionLaboral (Persona insert,int id_persona,int cantidad)
        {
            Dictionary<int, (string puesto, string empresa, int fecha_ingreso, int fecha_egreso, int personal_a_cargo)> informacionLaboral
                = new Dictionary<int, (string, string, int, int, int)>
            {
                { 1, (insert.puesto1, insert.empresa1, insert.fecha_ingreso1,  insert.fecha_egreso1, insert.personal_a_cargo1) },
                { 2, (insert.puesto2, insert.empresa2, insert.fecha_ingreso2,  insert.fecha_egreso2, insert.personal_a_cargo2) },
                { 3, (insert.puesto3, insert.empresa3, insert.fecha_ingreso3,  insert.fecha_egreso3, insert.personal_a_cargo3) },
                { 4, (insert.puesto4, insert.empresa4, insert.fecha_ingreso4,  insert.fecha_egreso4, insert.personal_a_cargo4) }

            };
            for (int i = 1; i <= cantidad; i++)
            {
                string _puesto = informacionLaboral[i].puesto;
                string _empresa = informacionLaboral[i].empresa;
                int _fecha_ingreso = informacionLaboral[i].fecha_ingreso;
                int _fecha_egreso = informacionLaboral[i].fecha_egreso;
                int _personal_a_cargo = informacionLaboral[i].personal_a_cargo;
                AccesoDatos.InsertarInformacionLaboral(id_persona,_puesto,_empresa,_fecha_ingreso,_fecha_egreso,_personal_a_cargo);

            }
          
        }
        public void InsertarInformacionAcademica (Persona insert, int id_persona, int cantidad)
        {
            Dictionary<int, (int? id_nivel, string institucion, int año_ingreso ,int año_egreso, string titulo, int? id_progreso )> informacionAcademica
              = new Dictionary<int, (int?, string, int, int,string,int?)>
          {
                { 1, (insert.id_nivel1, insert.institucion1,  insert.año_ingreso1, insert.año_egreso1, insert.titulo1, insert.id_progreso1) },
                { 2, (insert.id_nivel2, insert.institucion2,  insert.año_ingreso2, insert.año_egreso2, insert.titulo2, insert.id_progreso2)},
                { 3, (insert.id_nivel3, insert.institucion3,  insert.año_ingreso3, insert.año_egreso3, insert.titulo3, insert.id_progreso3) },
             

          };
            for (int i = 1; i <= cantidad; i++)
            {
                int? id_nivel = informacionAcademica[i].id_nivel;
                string institucion = informacionAcademica[i].institucion;
                int año_ingreso = informacionAcademica[i].año_ingreso;
                int año_egreso = informacionAcademica[i].año_egreso;
                string titulo = informacionAcademica[i].titulo;
                int? id_progreso = informacionAcademica[i].id_progreso;
                AccesoDatos.InsertarInformacionAcademica(id_persona, id_nivel,institucion,año_ingreso,año_egreso,titulo,id_progreso);
            }
        }

        //se crea instancia y se almacena en "AccesoDatos"
        public bool ValidarCuit(string cuit_cuil)
        {
            return AccesoDatos.ValidarCuit(cuit_cuil);
            
        }

        //CONSULTAS

        public DataTable ObtenerPersona()
        {

            return AccesoDatos.ObtenerPersona();
        }
        public DataTable ObtenerIdioma(int id_persona)
        {
            return AccesoDatos.ObtenerIdioma(id_persona);
        }



        public void ObtenerPersona(Persona insert, int id_persona, ref int _infoAcademicos, ref int _infoLaborales)
        {
           
            DataTable persona = AccesoDatos.ObtenerPersona(id_persona);
            DataTable academicos = AccesoDatos.ObtenerDatosAcademicos(id_persona);
            DataTable laborales  =AccesoDatos.ObtenerDatosLaborales(id_persona);
            DataTable telefono = AccesoDatos.ObtenerTelefono(id_persona);
            DataTable idioma = AccesoDatos.ObtenerIdioma(id_persona);


            int infoAcademicos = academicos.Rows.Count;
            int infoLaborales = laborales.Rows.Count;
            _infoAcademicos = infoAcademicos;
            _infoLaborales = infoLaborales;

            #region Mapeo
            
            insert.apellidos = persona.Rows[0]["apellidos"].ToString();
            insert.nombres = persona.Rows[0]["nombres"].ToString();
            insert.id_tipo_doc = (int)persona.Rows[0]["id_tipo_doc"];
            insert.nro_doc = persona.Rows[0]["nro_doc"].ToString();
            insert.cuit_cuil = persona.Rows[0]["cuit_cuil"].ToString();
            insert.calle = persona.Rows[0]["calle"].ToString();
            insert.nro = (int)persona.Rows[0]["nro"];
            insert.dpto = persona.Rows[0]["dpto"].ToString();
            insert.piso = persona.Rows[0]["piso"].ToString();
            insert.id_provincia = (int)persona.Rows[0]["id_provincia"];
            insert.id_partido = (int)persona.Rows[0]["id_partido"];
            insert.id_localidad = (int)persona.Rows[0]["id_localidad"];
            insert.id_puesto = (int)persona.Rows[0]["id_puesto"];
            insert.id_area = (int)persona.Rows[0]["id_area"];
            insert.email = persona.Rows[0]["email"].ToString();
            insert.id_nacionalidad = (int)persona.Rows[0]["id_nacionalidad"];
            insert.id_genero = (int)persona.Rows[0]["id_genero"];
            insert.fecha_nacimiento = Convert.ToDateTime(persona.Rows[0]["fecha_nacimiento"]);
            insert.id_estado_civil = (int)persona.Rows[0]["id_estado_civil"];
            insert.hijos = (int)persona.Rows[0]["hijos"];
            insert.id_convenio = (int)persona.Rows[0]["id_convenio"];
            insert.fecha_alta = Convert.ToDateTime(persona.Rows[0]["fecha_alta"]);


            insert.foto_perfil = (byte[])persona.Rows[0]["foto_perfil"];

           

            //Telefono
            insert.telefono = telefono.Rows[0]["telefono"].ToString();
            insert.id_tipo = (int)telefono.Rows[0]["id_tipo_telefono"];
            insert.telefono_alternativo = telefono.Rows[1]["telefono"].ToString();
            insert.id_tipo_alternativo = (int)telefono.Rows[1]["id_tipo_telefono"];
            insert.contacto = telefono.Rows[1]["contacto"].ToString();


            // CONSULTA DE ACADEMICOS


            switch (infoAcademicos)
            {
                case 1:
                    insert.id_informacion_academica1 = (int)academicos.Rows[0]["id_informacion_academica"];

                    insert.id_nivel1 = (int)academicos.Rows[0]["id_nivel"];
                    insert.institucion1 = academicos.Rows[0]["institucion"].ToString();
                    insert.año_ingreso1 = (int)academicos.Rows[0]["año_ingreso"];
                    insert.titulo1 = academicos.Rows[0]["titulo"].ToString();
                    insert.año_egreso1 = (int)academicos.Rows[0]["año_egreso"];
                    insert.id_progreso1 = (int)academicos.Rows[0]["id_progreso"];
                    break;
                case 2:
                    insert.id_informacion_academica1 = (int)academicos.Rows[0]["id_informacion_academica"];
                    insert.id_informacion_academica2 = (int)academicos.Rows[1]["id_informacion_academica"];

                    insert.id_nivel1 = (int)academicos.Rows[0]["id_nivel"];
                    insert.institucion1 = academicos.Rows[0]["institucion"].ToString();
                    insert.año_ingreso1 = (int)academicos.Rows[0]["año_ingreso"];
                    insert.titulo1 = academicos.Rows[0]["titulo"].ToString();
                    insert.año_egreso1 = (int)academicos.Rows[0]["año_egreso"];
                    insert.id_progreso1 = (int)academicos.Rows[0]["id_progreso"];

                    insert.id_nivel2 = (int)academicos.Rows[1]["id_nivel"];
                    insert.institucion2 = academicos.Rows[1]["institucion"].ToString();
                    insert.año_ingreso2 = (int)academicos.Rows[1]["año_ingreso"];
                    insert.año_egreso2 = (int)academicos.Rows[1]["año_egreso"];
                    insert.titulo2 = academicos.Rows[1]["titulo"].ToString();
                    insert.id_progreso2 = (int)academicos.Rows[1]["id_progreso"];
                    break;
                case 3:

                    insert.id_informacion_academica1 = (int)academicos.Rows[0]["id_informacion_academica"];
                    insert.id_informacion_academica2 = (int)academicos.Rows[1]["id_informacion_academica"];
                    insert.id_informacion_academica3 = (int)academicos.Rows[2]["id_informacion_academica"];

                    insert.id_nivel1 = (int)academicos.Rows[0]["id_nivel"];
                    insert.institucion1 = academicos.Rows[0]["institucion"].ToString();
                    insert.año_ingreso1 = (int)academicos.Rows[0]["año_ingreso"];
                    insert.titulo1 = academicos.Rows[0]["titulo"].ToString();
                    insert.año_egreso1 = (int)academicos.Rows[0]["año_egreso"];
                    insert.id_progreso1 = (int)academicos.Rows[0]["id_progreso"];

                    insert.id_nivel2 = (int)academicos.Rows[1]["id_nivel"];
                    insert.institucion2 = academicos.Rows[1]["institucion"].ToString();
                    insert.año_ingreso2 = (int)academicos.Rows[1]["año_ingreso"];
                    insert.año_egreso2 = (int)academicos.Rows[1]["año_egreso"];
                    insert.titulo2 = academicos.Rows[1]["titulo"].ToString();
                    insert.id_progreso2 = (int)academicos.Rows[1]["id_progreso"];

                    insert.id_nivel3 = (int)academicos.Rows[2]["id_nivel"];
                    insert.institucion3 = academicos.Rows[2]["institucion"].ToString();
                    insert.año_ingreso3 = (int)academicos.Rows[2]["año_ingreso"];
                    insert.año_egreso3 = (int)academicos.Rows[2]["año_egreso"];
                    insert.titulo3 = academicos.Rows[2]["titulo"].ToString();
                    insert.id_progreso3 = (int)academicos.Rows[2]["id_progreso"];
                    break;
            }

            insert.nivel_Es = (int)idioma.Rows[0]["nivel_idioma"];
            insert.nivel_En = (int)idioma.Rows[1]["nivel_idioma"];

            //CONSULTA DE LABORAL



            switch (infoLaborales)
            {
                case 1:
                    insert.id_informacion_laboral1 = (int)laborales.Rows[0]["id_informacion_laboral"];
                    insert.puesto1 = laborales.Rows[0]["puesto"].ToString();
                    insert.empresa1 = laborales.Rows[0]["empresa"].ToString();
                    insert.fecha_ingreso1 = (int)laborales.Rows[0]["fecha_ingreso"];
                    insert.fecha_egreso1 = (int)laborales.Rows[0]["fecha_egreso"];
                    insert.personal_a_cargo1 = (int)laborales.Rows[0]["personal_a_cargo"];
                    break;
                case 2:
                    insert.id_informacion_laboral1 = (int)laborales.Rows[0]["id_informacion_laboral"];
                    insert.id_informacion_laboral2 = (int)laborales.Rows[1]["id_informacion_laboral"];
                    insert.puesto1 = laborales.Rows[0]["puesto"].ToString();
                    insert.empresa1 = laborales.Rows[0]["empresa"].ToString();
                    insert.fecha_ingreso1 = (int)laborales.Rows[0]["fecha_ingreso"];
                    insert.fecha_egreso1 = (int)laborales.Rows[0]["fecha_egreso"];
                    insert.personal_a_cargo1 = (int)laborales.Rows[0]["personal_a_cargo"];

                    insert.puesto2 = laborales.Rows[1]["puesto"].ToString();
                    insert.empresa2 = laborales.Rows[1]["empresa"].ToString();
                    insert.fecha_ingreso2 = (int)laborales.Rows[1]["fecha_ingreso"];
                    insert.fecha_egreso2 = (int)laborales.Rows[1]["fecha_egreso"];
                    insert.personal_a_cargo2 = (int)laborales.Rows[1]["personal_a_cargo"];
                    break;
                case 3:
                    insert.id_informacion_laboral1 = (int)laborales.Rows[0]["id_informacion_laboral"];
                    insert.id_informacion_laboral2 = (int)laborales.Rows[1]["id_informacion_laboral"];
                    insert.id_informacion_laboral3 = (int)laborales.Rows[2]["id_informacion_laboral"];
                    insert.puesto1 = laborales.Rows[0]["puesto"].ToString();
                    insert.empresa1 = laborales.Rows[0]["empresa"].ToString();
                    insert.fecha_ingreso1 = (int)laborales.Rows[0]["fecha_ingreso"];
                    insert.fecha_egreso1 = (int)laborales.Rows[0]["fecha_egreso"];
                    insert.personal_a_cargo1 = (int)laborales.Rows[0]["personal_a_cargo"];

                    insert.puesto2 = laborales.Rows[1]["puesto"].ToString();
                    insert.empresa2 = laborales.Rows[1]["empresa"].ToString();
                    insert.fecha_ingreso2 = (int)laborales.Rows[1]["fecha_ingreso"];
                    insert.fecha_egreso2 = (int)laborales.Rows[1]["fecha_egreso"];
                    insert.personal_a_cargo2 = (int)laborales.Rows[1]["personal_a_cargo"];

                    insert.puesto3 = laborales.Rows[2]["puesto"].ToString();
                    insert.empresa3 = laborales.Rows[2]["empresa"].ToString();
                    insert.fecha_ingreso3 = (int)laborales.Rows[2]["fecha_ingreso"];
                    insert.fecha_egreso3 = (int)laborales.Rows[2]["fecha_egreso"];
                    insert.personal_a_cargo3 = (int)laborales.Rows[2]["personal_a_cargo"];
                    break;
                case 4:
                    insert.id_informacion_laboral1 = (int)laborales.Rows[0]["id_informacion_laboral"];
                    insert.id_informacion_laboral2 = (int)laborales.Rows[1]["id_informacion_laboral"];
                    insert.id_informacion_laboral3 = (int)laborales.Rows[2]["id_informacion_laboral"];
                    insert.id_informacion_laboral4 = (int)laborales.Rows[3]["id_informacion_laboral"];
                    insert.puesto1 = laborales.Rows[0]["puesto"].ToString();
                    insert.empresa1 = laborales.Rows[0]["empresa"].ToString();
                    insert.fecha_ingreso1 = (int)laborales.Rows[0]["fecha_ingreso"];
                    insert.fecha_egreso1 = (int)laborales.Rows[0]["fecha_egreso"];
                    insert.personal_a_cargo1 = (int)laborales.Rows[0]["personal_a_cargo"];

                    insert.puesto2 = laborales.Rows[1]["puesto"].ToString();
                    insert.empresa2 = laborales.Rows[1]["empresa"].ToString();
                    insert.fecha_ingreso2 = (int)laborales.Rows[1]["fecha_ingreso"];
                    insert.fecha_egreso2 = (int)laborales.Rows[1]["fecha_egreso"];
                    insert.personal_a_cargo2 = (int)laborales.Rows[1]["personal_a_cargo"];

                    insert.puesto3 = laborales.Rows[2]["puesto"].ToString();
                    insert.empresa3 = laborales.Rows[2]["empresa"].ToString();
                    insert.fecha_ingreso3 = (int)laborales.Rows[2]["fecha_ingreso"];
                    insert.fecha_egreso3 = (int)laborales.Rows[2]["fecha_egreso"];
                    insert.personal_a_cargo3 = (int)laborales.Rows[2]["personal_a_cargo"];

                    insert.puesto4 = laborales.Rows[3]["puesto"].ToString();
                    insert.empresa4 = laborales.Rows[3]["empresa"].ToString();
                    insert.fecha_ingreso4 = (int)laborales.Rows[3]["fecha_ingreso"];
                    insert.fecha_egreso4 = (int)laborales.Rows[3]["fecha_egreso"];
                    insert.personal_a_cargo4 = (int)laborales.Rows[3]["personal_a_cargo"];
                    break;
            }


            #endregion
        }



        //Modificacion

        public DataTable ActualizarDatos(Persona modify)
        {
            DataTable resultado = AccesoDatos.ActualizarDatos(modify);
            return resultado;
        }

        public void ActualizarDatosAcademicos(Persona modify, int cantidad)
        {
            Dictionary<int, (int id_informacion_academica, int? id_nivel, string institucion, int año_ingreso, int año_egreso, string titulo, int? id_progreso)> informacionAcademica
              = new Dictionary<int, (int, int?, string, int, int, string, int?)>
          {
                { 1, (modify.id_informacion_academica1, modify.id_nivel1, modify.institucion1, modify.año_ingreso1, modify.año_egreso1, modify.titulo1, modify.id_progreso1) },
                { 2, (modify.id_informacion_academica2,modify.id_nivel2, modify.institucion2, modify.año_ingreso2, modify.año_egreso2, modify.titulo2, modify.id_progreso2)},
                { 3, (modify.id_informacion_academica3,modify.id_nivel3, modify.institucion3, modify.año_ingreso3, modify.año_egreso3, modify.titulo3, modify.id_progreso3) },


          };
            for (int i = 1; i <= cantidad; i++)
            {
                int id_informacion_academica = informacionAcademica[i].id_informacion_academica;
                int? id_nivel = informacionAcademica[i].id_nivel;
                string institucion = informacionAcademica[i].institucion;
         
                int año_ingreso = informacionAcademica[i].año_ingreso;
                int año_egreso = informacionAcademica[i].año_egreso;
                string titulo = informacionAcademica[i].titulo;
                int? id_progreso = informacionAcademica[i].id_progreso;
                AccesoDatos.ActualizarDatosAcademicos(id_informacion_academica, id_nivel, institucion, año_ingreso, año_egreso, titulo, id_progreso);
            }
        }




        public void ActualizarDatosLaborales(Persona modify, int cantidad)
        {
            Dictionary<int, (int id_informacion_laboral,string puesto, string empresa, int fecha_ingreso, int fecha_egreso, int personal_a_cargo)> informacionLaboral
                  = new Dictionary<int, (int,string, string, int, int, int)>
              {
                { 1, (modify.id_informacion_laboral1,modify.puesto1, modify.empresa1, modify.fecha_ingreso1,  modify.fecha_egreso1, modify.personal_a_cargo1) },
                { 2, (modify.id_informacion_laboral2,modify.puesto2, modify.empresa2, modify.fecha_ingreso2,  modify.fecha_egreso2, modify.personal_a_cargo2) },
                { 3, (modify.id_informacion_laboral3,modify.puesto3, modify.empresa3, modify.fecha_ingreso3,  modify.fecha_egreso3, modify.personal_a_cargo3) },
                { 4, (modify.id_informacion_laboral4,modify.puesto4, modify.empresa4, modify.fecha_ingreso4,  modify.fecha_egreso4, modify.personal_a_cargo4) }
                                                                               
              };
            for (int i = 1; i <= cantidad; i++)
            {
                int id_informacion_laboral = informacionLaboral[i].id_informacion_laboral;
                string _puesto = informacionLaboral[i].puesto;
                string _empresa = informacionLaboral[i].empresa;
                int _fecha_ingreso = informacionLaboral[i].fecha_ingreso;
                int _fecha_egreso = informacionLaboral[i].fecha_egreso;
                int _personal_a_cargo = informacionLaboral[i].personal_a_cargo;
                AccesoDatos.ActualizarDatosLaborales(id_informacion_laboral, _puesto, _empresa, _fecha_ingreso, _fecha_egreso, _personal_a_cargo);

            }
        }

        public void ActualizarTelefono(Persona modify, int id_persona)
        {
            AccesoDatos.ActualizarTelefono(id_persona, modify.telefono, modify.id_tipo, true);
            AccesoDatos.ActualizarTelefono(id_persona, modify.telefono_alternativo, modify.id_tipo_alternativo, false, modify.contacto);
        }


        public void ActualizarIdioma(Persona modify ,int id_persona )
        {
            AccesoDatos.ActualizarIdioma(id_persona,2,modify.nivel_Es);
            AccesoDatos.ActualizarIdioma(id_persona,1,modify.nivel_En);
        }


        //eliminacion


        public void BajaPersona (int id_persona)
        {
            AccesoDatos.BajaPersona(id_persona);
        }
        public void ReactivarPersona(int id_persona)
        {
            AccesoDatos.ReactivarPersona(id_persona);
        }

    }

}
