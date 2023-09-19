using Comun;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class CD_UpUsuario: CD_EjecutarSP
    {
        public void UpUsuario(int id_usuario, string usuario, string password, int cambia_cada, string digito, string mail)
        {
            SqlParameter param1 = new SqlParameter("@id_usuario", id_usuario) { SqlDbType = SqlDbType.Int };
            SqlParameter param2 = new SqlParameter("@usuario", usuario) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param3 = new SqlParameter("@password", password) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param4 = new SqlParameter("@cambia_cada", cambia_cada) { SqlDbType = SqlDbType.Int };
            SqlParameter param5 = new SqlParameter("@digito", digito) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param6 = new SqlParameter("@email", mail) { SqlDbType = SqlDbType.NVarChar };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2, param3, param4, param5, param6 };

            EjecutarConsultas("up_usuario_sp", listaParametros.ToArray());
        }
    }
}
