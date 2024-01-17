using Comun;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class CD_AsignarCapacitaciones: CD_EjecutarSP
    {
        public DataTable ConsultarCapacitacionesLst()
        {
            //SqlParameter param1 = new SqlParameter("@id_capacitacion", id_capacitacion) { SqlDbType = SqlDbType.Int };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { };

            DataTable resultado = EjecutarConsultas("consultar_capacitaciones_sp", listaParametros.ToArray());
            return resultado;
        }
        public DataTable ConsultarPersonal(string cuit, string nombre, string apellido, int area)
        {
            SqlParameter param1 = new SqlParameter("@cuil", cuit) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param2 = new SqlParameter("@nombre", nombre) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param3 = new SqlParameter("@apellido", apellido) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param4 = new SqlParameter("@id_area", area) { SqlDbType = SqlDbType.NVarChar };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2, param3, param4 };

            DataTable resultado = EjecutarConsultas("consultar_personal_asignar_capacitaciones_sp", listaParametros.ToArray());
            return resultado;
        }
    }
}
