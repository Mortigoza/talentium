using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaAccesoDatos.Loguin
{
    public class CD_BloquearUsuario : CD_EjecutarConsultasSP
    {
        public void BloquearUsuario(int IdUser)
        {
            SqlParameter param1 = new SqlParameter("@IdUser", IdUser){SqlDbType = SqlDbType.Int};
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            _ = EjecutarConsultas("Login_BloquearUsuario", listaParametros.ToArray(), true);
        }
    }
}
