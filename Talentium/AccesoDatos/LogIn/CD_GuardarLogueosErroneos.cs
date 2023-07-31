using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaAccesoDatos.Loguin
{
    public class CD_GuardarLogueosErroneos : CD_EjecutarConsultasSP
    {
        public CD_GuardarLogueosErroneos(int IdUser)
        {
            Guardar(IdUser);
        }

        private void Guardar(int idUser)
        {
            SqlParameter param1 = new SqlParameter("@IdUser", idUser){SqlDbType = SqlDbType.Int};
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            _ = EjecutarConsultas("Login_GuardarLogUser", listaParametros.ToArray(), true);
        }

    }
}
