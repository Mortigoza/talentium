using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaAccesoDatos.Loguin
{
    public class CD_BuscarUser : CD_EjecutarConsultasSP
    {
        public int CDbuscarUser(string user)
        {
            SqlParameter param1 = new SqlParameter("@user", user){SqlDbType = SqlDbType.NVarChar};
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            DataTable resultado = EjecutarConsultas("Login_User", listaParametros.ToArray());
            int Id = (int)resultado.Rows[0][0];
            return Id;
        }
    }
}
