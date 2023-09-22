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
        public void UpUsuario(int id_usuario, int cambia_cada, int[] permisos, string mail)
        {
            try
            {
                uu.UpUsuario(id_usuario, cambia_cada, mail);
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
