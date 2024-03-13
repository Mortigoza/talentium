using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun
{
    public class C_Asistencias
    {
        //filtros
        public int idAsistencia { get; set; }
        public int idPersona { get; set; }
        public int valor { get; set; }
        public int idA { get; set; }
        public int idAP { get; set; }
        public int idAM { get; set; }
        public int idP { get; set; }
        public int idPer = 0;
        public int idAsis = 0;
        public object idAs { get; set; }
        public object idPs { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Puesto { get; set; }
        public string Area { get; set; }
        public bool isReport = false;

        public DataRowView selectedMotivo { get; set; }
        public DataRowView selectedArea { get; set; }
        public DataRowView selectedA { get; set; }
        public DataRowView selectedAA { get; set; }
        public DataRowView selectedMA { get; set; }
        public DataRowView selectedP { get; set; }
        public DataTable selectedAP { get; set; }
        public DataTable selectedPuesto { get; set; }
        public DataTable dtAs { get; set; }
        public DataRowView selectedMP { get; set; }
        public DataRowView cbMotivo { get; set; }
        public DataTable asistenciaCb { get; set; }
        public DataTable asistenciaCargar { get; set; }

        public bool Periodo { get; set; }
        public DateTime fecha { get; set; }
        public DateTime Fecha { get; set; }
        public bool Justificada { get; set; }
        public int Id_motivo { get; set; }
        public string Otro_motivo { get; set; }
        public string Observaciones { get; set; }

        public bool Alta { get; set; }



    }
    public class Asistencia {

        public int idPersona { get; set; }
        public bool Periodo { get; set; }
        public DateTime Fecha { get; set; }
        public bool Justificada { get; set; }
        public int idMotivo { get; set; }
        public string OtroMotivo { get; set; }
        public string Observaciones { get; set; }
    }
}