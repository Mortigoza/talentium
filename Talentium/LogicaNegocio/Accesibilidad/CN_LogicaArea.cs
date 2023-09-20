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

        public bool validarArea(string area)
        {
            if (accesoDatos.ConsultarAreaRepetida(area) == false) 
            {
                accesoDatos.InsertarArea(area);
                return false;
            } 
            else
            {
                return true;
            }
        }

        public DataTable ObtenerAreas()
        {
            return accesoDatos.ConsultaAreas();
        }

        public bool ModificarArea(int idRegistroSeleccionado, string nuevaArea)
        {
            if (accesoDatos.ModificarArea(idRegistroSeleccionado, nuevaArea) == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool AsociadoAPersona(int idArea)
        {
            if (accesoDatos.ConsultarAreaConPersona(idArea) == false)
            {
                return false;
            } else
            {
                return true;
            }
        }

        public bool EliminarArea(int idArea)
        {
            if (accesoDatos.EliminarArea(idArea) == false) //no elimino nada
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        
    }
}
