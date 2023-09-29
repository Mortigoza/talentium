using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Analisis_y_reportes
{
    public class CD_ConsultaCertificacionServicios: CD_EjecutarSP
    {
        public DataTable ConsultaCertificacionServicios(string cuit, string nombre, string apellido, int etapa)
        {
            SqlParameter param1 = new SqlParameter("@cuit", cuit) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param2 = new SqlParameter("@nombre", nombre) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param3 = new SqlParameter("@apellido", apellido) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param4 = new SqlParameter("@etapa", etapa) { SqlDbType = SqlDbType.Int };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2, param3, param4 };

            DataTable resultado = EjecutarConsultas("consultar_certificacion_sp", listaParametros.ToArray());
            return resultado;
        }
    }
}
