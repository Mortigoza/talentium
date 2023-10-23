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
    public class CD_AltaPerfil: CD_EjecutarSP
    {
        public int InsertarPerfil(string nombre, string descripcion)
        {
            SqlParameter param1 = new SqlParameter("@nombre", nombre) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param2 = new SqlParameter("@descripcion", descripcion) { SqlDbType = SqlDbType.NVarChar };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2 };

            DataTable id_usuario = EjecutarConsultas("alta_perfil_sp", listaParametros.ToArray());
            return Convert.ToInt32(id_usuario.Rows[0][0]);
        }
        public void InsertarNuevoPermisoPerfil(int id_perfil, int id_permiso)
        {
            SqlParameter param1 = new SqlParameter("@id_perfil", id_perfil) { SqlDbType = SqlDbType.Int };
            SqlParameter param2 = new SqlParameter("@id_permiso", id_permiso) { SqlDbType = SqlDbType.Int };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2 };

            EjecutarConsultas("alta_permiso_perfil_sp", listaParametros.ToArray(), true);
        }
    }
}
