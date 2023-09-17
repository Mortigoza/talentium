using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class CD_ConsultarUsuario: CD_EjecutarSP
    {
        public DataTable ConsultarUsuario(string usuario, string nombre, string apellido, int area)
        {
            SqlParameter param1 = new SqlParameter("@usuario", usuario) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param2 = new SqlParameter("@nombre", nombre) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param3 = new SqlParameter("@apellido", apellido) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param4 = new SqlParameter("@id_area", area) { SqlDbType = SqlDbType.NVarChar };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2, param3, param4 };

            DataTable resultado = EjecutarConsultas("consultar_usuarios_sp", listaParametros.ToArray());
            return resultado;
        }
    }
}
