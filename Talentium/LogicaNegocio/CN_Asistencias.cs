using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace LogicaNegocio
{
    public class CN_Asistencias
    {
        CD_Asistencias asistencias = new CD_Asistencias();

        public DataTable area()
        {
            return asistencias.Areas();  
        }
        public DataTable puesto(int id)
        {
            return asistencias.Puestos(id);
        }
        public DataTable motivo()
        {
            return asistencias.Motivos();
        }

        public DataTable filtroAlta(int area, int puesto, string cuil) {
            return asistencias.ConsultaAsistencias(area, puesto, cuil); 
        }
        public DataTable filtroModCons(int idPersona, DateTime fecha, DateTime fechaDesde, DateTime fechaHasta) {
            return asistencias.ConsultaAsistenciasMod(idPersona, fecha, fechaDesde, fechaHasta);
        }

        public void insertarAsistencias() 
        {
            asistencias.CargarAsistencia(); 
        }

    }
}
