using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Accesibilidad
{
    public class CD_UpPerfil: CD_EjecutarSP
    {
        public void UpPerfil(int id_perfil, string nombrePerfil, string descripcion)
        {
            SqlParameter param1 = new SqlParameter("@id_perfil", id_perfil) { SqlDbType = SqlDbType.Int };
            SqlParameter param2 = new SqlParameter("@nombrePerfil", nombrePerfil) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param3 = new SqlParameter("@descripcion", descripcion) { SqlDbType = SqlDbType.NVarChar };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2, param3 };

            EjecutarConsultas("up_perfil_sp", listaParametros.ToArray());
        }
    }
}
