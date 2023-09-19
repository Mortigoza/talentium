using AccesoDatos;
using Comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Accesibilidad
{
    public class CN_UpUsuario
    {
        CD_UpUsuario uu = new CD_UpUsuario();
        CD_AccesoBD accesoDatos = new CD_AccesoBD();
        public void UpUsuario(int id_usuario, string usuario, string password, int cambia_cada, int[] permisos, string mail)
        {
            string digito = Seguridad.Hash(Seguridad.DigVerif(Seguridad.Hash(password)).ToString());
            password = Seguridad.Hash(usuario + password);
            usuario = Seguridad.Encriptar(usuario);

            try
            {
                uu.UpUsuario(id_usuario, usuario, password, cambia_cada, digito, mail);
                if (permisos.Length > 0)
                {
                    foreach (int id_permiso in permisos)
                    {
                        accesoDatos.InsertarNuevoPermisoUsuario(id_usuario, id_permiso);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
