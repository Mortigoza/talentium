using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Accesibilidad
{
    public class CN_ConsultarPersonaMod
    {
        public DataTable ConsultarPersonaMod(int id_usuario)
        {
            CD_ConsultarPersonaMod cpm = new CD_ConsultarPersonaMod();
            return cpm.ConsultarPersonaMod(id_usuario);
        }
    }
}
