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
            if (!accesoDatos.ConsultarPuestoRepetido(puesto))
            {
                accesoDatos.InsertarPuesto(puesto);
                return false;
            }

            return true;
        }

        public bool ModificarPuesto(int idRegistroSeleccionado, string nuevoPuesto)
        {
            return accesoDatos.ModificarPuesto(idRegistroSeleccionado, nuevoPuesto);
        }

        public bool AsociadoAPersona(int idPuesto)
        {
            return accesoDatos.ConsultarPuestoConPersona(idPuesto);
        }

        public bool EliminarPuesto(int idPuesto)
        {
            return accesoDatos.EliminarPuesto(idPuesto);
        }
    }

    
}
