using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Accesibilidad
{
    public class CN_ReactivarUsuario
    {
        CD_ReactivarUsuario ru = new CD_ReactivarUsuario();
        public void ReactivarUsuario(int id_usuario)
        {
            ru.ReactivarUsuario(id_usuario);
        }
    }
}
