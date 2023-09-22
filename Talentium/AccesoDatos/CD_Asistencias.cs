using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class CD_Asistencias : CD_EjecutarSP
    {

        //traer area
        public DataTable Areas()
        {
            DataTable resultado = EjecutarConsultasSinParam("consultarAreas_sp");

            return resultado;
        }

        //traer puesto
        public DataTable Puestos()
        {
            DataTable resultado = EjecutarConsultasSinParam("consultarPuestos_sp");

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
        public DataTable ConsultaAsistenciasMod(int area, int puesto, string cuil)
        {
            SqlParameter param1 = new SqlParameter("@id_area", area) { SqlDbType = SqlDbType.Int };
            SqlParameter param2 = new SqlParameter("@id_puesto", puesto) { SqlDbType = SqlDbType.Int };
            SqlParameter param3 = new SqlParameter("@cuil", cuil) { SqlDbType = SqlDbType.NVarChar };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2, param3 };
            DataTable resultado = EjecutarConsultas("FiltroAltaAsistencias_SP", listaParametros.ToArray());

            return resultado;
        }
        //traer el cuil segun la persona
        public DataTable ConsultarCuil(string cuil)
        {
            SqlParameter param3 = new SqlParameter("@cuil", cuil) { SqlDbType = SqlDbType.NVarChar };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param3 };
            DataTable resultado = EjecutarConsultas("", listaParametros.ToArray());

            return resultado;
        }
    }
}
