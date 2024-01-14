using AccesoDatos;
using AccesoDatos.Accesibilidad;
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
        CD_Usuario cd_usuario = new CD_Usuario();
        public void UpUsuario(int id_usuario, int cambia_cada, int[] permisos, string mail)
        {
            try
            {
                cd_usuario.UpUsuario(id_usuario, cambia_cada, mail);
                if (permisos.Length > 0)
                {
                    foreach (int id_permiso in permisos)
                    {
                        cd_usuario.InsertarNuevoPermisoUsuario(id_usuario, id_permiso);
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
