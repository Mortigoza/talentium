using AccesoDatos;
using Comun;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class CN_LogicaUsuarios
    {
		CD_AccesoBD accesoDatos = new CD_AccesoBD();
        public DataTable ConsultarPersonalAltaUsuario(string cuil, string nombre, string apellido)
        {
            if (string.IsNullOrEmpty(cuil)) cuil = "\0";
            if (string.IsNullOrEmpty(nombre)) nombre = "\0";
            if (string.IsNullOrEmpty(apellido)) apellido = "\0";

            try
            {
                return accesoDatos.ConsultarPersonalAltaUsuario(cuil, nombre, apellido);
            }
            catch (Exception ex)
            {
            }
            return null;
        }
        public void InsertarNuevoUsuario(int id_persona, string usuario, string password, int cambia_cada)
        {
            string digito = Seguridad.Hash(Seguridad.DigVerif(Seguridad.Hash(password)).ToString());

            password = Seguridad.Hash(usuario + password);
            usuario = Seguridad.Encriptar(usuario);

            try
            {
                accesoDatos.InsertarNuevoUsuario(id_persona, usuario, password, cambia_cada, digito);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
