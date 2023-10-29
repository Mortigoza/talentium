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
        CD_Asistencias asistenciasDatos = new CD_Asistencias();
        private int idAsistencia;
        private int idPersona;
        private bool periodo;//bool
        private DateTime fecha;
        private DateTime fecha_desde;
        private DateTime fecha_hasta;
        private object idMotivo;//int
        private string otro_motivo;
        private bool justificada;//bool
        private string observaciones;

        public int IdAsistencia
        {
            get { return idAsistencia; }
            set { idAsistencia = value; }
        }
        public int IdPersona
        {
            get { return idPersona; }
            set { idPersona = value; }
        }

        public bool Periodo
        {
            get { return periodo; }
            set { periodo = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public DateTime FechaDesde
        {
            get { return fecha_desde; }
            set { fecha_desde = value; }
        }

        public DateTime FechaHasta
        {
            get { return fecha_hasta; }
            set { fecha_hasta = value; }
        }

        public object IdMotivo
        {
            get { return idMotivo; }
            set { idMotivo = value; }
        }

        public string OtroMotivo
        {
            get { return otro_motivo; }
            set { otro_motivo = value; }
        }

        public bool Justificada
        {
            get { return justificada; }
            set { justificada = value; }
        }

        public string Observaciones
        {
            get { return observaciones; }
            set { observaciones = value; }
        }


        CD_Asistencias asistencias = new CD_Asistencias();

        public int revisarMotivo(object idMotivo) 
        {
            return Convert.ToInt32(idMotivo);
        }
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
        public DataTable filtroModificacion(bool periodos,object area, object puesto, string cuil, DateTime? fecha, DateTime? fechaDesde, DateTime? fechaHasta) {
            var areas = Convert.ToInt32(area);
            var puestos = Convert.ToInt32(puesto);
            if (periodos)
            {
                fecha = null;
            }
            else { fechaDesde = null; fechaHasta = null; }
            //var fechas = Convert.ToDateTime()

            return asistencias.ConsultaAsistenciasMod(areas, puestos, cuil, fecha, fechaDesde, fechaHasta); 
        }
        public void cargarDatos() 
        {
            if (periodo)
            {
                asistenciasDatos.Fecha = null;
                asistenciasDatos.FechaDesde = fecha_desde;
                asistenciasDatos.FechaHasta = fecha_hasta;
            }
            else
            {
                asistenciasDatos.Fecha = fecha;
                asistenciasDatos.FechaDesde = null;
                asistenciasDatos.FechaHasta = null;
            }
            asistenciasDatos.IdAsistencia = idAsistencia;
            asistenciasDatos.IdPersona = idPersona;
            asistenciasDatos.Periodo = periodo;
            asistenciasDatos.IdMotivo = (int)idMotivo;
            asistenciasDatos.OtroMotivo = otro_motivo;
            asistenciasDatos.Justificada = justificada;
            asistenciasDatos.Observaciones = observaciones;
        }

        public void insertarAsistencias() 
        {
            cargarDatos();
            asistenciasDatos.CargarAsistencia(); 
        }
        public void ModificarAsistencias() 
        {
            cargarDatos();
            asistenciasDatos.ModificarAsistencia(); 
        }

    }
}
