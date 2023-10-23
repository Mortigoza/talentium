using AccesoDatos.Accesibilidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Accesibilidad
{
    public class CN_AltaPerfil
    {
        CD_AltaPerfil ap = new CD_AltaPerfil();

        public void AltaPerfil(string nombrePerfil, string descripcion, int[] permisos)
        {
            try
            {
                int id_perfil = ap.InsertarPerfil(nombrePerfil, descripcion);

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
