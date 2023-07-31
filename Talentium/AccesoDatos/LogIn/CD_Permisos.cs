using CapaAccesoDatos.Loguin;
using CapaSesion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Permisos : CD_EjecutarConsultasSP
    {
        public bool CDBuscarPermisos(int IdUser)
        {
            SqlParameter param1 = new SqlParameter("@IdUser", IdUser){SqlDbType = SqlDbType.Int};
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };

            DataTable resultado = EjecutarConsultas("Login_PermisosUsiario", listaParametros.ToArray());

            if (resultado.Rows.Count > 0)
            {
                foreach (DataRow row in resultado.Rows)
                {
                    UserCache.PermisosUsuario.Add(Convert.ToInt32(row[0].ToString()), row[1].ToString());
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
