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

        /////////////////// Tipo de documento ///////////////////
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
        public bool TipoDocAsociadoAPersona(int id_tipo_doc)
        {
            return configAltaPersonal.ConsultarTipoDocConPersona(id_tipo_doc);
        }
        public bool EliminarTipoDoc(int id_tipo_doc)
        {
            return configAltaPersonal.EliminarTipoDoc(id_tipo_doc);
        }

        /////////////////// Tipo de teléfono ///////////////////
        public bool ValidarTipoTel(string tipoTel)
        {
            if (!configAltaPersonal.ConsultarTipoTelRepetido(tipoTel))
            {
                configAltaPersonal.InsertarTipoTel(tipoTel);
                return false;
            }
            return true;
        }
        public DataTable ObtenerTipoTel()
        {
            return configAltaPersonal.ObtenerTipoTel();
        }
        public bool ModificarTipoTel(int id_tipo_tel, string tipo_tel)
        {
            if (!configAltaPersonal.ConsultarTipoTelRepetido(tipo_tel))
            {
                configAltaPersonal.ModificarTipoTel(id_tipo_tel, tipo_tel);
                return false;
            }
            return true;
        }
        public bool TipoTelAsociadoAPersona(int id_tipo_tel)
        {
            return configAltaPersonal.ConsultarTipoTelConPersona(id_tipo_tel);
        }
        public bool EliminarTipoTel(int id_tipo_tel)
        {
            return configAltaPersonal.EliminarTipoTel(id_tipo_tel);
        }

        /////////////////// Nacionalidad ///////////////////
        public bool ValidarNacionalidad(string nacionalidad)
        {
            if (!configAltaPersonal.ConsultarNacionalidadRepetida(nacionalidad))
            {
                configAltaPersonal.InsertarNacionalidad(nacionalidad);
                return false;
            }
            return true;
        }
        public DataTable ObtenerNacionalidad()
        {
            return configAltaPersonal.ObtenerNacionalidad();
        }
        public bool ModificarNacionalidad(int id_nacionalidad, string nacionalidad)
        {
            if (!configAltaPersonal.ConsultarNacionalidadRepetida(nacionalidad))
            {
                configAltaPersonal.ModificarNacionalidad(id_nacionalidad, nacionalidad);
                return false;
            }
            return true;
        }
        public bool NacionalidadAsociadaAPersona(int id_nacionalidad)
        {
            return configAltaPersonal.ConsultarNacionalidadConPersona(id_nacionalidad);
        }
        public bool EliminarNacionalidad(int id_nacionalidad)
        {
            return configAltaPersonal.EliminarNacionalidad(id_nacionalidad);
        }

        /////////////////// Género ///////////////////
        public bool ValidarGenero(string genero)
        {
            if (!configAltaPersonal.ConsultarGeneroRepetido(genero))
            {
                configAltaPersonal.InsertarGenero(genero);
                return false;
            }
            return true;
        }
        public DataTable ObtenerGenero()
        {
            return configAltaPersonal.ObtenerGenero();
        }
        public bool ModificarGenero(int id_genero, string genero)
        {
            if (!configAltaPersonal.ConsultarGeneroRepetido(genero))
            {
                configAltaPersonal.ModificarGenero(id_genero, genero);
                return false;
            }
            return true;
        }
        public bool GeneroAsociadoAPersona(int id_genero)
        {
            return configAltaPersonal.ConsultarGeneroConPersona(id_genero);
        }
        public bool EliminarGenero(int id_genero)
        {
            return configAltaPersonal.EliminarGenero(id_genero);
        }
    }
}
