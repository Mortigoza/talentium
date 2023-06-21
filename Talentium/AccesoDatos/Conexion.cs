using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public abstract class Conexion
    {
        // Cadena SQL Server
        private const string cadena = "data source =(local); database = ESCUELA; integrated security = true";

        //PROPERTY PARA SQLSERVER
        protected SqlConnection GetConexion() // property que devuelve la conexion
        {
            return new SqlConnection(cadena);

        }
    }
}
