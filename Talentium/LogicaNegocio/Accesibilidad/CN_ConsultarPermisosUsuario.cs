using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Accesibilidad
{
    public class CN_ConsultarPermisosUsuario
    {
        public DataTable ConsultarPermisosUsuario(int id_usuario)
        {
            CD_ConsultarPermisosUsuario cpu = new CD_ConsultarPermisosUsuario();
            return cpu.ConsultarPermisosUsuario(id_usuario);
        }
    }
}
