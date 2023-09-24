using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace LogicaNegocio.Accesibilidad
{
    public class CN_LogicaArea
    {
        CD_AccesoBD accesoDatos = new CD_AccesoBD();

        public bool ValidarArea(string area)
        {
            if (!accesoDatos.ConsultarAreaRepetida(area))
            {
                accesoDatos.InsertarArea(area);
                return false;
            }

            return true;
        }

        public DataTable ObtenerAreas()
        {
            return accesoDatos.ConsultaAreas();
        }

        // Si el resultado es false, devuelve false. Si es true, devuelve true
        public bool ModificarArea(int idRegistroSeleccionado, string nuevaArea)
        {
            return accesoDatos.ModificarArea(idRegistroSeleccionado, nuevaArea);
        }

        // Si el resultado es false, devuelve false. Si es true, devuelve true
        public bool AsociadoAPersona(int idArea)
        {
            return accesoDatos.ConsultarAreaConPersona(idArea);
        }

        // Si el resultado es false, devuelve false. Si es true, devuelve true
        public bool EliminarArea(int idArea)
        {
            return accesoDatos.EliminarArea(idArea);
        }

    }
}
