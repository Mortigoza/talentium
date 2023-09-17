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
            if (accesoDatos.ConsultarAreaRepetida(area) == false) //entra acá cuando no es repetido: FALSE
            {
                accesoDatos.InsertarArea(area);
                return false;
            } //si es TRUE es repetido
            else
            {
                return true;
            }
        }

        public DataTable ObtenerAreas()
        {
            return accesoDatos.ConsultaAreas();
        }
        
    }
}
