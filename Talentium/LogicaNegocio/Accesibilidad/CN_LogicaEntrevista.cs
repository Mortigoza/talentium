using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.Accesibilidad;
using System.Data;

namespace LogicaNegocio.Accesibilidad
{
    public class CN_LogicaEntrevista
    {
        CD_Entrevista entrevistaDatos = new CD_Entrevista();
        public bool ValidarEntrevista(string entrevista)
        {
            if (!entrevistaDatos.ConsultarEntrevistaRepetida(entrevista))
            {
                entrevistaDatos.InsertarEntrevista(entrevista);
                return false;
            }

            return true;
        }

        public DataTable ConsultarEntrevistas()
        {
            return entrevistaDatos.ConsultarEntrevistas();
        }



    }
}
