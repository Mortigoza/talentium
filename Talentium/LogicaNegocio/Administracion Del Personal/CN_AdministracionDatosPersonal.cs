using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using System.Data;
using System.Data.SqlClient;
using Comun;

namespace LogicaNegocio.Administracion_Del_Personal
{
    public class CN_AdministracionDatosPersonal 
    {
   
  

        public void InsertarPersona(Persona insert)
        {
            try
            {
                // Crear un array de parámetros para el procedimiento almacenado
                SqlParameter[] parametros = new SqlParameter[]
                {
                new SqlParameter("@apellidos", insert.apellidos),
                new SqlParameter("@nombres", insert.nombres),
                new SqlParameter("@id_tipo_doc", insert.id_tipo_doc),
                new SqlParameter("@nro_doc", insert.nro_doc),
                new SqlParameter("@cuit_cuil", insert.cuit_cuil),
                new SqlParameter("@calle", insert.calle),
                new SqlParameter("@nro", insert.nro),
                new SqlParameter("@dpto", insert.dpto),
                new SqlParameter("@piso", insert.piso),
                new SqlParameter("@id_localidad", insert.id_localidad),
                new SqlParameter ("id_puesto", insert.id_puesto),
                new SqlParameter ("id_area", insert.id_area),
                new SqlParameter("@email", insert.email),
                new SqlParameter("@id_nacionalidad", insert.id_nacionalidad),
                new SqlParameter("@id_genero", insert.id_genero),
               new SqlParameter ( "@fecha_nacimiento", insert.fecha_nacimiento),
                new SqlParameter("@id_estado_civil", insert.id_estado_civil),
                new SqlParameter("@hijos", insert.hijos),
                new SqlParameter("@id_convenio", insert.id_convenio),
                  new SqlParameter("@foto_perfil", insert.foto_perfil),

                //new SqlParameter("@telefono", telefono),
                //new SqlParameter("@tipo", tipo),
                //new SqlParameter("@telefono_alternativo", telefono_alternativo),
                //new SqlParameter("@tipo2", tipo2),
                //new SqlParameter("@contacto", contacto),
                //new SqlParameter("@codigo_postal", codigo_postal),
                //new SqlParameter("@partido", partido),
                //new SqlParameter("@provincia", provincia),
                new SqlParameter ("id_nivel", insert.id_nivel),
                new SqlParameter("institucion", insert.institucion),
                new SqlParameter("carrera", insert.carrera),
                new SqlParameter("año_ingreso" , insert.año_ingreso),
                new SqlParameter("año_egreso",insert. año_egreso),
                new SqlParameter("titulo", insert.titulo),
                new SqlParameter("puesto", insert.puesto),
                new SqlParameter("empresa", insert.empresa),
                new SqlParameter("fecha_ingreso" , insert.fecha_ingreso),
                new SqlParameter("fecha_egreso", insert.fecha_egreso),
                new SqlParameter("personal_a_cargo", insert.personal_a_cargo),


                };

                // Llamar al método EjecutarConsultas de la capa de datos para ejecutar el procedimiento almacenado
                CD_EjecutarSP capaDatos = new CD_EjecutarSP();
                capaDatos.EjecutarConsultas("InsertarPersonas_sp", parametros);

                // Realizar cualquier otra lógica después de la inserción si es necesario
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante la inserción
                // Puedes registrar el error, lanzar una excepción personalizada, etc.
                throw new Exception("Error al insertar persona en la base de datos: " + ex.Message);
            }

        }

    }
}
