using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Accesibilidad
{
    public class CN_BajaUsuario
    {
        CD_BajaUsuario bu = new CD_BajaUsuario();
        public void BajaUsuario(int id_usuario)
        {
            bu.BajaUsuario(id_usuario);
        }
    }
}
