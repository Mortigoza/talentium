using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Comun;

namespace AccesoDatos.Administracion_Personal
{
    public class CD_AccesoBDPersonacs : CD_EjecutarSP
    {
        public void InsertarPersona( Persona insert)
        {
            SqlParameter param1 = new SqlParameter("@apellidos", insert.apellidos) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param2 = new SqlParameter("@nombres", insert.nombres) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param3 = new SqlParameter("@id_tipo_doc", insert.id_tipo_doc) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param4 = new SqlParameter("@nro_doc", insert.nro_doc) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param5 = new SqlParameter("@cuit_cuil", insert.cuit_cuil) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param6 = new SqlParameter("@calle", insert.calle) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param7 = new SqlParameter("@nro", insert.nro) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param8 = new SqlParameter("@dpto", insert.dpto) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param9 = new SqlParameter("@piso", insert.piso) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param10 = new SqlParameter("@id_localidad", insert.id_localidad) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param11 = new SqlParameter("@id_puesto", insert.id_puesto) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param12 = new SqlParameter("@id_area", insert.id_area) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param13 = new SqlParameter("@email", insert.email) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param14 = new SqlParameter("@id_nacionalidad", insert.id_nacionalidad) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param15 = new SqlParameter("@id_genero", insert.id_genero) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param16 = new SqlParameter("@fecha_nacimiento", insert.fecha_nacimiento) { SqlDbType = SqlDbType.DateTime };
            SqlParameter param17 = new SqlParameter("@id_estado_civil", insert.id_estado_civil) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param18 = new SqlParameter("@hijos", insert.hijos) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param19 = new SqlParameter("@id_convenio", insert.id_convenio) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param20 = new SqlParameter("@foto_perfil", insert.foto_perfil) { SqlDbType = SqlDbType.VarChar };
            //SqlParameter param21 = new SqlParameter("@telefono", telefono) { SqlDbType = SqlDbType.VarChar };
            //SqlParameter param22 = new SqlParameter("@tipo", tipo) { SqlDbType = SqlDbType.VarChar };
            //SqlParameter param23 = new SqlParameter("@telefono_alternativo", telefono_alternativo) { SqlDbType = SqlDbType.VarChar };
            //SqlParameter param24 = new SqlParameter("@tipo2", tipo2) { SqlDbType = SqlDbType.VarChar };
            //SqlParameter param25 = new SqlParameter("@contacto", contacto) { SqlDbType = SqlDbType.VarChar };
            //SqlParameter param26 = new SqlParameter("@codigo_postal", codigo_postal) { SqlDbType = SqlDbType.VarChar };
            //SqlParameter param27 = new SqlParameter("@partido", partido) { SqlDbType = SqlDbType.VarChar };
            //SqlParameter param28 = new SqlParameter("@provincia", provincia) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param29 = new SqlParameter("id_nivel", insert.id_nivel) {SqlDbType = SqlDbType.VarChar };
            SqlParameter param30 = new SqlParameter("@institucion", insert.institucion) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param31 = new SqlParameter("@carrera", insert.carrera) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param32 = new SqlParameter("@año_ingreso", insert.año_ingreso) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param33 = new SqlParameter("@año_egreso", insert.año_egreso) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param34 = new SqlParameter("@titulo", insert.titulo) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param35 = new SqlParameter("@puesto", insert.puesto) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param36 = new SqlParameter("@empresa", insert.empresa) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param37 = new SqlParameter("@fecha_ingreso", insert.fecha_ingreso) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param38 = new SqlParameter("@fecha_egreso", insert.fecha_egreso) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param39 = new SqlParameter("@personal_a_cargo", insert.personal_a_cargo) { SqlDbType = SqlDbType.VarChar };


            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2, param3, param4,param5,param6,
                param7,param8,param9,param10,param11,param12,param13
                ,param14,param15,param16,param17,param18,param19,param20,/*param21,param22,param23,param24,
                                                  * param25,param26,param27,param28,*/ param29, param30, param31,param32,param33,param34,param35,param36,param37,param38,param39};

            DataTable resultado = EjecutarConsultas("InsertarPersonas_sp", listaParametros.ToArray(), true);

        }

        //public void EliminarPersona(InsertPersona insert)
        //{

        //}
        //public void EliminarPersona(InsertPersona insert, string hola)
        //{

        //}

        //public void ConsultarPersona(InsertPersona insert)
        //{
        //    EliminarPersona(insert);

        //}

    }
}
