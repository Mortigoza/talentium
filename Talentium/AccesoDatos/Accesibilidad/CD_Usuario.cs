using Comun;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Accesibilidad
{
    public class CD_Usuario: CD_EjecutarSP
    {
        public int InsertarNuevoUsuario(int id_persona, string usuario, string password, int cambia_cada, string digito, string mail, int idPerfil)
        {
            SqlParameter param1 = new SqlParameter("@id_persona", id_persona) { SqlDbType = SqlDbType.Int };
            SqlParameter param2 = new SqlParameter("@usuario", usuario) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param3 = new SqlParameter("@password", password) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param4 = new SqlParameter("@cambia_cada", cambia_cada) { SqlDbType = SqlDbType.Int };
            SqlParameter param5 = new SqlParameter("@digito", digito) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param6 = new SqlParameter("@intentos", ConfigCache.intentos) { SqlDbType = SqlDbType.Int };
            SqlParameter param7 = new SqlParameter("@email", mail) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param8 = new SqlParameter("@id_perfil", idPerfil) { SqlDbType = SqlDbType.Int };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2, param3, param4, param5, param6, param7, param8 };

            DataTable id_usuario = EjecutarConsultas("alta_usuario_sp", listaParametros.ToArray());
            return Convert.ToInt32(id_usuario.Rows[0][0]);
        }
        public void InsertarNuevoPermisoUsuario(int id_usuario, int id_permiso)
        {
            SqlParameter param1 = new SqlParameter("@id_usuario", id_usuario) { SqlDbType = SqlDbType.Int };
            SqlParameter param2 = new SqlParameter("@id_permiso", id_permiso) { SqlDbType = SqlDbType.Int };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2 };

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
        public DataTable ConsultarPermisosLst()
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>() { };

            DataTable resultado = EjecutarConsultas("consultar_permisos_lst_sp", listaParametros.ToArray());
            return resultado;
        }
        public DataTable ConsultarPermisosPerfil(int id_perfil)
        {
            SqlParameter param1 = new SqlParameter("@id_perfil", id_perfil) { SqlDbType = SqlDbType.Int };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };

            DataTable resultado = EjecutarConsultas("consultar_permisos_perfil_sp", listaParametros.ToArray());
            return resultado;
        }
        public DataTable ConsultarUsuarioRepetido(string usuario)
        {
            SqlParameter param1 = new SqlParameter("@usuario", usuario) { SqlDbType = SqlDbType.NVarChar };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };

            DataTable resultado = EjecutarConsultas("consultar_usuario_repetido_sp", listaParametros.ToArray());
            return resultado;
        }
        public string ConsultarMailPersona(int id_persona)
        {
            SqlParameter param1 = new SqlParameter("@id_persona", id_persona) { SqlDbType = SqlDbType.Int };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };

            DataTable email = EjecutarConsultas("consultar_mail_persona_sp", listaParametros.ToArray());
            return email.Rows[0][0].ToString();
        }
        public void UpUsuario(int id_usuario, int cambia_cada, string mail)
        {
            SqlParameter param1 = new SqlParameter("@id_usuario", id_usuario) { SqlDbType = SqlDbType.Int };
            SqlParameter param2 = new SqlParameter("@cambia_cada", cambia_cada) { SqlDbType = SqlDbType.Int };
            SqlParameter param3 = new SqlParameter("@email", mail) { SqlDbType = SqlDbType.NVarChar };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2, param3 };

            EjecutarConsultas("up_usuario_sp", listaParametros.ToArray());
        }
    }
}
