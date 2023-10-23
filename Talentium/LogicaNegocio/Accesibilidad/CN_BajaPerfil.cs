using AccesoDatos.Accesibilidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Accesibilidad
{
    public class CN_BajaPerfil
    {
        CD_BajaPerfil bp = new CD_BajaPerfil();
        public void BajaPerfil(int id_perfil)
        {
            bp.BajaPerfil(id_perfil);
        }
    }
}
