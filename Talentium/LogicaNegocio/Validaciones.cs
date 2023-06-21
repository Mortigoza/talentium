using AccesoDatos;
using Comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public static class Validaciones
    {
        public static bool ValUsr(string usuario, string password)
        {
            string usrForm = usuario;
            string usrBd = Seguridad.DesEncriptar("VAB1AHQAbwB6AA==");

            string pswForm = Seguridad.Hash(Convert.ToString(password));
            string pswBd = "b6501dce06f4732aecd5310389c7d9ba6c956c782521f8079d67a81c00979743";

            string digitoForm = Seguridad.Hash(Seguridad.DigVerif(Seguridad.Hash(password)).ToString());
            string digitoBd = "5feceb66ffc86f38d952786c6d696c79c2dbc239dd4e91b46729d73a27fb57e9";

            return usrBd == usrForm && pswBd == pswForm && digitoBd == digitoForm;
        }
    }
}
