using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using Comun;
using System.Linq.Expressions;

namespace AccesoDatos
{
    public class CD_AccesoBD: CD_EjecutarSP
    {
        //Login
        /*  public bool Login(String usuario, string pass)
          {

              using (var connection = GetConnection())
              {
                  connection.Open();
                  using (var command = new SqlCommand())
                  {
                      command.Connection = connection;
                      command.CommandText = "select *from Usuarios where usuario=@user and password=@pass";
                      command.Parameters.AddWithValue("@user", usuario);
                      command.Parameters.AddWithValue("@pass", pass);
                      command.CommandType = CommandType.Text;
                      SqlDataReader reader = command.ExecuteReader();
                      if (reader.HasRows)
                      {
                          return true;
                      }
                      else
                          return false;
                  }
              }
          }*/
        public void Buscar(string usuario, string pass)
        {
            SqlParameter param1 = new SqlParameter("@usuario", usuario) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param2 = new SqlParameter("@password", pass) { SqlDbType = SqlDbType.NVarChar };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2 };
            DataTable resultado = EjecutarConsultas("loginConsulta_sp", listaParametros.ToArray());

            userCache.id = (int)resultado.Rows[0][0];

            try { userCache.idPersona = (int)resultado.Rows[0][1]; }
            catch { userCache.idPersona = null; }

            userCache.usuario = (string)resultado.Rows[0][2];
            userCache.password = (string)resultado.Rows[0][3];
            userCache.alta = (DateTime)resultado.Rows[0][4];

            try { userCache.baja = (DateTime)resultado.Rows[0][5]; }
            catch { userCache.baja = null; }

            userCache.cambiaCada = (int)resultado.Rows[0][6];

            try { userCache.ultimoCambio = (DateTime)resultado.Rows[0][7]; }
            catch { userCache.ultimoCambio = null; }
            try { userCache.desactivacion = (DateTime)resultado.Rows[0][8]; }
            catch { userCache.desactivacion = null; }

            userCache.nueva = (bool)resultado.Rows[0][9];

            try { userCache.bloqueo = (DateTime)resultado.Rows[0][10]; }
            catch { userCache.bloqueo = null; }

            userCache.digito = (string)resultado.Rows[0][11];
        }

    }
}
