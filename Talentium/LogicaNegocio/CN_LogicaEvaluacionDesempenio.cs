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

        public DataTable ObtenerPersonaConArea(int idArea)
        {
            return accesoDatos.ConsultarPersonaConArea(idArea);

        }

        public void InsertarEvaluacionDesempenio(string anio, string mes, int efectTareas, int puntualidad,
                                               int relSup, int disciplina, int desempEquipo, int idPersona, int idArea)
        {
            accesoDatos.InsertarEvaluacionDesempenio(anio, mes, efectTareas, puntualidad, relSup, disciplina, desempEquipo, 
                idPersona, idArea);
        }
    }
}
