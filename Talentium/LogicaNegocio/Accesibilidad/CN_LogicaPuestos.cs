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
    }
}
