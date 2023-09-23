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
        public bool ValidarEvaluacion(string anio, string mes, int efectTareas, int puntualidad,
            int relSup, int disciplina, int desempEquipo, int id_persona, int id_area)
        {
            if (!accesoDatos.ConsultarEvaluacionRepetida(anio, mes, id_persona))
            {
                accesoDatos.InsertarEvaluacionDesempenio(anio, mes, efectTareas, puntualidad, relSup, disciplina, desempEquipo, 
                      id_persona, id_area);
                return false;
            }

            return true;
        }

        // tengo que hacer un metodo que valide que la evaluacion no este ya creada:
        // seria de este estilo:
        // public bool ValidarEvaluacion(string anio, string mes, int efectTareas, int puntualidad,
        //               int relSup, int disciplina, int desempEquipo, int idPersona, int idArea)
        // {
        //    if (!accesoDatos.ConsultarEvaluacionRepetida(anio, mes, id_persona))
        //    {
        //        accesoDatos.InsertarEvaluacionDesempenioanio, mes, efectTareas, puntualidad, relSup, disciplina, desempEquipo, 
        //              idPersona, idArea);
        //        return false;
        //    }

        //    return true;
        // }

        //public void InsertarEvaluacionDesempenio(string anio, string mes, int efectTareas, int puntualidad,
        //                                       int relSup, int disciplina, int desempEquipo, int idPersona, int idArea)
        //{
        //    accesoDatos.InsertarEvaluacionDesempenio(anio, mes, efectTareas, puntualidad, relSup, disciplina, desempEquipo, 
        //        idPersona, idArea);
        //}
    }
}
