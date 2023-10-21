using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun
{
    public class Persona 

    {
        public string apellidos { get; set; }
        public string nombres { get; set; }
        public int id_tipo_doc { get; set; }
        public string nro_doc { get; set; }
        public string cuit_cuil { get; set; }
        public string calle { get; set; }
        public int nro { get; set; }
        public string dpto { get; set; }
        public string piso { get; set; }
        public int id_localidad { get; set; }
        public int id_puesto { get; set; }
        public  int id_area { get; set; }
        public string email { get; set; }
        public int id_nacionalidad { get; set; }
        public int id_genero { get; set; } 
        public DateTime fecha_nacimiento { get; set; }
        public int id_estado_civil { get; set; } 
        public int hijos { get; set; }
        public int id_convenio { get; set; }

        public byte[] foto_perfil  { get; set; }
        
        public string telefono { get; set; }
        public int id_tipo { get; set; }
        public string telefono_alternativo { get; set; }
        public int id_tipo_alternativo { get; set; }
        public string contacto   { get; set; }

        public string codigo_postal { get; set; }
   
        public int id_nivel { get; set; }
        public string institucion { get; set; }
        public string carrera { get; set; }
        public int  año_ingreso { get; set; }
        public int año_egreso { get; set; }
        public string titulo { get; set; }
        public int id_progreso { get; set; }
        public string puesto { get; set; }
        public string empresa { get; set; }
        public int fecha_ingreso { get; set; }
        public int fecha_egreso { get; set; } 
        public int personal_a_cargo { get; set; }



    }
}
