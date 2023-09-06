using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using Comun;
using System.Linq.Expressions;

namespace AccesoDatos
{
    public class CD_AccesoBD : CD_EjecutarSP
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
        //valida si existe el usuario y consulta la fh_cod_email y el campo cod email
        public DataTable EmailDeRecupero(string usuario) 
        {
            SqlParameter param1 = new SqlParameter("@usuario", usuario) { SqlDbType = SqlDbType.NVarChar };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            DataTable resultado = EjecutarConsultas("ConsEmailRecupero_sp", listaParametros.ToArray());
                UserCache.id =Convert.ToInt32(resultado.Rows[0][2]);
                UserCache.usuario = (string)resultado.Rows[0][4];

            return resultado;
        }
        public DataTable ValidCode(int id)
        {
            SqlParameter param1 = new SqlParameter("@id_usuario", id) { SqlDbType = SqlDbType.Int };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            DataTable resultado = EjecutarConsultas("ValidarCodEmail_sp", listaParametros.ToArray());
            return resultado;
        }

        //inserta la fh_cod_email y el campo cod email
        public void Buscar(string usuario)
        {
            SqlParameter param1 = new SqlParameter("@usuario", usuario) { SqlDbType = SqlDbType.NVarChar };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            DataTable resultado = EjecutarConsultas("loginConsulta2_sp", listaParametros.ToArray());
          
            UserCache.id = (int)resultado.Rows[0][0];

            UserCache.idPersona = (int)resultado.Rows[0][1];

            UserCache.usuario = (string)resultado.Rows[0][2];
            UserCache.password = (string)resultado.Rows[0][3];
            UserCache.alta = (DateTime)resultado.Rows[0][4];

            UserCache.baja = (DateTime)resultado.Rows[0][5] ; 
           

            UserCache.cambiaCada = (int)resultado.Rows[0][6];

            UserCache.ultimoCambio = (DateTime)resultado.Rows[0][7];
            UserCache.bloqueo = (DateTime)resultado.Rows[0][8];

            //UserCache.nueva = (bool)resultado.Rows[0][9];

            UserCache.digito = (string)resultado.Rows[0][11];
            UserCache.intentos = (int)resultado.Rows[0][12];
        }
        public void Bloquear(int id, DateTime? hBloqueo)
        {
            List<SqlParameter> listaParametros;
            SqlParameter param1 = new SqlParameter("@ID", id) { SqlDbType = SqlDbType.Int };
            SqlParameter param2 = new SqlParameter("@bloqueo", hBloqueo) { SqlDbType = SqlDbType.DateTime };
            listaParametros = new List<SqlParameter>() { param1, param2 };

            DataTable resultado = EjecutarConsultas("bloqueo_usuario_sp", listaParametros.ToArray(), true);
        }
        public void Intentos(int id, int intento)
        {
            SqlParameter param1 = new SqlParameter("@ID", id) { SqlDbType = SqlDbType.Int };
            SqlParameter param2 = new SqlParameter("@intento", intento) { SqlDbType = SqlDbType.Int };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2 };
            DataTable resultado = EjecutarConsultas("intento_usuario_sp", listaParametros.ToArray(), true);
        }
        public void RestaurarIntentos(int id, int intentos)
        {
            SqlParameter param1 = new SqlParameter("@ID", id) { SqlDbType = SqlDbType.Int };
            SqlParameter param2 = new SqlParameter("@intentos", intentos) { SqlDbType = SqlDbType.Int };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2 };

            DataTable resultado = EjecutarConsultas("restablecimiento_de_intentos_sp", listaParametros.ToArray(), true);
        }
        public void CargarCodyFHRecupero( int id, string cod, DateTime fechaCaducidad )
        {
            SqlParameter param1 = new SqlParameter("@id_usuario", id) { SqlDbType = SqlDbType.Int };
            SqlParameter param2 = new SqlParameter("@fh_cod_email", fechaCaducidad) { SqlDbType = SqlDbType.DateTime };
            SqlParameter param3 = new SqlParameter("@cod_email", cod) { SqlDbType = SqlDbType.NChar };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2, param3 };
            
                DataTable resultado = EjecutarConsultas("upCodFechaRecupero_sp", listaParametros.ToArray(), true);
        
        }

        public void upPolPass(bool min_carct, bool comb_may, bool num_letras, bool caract_esp, bool contra_ant, bool datos_per)
        {
            SqlParameter param1 = new SqlParameter("@min_caracteres", min_carct) { SqlDbType = SqlDbType.Bit };
            SqlParameter param2 = new SqlParameter("@comb_mayus", comb_may) { SqlDbType = SqlDbType.Bit };
            SqlParameter param3 = new SqlParameter("@num_letras", num_letras) { SqlDbType = SqlDbType.Bit };
            SqlParameter param4 = new SqlParameter("@caract_especial", caract_esp) { SqlDbType = SqlDbType.Bit };
            SqlParameter param5 = new SqlParameter("@contra_anteriores", contra_ant) { SqlDbType = SqlDbType.Bit };
            SqlParameter param6 = new SqlParameter("@datos_personales", datos_per) { SqlDbType = SqlDbType.Bit };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2, param3, param4, param5, param6 };

            DataTable resultado = EjecutarConsultas("upPoliticaPass_sp", listaParametros.ToArray(), true);

        }
        public void ConsultaPoliticaPass()
        {
           
            List<SqlParameter> listaParametros = new List<SqlParameter>() { };

            DataTable resultado = EjecutarConsultas("consPoliticaPass_sp", listaParametros.ToArray());

            ConfigCache.caracteres = (bool)resultado.Rows[0][1];
            ConfigCache.mayusculas = (bool)resultado.Rows[0][2];
            ConfigCache.numeros = (bool)resultado.Rows[0][3];
            ConfigCache.especiales = (bool)resultado.Rows[0][4];
            ConfigCache.passAnteriores = (bool)resultado.Rows[0][5];
            ConfigCache.noDatosPersonales = (bool)resultado.Rows[0][6];
        }

        public DataTable ConsultaPregSeg(int usuario)
        {
            SqlParameter param1 = new SqlParameter("@id_usuario", usuario) { SqlDbType = SqlDbType.Int };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            DataTable resultado = EjecutarConsultas("consultarPreguntas_sp", listaParametros.ToArray());

            return resultado;
        }

        public void InsertarNuevaPass(string user, string pass, string dig)
        {
            SqlParameter param1 = new SqlParameter("@usuario", user) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param2 = new SqlParameter("@password", pass) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param3 = new SqlParameter("@digitoVerf", dig) { SqlDbType = SqlDbType.VarChar };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2, param3 };

            DataTable resultado = EjecutarConsultas("upPassword_sp", listaParametros.ToArray(), true);

        }
        public void InsertarNuevoUsuario(int id_persona, string usuario, string password, int cambia_cada, string digito)
        {
            SqlParameter param1 = new SqlParameter("@id_persona", id_persona) { SqlDbType = SqlDbType.Int };
            SqlParameter param2 = new SqlParameter("@usuario", usuario) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param3 = new SqlParameter("@password", password) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param4 = new SqlParameter("@cambia_cada", cambia_cada) { SqlDbType = SqlDbType.Int };
            SqlParameter param5 = new SqlParameter("@digito", digito) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param6 = new SqlParameter("@intentos", ConfigCache.intentos) { SqlDbType = SqlDbType.Int };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2, param3, param4, param5, param6 };

            EjecutarConsultas("alta_usuario_sp", listaParametros.ToArray(), true);

        }
    }
}

