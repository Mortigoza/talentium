using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using System.Data;

namespace LogicaNegocio
{
    public class CN_LogicaProcesoSeleccion
    {
        CD_AccesoBD accesoDatos = new CD_AccesoBD();

        public bool ExisteCandidato(string cuil)
        {
            return accesoDatos.ConsultarCandidato(cuil);
        }
    }
}
