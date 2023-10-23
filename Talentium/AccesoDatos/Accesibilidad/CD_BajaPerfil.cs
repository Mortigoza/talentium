using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Accesibilidad
{
    public class CD_BajaPerfil: CD_EjecutarSP
    {
        public void BajaPerfil(int id_perfil)
        {
            SqlParameter param1 = new SqlParameter("@id_perfil", id_perfil) { SqlDbType = SqlDbType.Int };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };

            EjecutarConsultas("baja_perfil_sp", listaParametros.ToArray(), true);
        }
    }
}
