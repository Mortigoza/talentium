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
        public bool ValidarEntrevista(int instancia, string entrevista)
        {
            if (!entrevistaDatos.ConsultarEntrevistaRepetida(entrevista))
            {
                entrevistaDatos.InsertarEntrevista(instancia, entrevista);
                return false;
            }

            return true;
        }

        public DataTable ConsultarEntrevistas()
        {
            return entrevistaDatos.ConsultarEntrevistas();
        }
        public bool ModificarEntrevista(int idRegistroSeleccionado, int instancia, string nuevaEntrevista)
        {
            if (!entrevistaDatos.ConsultarEntrevistaRepetida(nuevaEntrevista))
            {
                entrevistaDatos.ModificarEntrevista(idRegistroSeleccionado, instancia, nuevaEntrevista);
                
            }
            return true;
        }
        public bool EliminarEntrevista(int id_entrevista)
        {
            return entrevistaDatos.EliminarEntrevista(id_entrevista);
        }

    }
}
