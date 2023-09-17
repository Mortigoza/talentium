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

            UserCache.usuario = (string)resultado.Rows[0][1];
            UserCache.password = (string)resultado.Rows[0][2];
            UserCache.alta = (DateTime)resultado.Rows[0][3];

            UserCache.baja = (DateTime)resultado.Rows[0][4] ; 
           

            UserCache.cambiaCada = (int)resultado.Rows[0][5];

            UserCache.ultimoCambio = (DateTime)resultado.Rows[0][6];
            UserCache.bloqueo = (DateTime)resultado.Rows[0][7];

            UserCache.digito = (string)resultado.Rows[0][9];
            UserCache.intentos = (int)resultado.Rows[0][10];
            UserCache.nuevo = (bool)resultado.Rows[0][13];

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

        public DataTable ConsultarTodasPregSeg()
        {
            DataTable resultado = EjecutarConsultasSinParam("consultarPreguntas_sp");

            return resultado;
        }
        public DataTable ConsultaRtaSeg(int usuario)
        {
            SqlParameter param1 = new SqlParameter("@id_usuario", usuario) { SqlDbType = SqlDbType.Int };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            DataTable resultado = EjecutarConsultas("consultarRespuestas_sp", listaParametros.ToArray());

            return resultado;
        }
        public DataTable Consulta1PgtaSeg(int pgtas)
        {
            SqlParameter param1 = new SqlParameter("@id_pregunta", pgtas) { SqlDbType = SqlDbType.Int };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            DataTable resultado = EjecutarConsultas("consultarPreg_sp", listaParametros.ToArray());

            return resultado;
        }

        public void InsertarNuevaPass( string user, string pass, string dig, bool nueva)
        {
            SqlParameter param1 = new SqlParameter("@usuario", user) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param2 = new SqlParameter("@password", pass) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param3 = new SqlParameter("@digitoVerf", dig) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param4 = new SqlParameter("@nuevo", nueva) { SqlDbType = SqlDbType.Bit };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2, param3, param4 };

            DataTable resultado = EjecutarConsultas("upPassword_sp", listaParametros.ToArray(), true);

        }
        public void InsertarRespuestaSeg( int idUs, string rta, int idPregunta)
        {
            SqlParameter param1 = new SqlParameter("@id_usuario", idUs) { SqlDbType = SqlDbType.Int };
            SqlParameter param2 = new SqlParameter("@respuesta", rta) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param3 = new SqlParameter("@id_pregunta", idPregunta) { SqlDbType = SqlDbType.Int };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2, param3 };

            DataTable resultado = EjecutarConsultas("InsRespuesta_sp", listaParametros.ToArray(), true);

        }
        public int InsertarNuevoUsuario(int id_persona, string usuario, string password, int cambia_cada, string digito)
        {
            SqlParameter param1 = new SqlParameter("@id_persona", id_persona) { SqlDbType = SqlDbType.Int };
            SqlParameter param2 = new SqlParameter("@usuario", usuario) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param3 = new SqlParameter("@password", password) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param4 = new SqlParameter("@cambia_cada", cambia_cada) { SqlDbType = SqlDbType.Int };
            SqlParameter param5 = new SqlParameter("@digito", digito) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param6 = new SqlParameter("@intentos", ConfigCache.intentos) { SqlDbType = SqlDbType.Int };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2, param3, param4, param5, param6 };

            DataTable id_usuario = EjecutarConsultas("alta_usuario_sp", listaParametros.ToArray());
            return Convert.ToInt32(id_usuario.Rows[0][0]);
        }
        public void InsertarNuevoPermisoUsuario(int id_usuario, int id_permiso)
        {
            SqlParameter param1 = new SqlParameter("@id_usuario", id_usuario) { SqlDbType = SqlDbType.Int };
            SqlParameter param2 = new SqlParameter("@id_permiso", id_permiso) { SqlDbType = SqlDbType.Int };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2};

            EjecutarConsultas("alta_permiso_de_usuario_sp", listaParametros.ToArray(), true);

        }
        public DataTable ConsultarPersonalAltaUsuario(string cuil, string nombre, string apellido, int area)
        {
            SqlParameter param1 = new SqlParameter("@cuil", cuil) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param2 = new SqlParameter("@nombre", nombre) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param3 = new SqlParameter("@apellido", apellido) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param4 = new SqlParameter("@id_area", area) { SqlDbType = SqlDbType.Int };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2, param3, param4 };

            DataTable resultado = EjecutarConsultas("consultar_personal_alta_usuario_sp", listaParametros.ToArray());
            return resultado;

        }
        public DataTable ConsultaAreas()
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>() { };

            DataTable resultado = EjecutarConsultas("consultar_areas_sp", listaParametros.ToArray());
            return resultado;
        }
        public DataTable ConsultarPermisosLst()
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>() { };

            DataTable resultado = EjecutarConsultas("consultar_permisos_lst_sp", listaParametros.ToArray());
            return resultado;
        }
        public DataTable ConsultarPerfiles()
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>() { };

            DataTable resultado = EjecutarConsultas("consultar_perfiles_sp", listaParametros.ToArray());
            return resultado;
        }
        public DataTable ConsultarPermisosPerfil(int id_perfil)
        {
            SqlParameter param1 = new SqlParameter("@id_perfil", id_perfil) { SqlDbType = SqlDbType.Int };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };

            DataTable resultado = EjecutarConsultas("consultar_permisos_perfil_sp", listaParametros.ToArray());
            return resultado;
        }
        public bool ConsultarUsuarioRepetido(string usuario)
        {
            SqlParameter param1 = new SqlParameter("@usuario", usuario) { SqlDbType = SqlDbType.NVarChar };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };

            DataTable resultado = EjecutarConsultas("consultar_usuario_repetido_sp", listaParametros.ToArray());
            return resultado.Rows.Count != 0;
        }
        public string ConsultarMailPersona(int id_persona)
        {
            SqlParameter param1 = new SqlParameter("@id_persona", id_persona) { SqlDbType = SqlDbType.Int };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };

            DataTable email = EjecutarConsultas("consultar_mail_persona_sp", listaParametros.ToArray());
            return email.Rows[0][0].ToString();
        }

        public void InsertarArea(string area)
        {
            SqlParameter param1 = new SqlParameter("@area", area) { SqlDbType = SqlDbType.NVarChar };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };

            EjecutarConsultas("alta_area_sp", listaParametros.ToArray(), true);
        }

        public bool ConsultarAreaRepetida(string area)
        {
            SqlParameter param1 = new SqlParameter("@area", area) { SqlDbType = SqlDbType.NVarChar };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            DataTable resultadoArea = EjecutarConsultas("consultar_area_repetida_sp", listaParametros.ToArray());

            return resultadoArea.Rows.Count != 0;
        }
    }
}

