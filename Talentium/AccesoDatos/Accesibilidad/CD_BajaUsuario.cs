using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class CD_BajaUsuario: CD_EjecutarSP
    {
        public void BajaUsuario(int id_usuario)
        {
            SqlParameter param1 = new SqlParameter("@id_usuario", id_usuario) { SqlDbType = SqlDbType.Int };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };

            EjecutarConsultas("baja_usuario_sp", listaParametros.ToArray(), true);
        }
    }
}
