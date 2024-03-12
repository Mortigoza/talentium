using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun
{
    public class ConvenioDto
    {
       public  string convenio { get; set; }
       public string seguridad_salud { get; set; }
        public string obra_social { get; set; }
        public int id_categoria { get; set; }
        public int id_area { get; set; }
        public int valor { get; set; }
        public bool eliminacionOk { get; set; }

        public bool inicial = true;

        public int id_conv { get; set; }
        public int id_areas { get; set; }
        public int id_puestos { get; set; }
        public string cuil { get; set; }
        public string seleccion { get; set; }
        public string seleccionC { get; set; }

        public DataTable categorias { get; set; }
        public DataTable convAreas { get; set; }
        public DataTable convenios { get; set; }
        public DataTable conv { get; set; }
        public DataTable convCopy { get; set; }
        public DataTable cat { get; set; }
        public DataRow row { get; set; }
        public DataRowView selectConvenio { get; set; }
        public DataRowView selectArea { get; set; }
        public DataRowView selectPuesto { get; set; }

        public DataRowView selArea { get; set; }
        public DataTable selConv { get; set; }


    }
}
