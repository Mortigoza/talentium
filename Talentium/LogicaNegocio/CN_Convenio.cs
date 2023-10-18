using AccesoDatos;
using Comun;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
   public class CN_Convenio
    {
        CD_Convenios _CDAcceso = new CD_Convenios();
        public void InsertarConvenio(ConvenioDto convenio)
        {
            _CDAcceso.InsertarConvenios(convenio);
        }

        public DataTable ObtenerConvenio()
        {
            return _CDAcceso.ObtenerConvenios();
        }

        public DataTable ObtenerCategoriaID(int id)
        {
           return _CDAcceso.ObtenerCategoriaPorId(id);
        }


        public void EliminarConvenio(int id_convenio)
        {
            _CDAcceso.EliminarConvenio(id_convenio);
        }

        public void ModificarConvenio(ConvenioDto convenio, int id)
        {
            _CDAcceso.ModificarConvenio(convenio, id);
        }


    }
}
