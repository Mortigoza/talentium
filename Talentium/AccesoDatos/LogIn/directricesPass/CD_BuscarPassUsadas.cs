using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos.Loguin.directricesPass
{
    public class CD_BuscarPassUsadas : CD_EjecutarConsultasSP
    {
        public DataTable CDBuscarPass(int IdUser, string Pass)
        {
            SqlParameter param1 = new SqlParameter("@IdUser", IdUser) { SqlDbType = SqlDbType.Int };
            SqlParameter param2 = new SqlParameter("@Pass", Pass) { SqlDbType = SqlDbType.NVarChar };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2 };

            return EjecutarConsultas("Pass_ConsPassUsadas", listaParametros.ToArray());
        }
    }
}
