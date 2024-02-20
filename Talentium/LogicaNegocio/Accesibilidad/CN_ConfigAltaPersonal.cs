using AccesoDatos.Accesibilidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Accesibilidad
{
    public class CN_ConfigAltaPersonal
    {
        CD_ConfigAltaPersonal configAltaPersonal = new CD_ConfigAltaPersonal();
        public bool ValidarTipoDoc(string tipoDoc)
        {
            if (!configAltaPersonal.ConsultarTipoDocRepetido(tipoDoc))
            {
                configAltaPersonal.InsertarTipoDoc(tipoDoc);
                return false;
            }

            return true;
        }
    }
}
