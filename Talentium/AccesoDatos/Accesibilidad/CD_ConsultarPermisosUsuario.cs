using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class CD_ConsultarPermisosUsuario: CD_EjecutarSP
    {
        public DataTable ConsultarPermisosUsuario(int id_usuario)
        {
            SqlParameter param1 = new SqlParameter("@id_usuario", id_usuario) { SqlDbType = SqlDbType.Int };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };

            DataTable resultado = EjecutarConsultas("consultar_permisos_usuario_sp", listaParametros.ToArray());
            return resultado;
        }
    }
}
