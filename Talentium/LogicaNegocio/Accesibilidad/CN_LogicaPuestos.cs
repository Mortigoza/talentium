using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using System.Data;

namespace LogicaNegocio.Accesibilidad
{
    public class CN_LogicaPuestos
    {
        CD_AccesoBD accesoDatos = new CD_AccesoBD();
        public DataTable ObtenerPuestos()
        {
            return accesoDatos.ConsultaPuestos();
        }

        public bool validarPuesto(string puesto)
        {
            if (accesoDatos.ConsultarPuestoRepetido(puesto) == false)
            {
                accesoDatos.InsertarPuesto(puesto);
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ModificarPuesto(int idRegistroSeleccionado, string nuevoPuesto)
        {
            if (accesoDatos.ModificarPuesto(idRegistroSeleccionado, nuevoPuesto) == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool AsociadoAPersona(int idPuesto)
        {
            if (accesoDatos.ConsultarPuestoConPersona(idPuesto) == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool EliminarPuesto(int idPuesto)
        {
            if(accesoDatos.EliminarPuesto(idPuesto) == false) //no elimino nada
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
