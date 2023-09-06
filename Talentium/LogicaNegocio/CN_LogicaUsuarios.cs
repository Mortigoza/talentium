using AccesoDatos;
using Comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class CN_LogicaUsuarios
    {
		CD_AccesoBD accesoDatos = new CD_AccesoBD();
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
