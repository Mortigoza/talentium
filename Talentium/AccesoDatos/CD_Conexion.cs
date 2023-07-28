using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace AccesoDatos
{

    public abstract class CD_Conexion
    {
        private readonly string connectionstring;
        public CD_Conexion()
        {
            connectionstring = "Server=localhost\\SQLEXPRESS;DataBase= loginRRHH;Integrated Security=true";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionstring);
        }


    }
}
