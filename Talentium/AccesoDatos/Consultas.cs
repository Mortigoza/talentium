using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class Consulta : Conexion
    {
        private readonly DataTable DT = new DataTable();

        public DataTable Ejecutar(string sSql)
        {
            if (GetConexion() is SqlConnection)
            {
                using (SqlConnection CNN = GetConexion())
                {
                    CNN.Open();
                    using (SqlCommand comando = new SqlCommand(sSql, CNN))
                    {
                        DT.Load(comando.ExecuteReader());
                    }
                }
            }
            return DT;
        }
    }
}
