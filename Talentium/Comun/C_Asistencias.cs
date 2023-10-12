using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun
{
    public class C_Asistencias
    {
        //filtros
        public int idPersona { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Puesto { get; set; }
        public string Area { get; set; }

        //insert

        public bool periodo { get; set; }
        public DateTime fecha { get; set; }
        public DateTime fecha_desde { get; set; }
        public DateTime fecha_hasta { get; set; }
        public int idMotivo { get; set; }
        public string otro_motivo { get; set; }
        public bool justificada { get; set; }
        public string observaciones { get; set; }
    }
}