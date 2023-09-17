using AccesoDatos;
using Comun;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicaNegocio.Accesibilidad
{
    public class CN_ConsultarUsuario
    {
        CD_ConsultarUsuario accesoDatos = new CD_ConsultarUsuario();

        public DataTable ConsultarUsuario(string usuario, string nombre, string apellido, int area)
        {
            if (string.IsNullOrEmpty(usuario)) usuario = "\0";
            else usuario = Seguridad.Encriptar(usuario);
            if (string.IsNullOrEmpty(nombre)) nombre = "\0";
            if (string.IsNullOrEmpty(apellido)) apellido = "\0";

            DataTable dt = accesoDatos.ConsultarUsuario(usuario, nombre, apellido, area);

            for (int i = 0, len = dt.Rows.Count; i < len; i++)
            {
                dt.Rows[i][1] = Seguridad.DesEncriptar(dt.Rows[i][1].ToString());
            }

            return dt;
        }
    }
}
