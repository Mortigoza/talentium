using AccesoDatos.Accesibilidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Accesibilidad
{
    public class CN_UpPerfil
    {
        CD_AltaPerfil ap = new CD_AltaPerfil();
        CD_UpPerfil up = new CD_UpPerfil();

        public void UpPerfil(int id_perfil, string nombrePerfil, string descripcion, int[] permisos)
        {
            try
            {
                up.UpPerfil(id_perfil, nombrePerfil, descripcion);

                foreach (int id_permiso in permisos)
                {
                    ap.InsertarNuevoPermisoPerfil(id_perfil, id_permiso);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
