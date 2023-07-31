using CapaAccesoDatos.Loguin;
using CapaSesion;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaAccesoDatos
{
    public class CD_ConectarUsuario : CD_EjecutarConsultasSP
    {
        public bool CDVerificarUsuario(string user, string pass)
        {
            SqlParameter param1 = new SqlParameter("@user", user){SqlDbType = SqlDbType.NVarChar};
            SqlParameter param2 = new SqlParameter("@Pass", pass){SqlDbType = SqlDbType.NVarChar};
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2 };

            DataTable resultado = EjecutarConsultas("Login_LogIn", listaParametros.ToArray());

            if (resultado.Rows.Count > 0)
            {
                if (UserCache.IdUsuario != Convert.ToInt32(resultado.Rows[0][0].ToString()))
                {

                    foreach (DataRow row in resultado.Rows)
                    {
                        UserCache.IdUsuario = Convert.ToInt32(row[0].ToString());
                        UserCache.Usuario = row[1].ToString();
                        UserCache.Password = row[2].ToString();
                        UserCache.IdPersona = Convert.ToInt32(row[3].ToString());
                        if (!string.IsNullOrEmpty(row[4].ToString())) UserCache.FechaAlta = Convert.ToDateTime(row[4].ToString());
                        if (!string.IsNullOrEmpty(row[5].ToString())) UserCache.FechaBaja = Convert.ToDateTime(row[5].ToString());
                        UserCache.CambiaCada = Convert.ToInt32(row[6].ToString());
                        if (!string.IsNullOrEmpty(row[7].ToString())) UserCache.FechaUltimoCambio = Convert.ToDateTime(row[7].ToString());
                        UserCache.UsuarioDesactivado = Convert.ToBoolean(row[8].ToString()); ;
                        UserCache.Apellido = row[10].ToString();
                        UserCache.Nombres = row[11].ToString();
                        UserCache.Cargo = row[12].ToString();

                    }
                    CD_Permisos permiso = new CD_Permisos();
                    permiso.CDBuscarPermisos(UserCache.IdUsuario);
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
