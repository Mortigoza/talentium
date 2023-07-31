using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos.Loguin
{
    public class CD_TraerPersona : CD_EjecutarConsultasSP
    {
        public DataTable CDtraerPersona(string user)
        {
            SqlParameter param1 = new SqlParameter("@user", user){SqlDbType = SqlDbType.NVarChar};
            List<SqlParameter> listaParametros = new List<SqlParameter>(){param1};

            return EjecutarConsultas("Login_TraerPersona", listaParametros.ToArray());
        }
    }
}
