using AccesoDatos.Accesibilidad;
using System;
using System.Collections.Generic;
using System.Data;
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
        public DataTable ObtenerTipoDoc()
        {
            return configAltaPersonal.ObtenerTipoDoc();
        }
        public bool ModificarTipoDoc(int id_tipo_doc, string tipo_doc)
        {
            if (!configAltaPersonal.ConsultarTipoDocRepetido(tipo_doc))
            {
                configAltaPersonal.ModificarTipoDoc(id_tipo_doc, tipo_doc);
                return false;
            }
            return true;
        }
    }
}
