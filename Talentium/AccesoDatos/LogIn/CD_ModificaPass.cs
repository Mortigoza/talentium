using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaAccesoDatos.Loguin
{
    public class CD_ModificaPass : CD_EjecutarConsultasSP
    {
        public void ModificaPass(int IdUser, String Pass, bool PassNueva, int CodVerif )
        {
            SqlParameter param1 = new SqlParameter("@IdUser", IdUser){SqlDbType = SqlDbType.Int};
            SqlParameter param2 = new SqlParameter("@Pass", Pass){SqlDbType = SqlDbType.NVarChar};
            SqlParameter param3 = new SqlParameter("@PassNueva", PassNueva){SqlDbType = SqlDbType.Bit};
            SqlParameter param4 = new SqlParameter("@CodVerif", CodVerif){SqlDbType = SqlDbType.Bit};

            List<SqlParameter> listaParametros = new List<SqlParameter>(){param1, param2, param3, param4};

            _ = EjecutarConsultas("Login_CambiarPassword", listaParametros.ToArray(), true);
        }
    }
}
