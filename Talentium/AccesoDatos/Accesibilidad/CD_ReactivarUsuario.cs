using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class CD_ReactivarUsuario: CD_EjecutarSP
    {
        public void ReactivarUsuario(int id_usuario)
        {
            SqlParameter param1 = new SqlParameter("@id_usuario", id_usuario) { SqlDbType = SqlDbType.Int };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };

            EjecutarConsultas("reactivar_usuario_sp", listaParametros.ToArray(), true);
        }
    }
}
