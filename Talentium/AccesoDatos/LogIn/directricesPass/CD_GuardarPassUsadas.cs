using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos.Loguin.directricesPass
{
    public class CD_GuardarPassUsadas : CD_EjecutarConsultasSP
    {
        public CD_GuardarPassUsadas(int IdUser, string Pass)
        {
            Guardar(IdUser,Pass);
        }

        private void Guardar(int idUser, string Pass)
        {
            SqlParameter param1 = new SqlParameter("@IdUser", idUser){SqlDbType = SqlDbType.Int};
            SqlParameter param2 = new SqlParameter("@Pass", Pass) { SqlDbType = SqlDbType.NVarChar};
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2 };
        _ = EjecutarConsultas("Pass_AltaPassUsadas", listaParametros.ToArray(), true);
        }
    }
}
