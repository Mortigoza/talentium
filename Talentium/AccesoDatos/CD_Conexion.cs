using System.Data.SqlClient;


namespace AccesoDatos
{

    public abstract class CD_Conexion
    {
        private readonly string connectionstring;
        public CD_Conexion()
        {
            //connectionstring = "Server=localhost\\SQLEXPRESS;DataBase= loginRRHH;Integrated Security=true";
            connectionstring = "Server=(local);DataBase= bdmai;Integrated Security=true";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionstring);
        }


    }
}
