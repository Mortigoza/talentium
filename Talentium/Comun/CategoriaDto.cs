using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun
{
    public class CategoriaDto
    {
        public int idCategoria { get; set; }
        public int valor { get; set; }
        public bool eliminacionOk { get; set; }
        public DataTable categorias { get; set; }
        public string categoria { get; set; }
        public int jornada { get; set; }
        public decimal sueldo { get; set; }
    }
}
