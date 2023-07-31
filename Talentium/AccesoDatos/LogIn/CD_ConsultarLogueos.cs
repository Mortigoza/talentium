using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaAccesoDatos.Loguin
{
    public class CD_ConsultarLogueos : CD_EjecutarConsultasSP
    {
        public int Buscar(int idUser)
        {
            SqlParameter param1 = new SqlParameter("@IdUser", idUser){SqlDbType = SqlDbType.Int};
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            DataTable resultado = EjecutarConsultas("Login_CantLogError", listaParametros.ToArray());
            int Id = (int)resultado.Rows[0][0];
            return Id;
        }
    }
}
