using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using System.Data;

namespace LogicaNegocio
{
    public class CN_LogicaEvaluacionDesempenio
    {
        CD_AccesoBD accesoDatos = new CD_AccesoBD();
        public DataTable ObtenerAreas()
        {
            return accesoDatos.ConsultaAreas();
        }
    }
}
