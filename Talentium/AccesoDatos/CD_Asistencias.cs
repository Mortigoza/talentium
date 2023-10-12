using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comun;
namespace AccesoDatos
{
    public class CD_Asistencias : CD_EjecutarSP
    {
        C_Asistencias modelo = new C_Asistencias();  
        //traer area
        public DataTable Areas()
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>() { };
            DataTable resultado = EjecutarConsultas("consultarAreas_sp", listaParametros.ToArray());

            return resultado;
        }

        //traer puesto
        public DataTable Puestos(int id)
        {
            SqlParameter param1 = new SqlParameter("@id_areas", id) { SqlDbType = SqlDbType.Int };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1};
            DataTable resultado = EjecutarConsultas("consultarPuestos_sp", listaParametros.ToArray());

            return resultado;
        }
        //traer motivo
        public DataTable Motivos()
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>() { };
            DataTable resultado = EjecutarConsultas("consultarMotivos_sp", listaParametros.ToArray());

            return resultado;
        }

        //el filtro de alta trae nombre, apellido, area, puesto

        public DataTable ConsultaAsistencias(int area, int puesto, string cuil)
        {
            SqlParameter param1 = new SqlParameter("@id_area", area) { SqlDbType = SqlDbType.Int };
            SqlParameter param2 = new SqlParameter("@id_puesto", puesto) { SqlDbType = SqlDbType.Int };
            SqlParameter param3 = new SqlParameter("@cuil", cuil) { SqlDbType = SqlDbType.NVarChar };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2, param3 };
            DataTable resultado = EjecutarConsultas("FiltroAltaAsistencias_SP", listaParametros.ToArray());

            return resultado;
        }

        //el filtro para modificar y consultar trae: nombre, apellido, area, puesto, justificada
        public DataTable ConsultaAsistenciasMod(int idPersona, DateTime fecha, DateTime fechaDesde, DateTime fechaHasta)
        {
            SqlParameter param1 = new SqlParameter("@id_persona", idPersona) { SqlDbType = SqlDbType.Int };
            SqlParameter param2 = new SqlParameter("@fecha", fecha) { SqlDbType = SqlDbType.Date };
            SqlParameter param3 = new SqlParameter("@fecha_desde", fechaDesde) { SqlDbType = SqlDbType.Date };
            SqlParameter param4 = new SqlParameter("@fecha_hasta", fechaHasta) { SqlDbType = SqlDbType.Date };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2, param3 };
            DataTable resultado = EjecutarConsultas("FiltroModConsAsistencias_SP", listaParametros.ToArray());

            return resultado;
        }
        //traer el cuil segun la persona
        /* public DataTable ConsultarCuil(string cuil)
         {
             SqlParameter param3 = new SqlParameter("@cuil", cuil) { SqlDbType = SqlDbType.NVarChar };

             List<SqlParameter> listaParametros = new List<SqlParameter>() { param3 };
             DataTable resultado = EjecutarConsultas("", listaParametros.ToArray());

             return resultado;
         }*/
        //insertar asistencia
        public void CargarAsistencia()
        {
            SqlParameter param1 = new SqlParameter("@id_persona", modelo.idPersona) { SqlDbType = SqlDbType.Int };
            SqlParameter param2 = new SqlParameter("@periodo", modelo.periodo) { SqlDbType = SqlDbType.Bit };
            SqlParameter param3 = new SqlParameter("@fecha", modelo.fecha) { SqlDbType = SqlDbType.Date };
            SqlParameter param4 = new SqlParameter("@fecha_desde", modelo.fecha_desde) { SqlDbType = SqlDbType.Date };
            SqlParameter param5 = new SqlParameter("@fecha_hasta", modelo.fecha_hasta) { SqlDbType = SqlDbType.Date };
            SqlParameter param6 = new SqlParameter("@id_motivo", modelo.idMotivo) { SqlDbType = SqlDbType.Int };
            SqlParameter param7 = new SqlParameter("@otro_motivo", modelo.otro_motivo) { SqlDbType = SqlDbType.NChar};
            SqlParameter param8 = new SqlParameter("@justificada", modelo.justificada) { SqlDbType = SqlDbType.Bit };
            SqlParameter param9 = new SqlParameter("@observaciones", modelo.observaciones) { SqlDbType = SqlDbType.NVarChar};


            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2, param3, param4, param5, param6, param7, param8, param9 };

            DataTable resultado = EjecutarConsultas("alta_asistencias_sp", listaParametros.ToArray(), true);
        }
    }
}
