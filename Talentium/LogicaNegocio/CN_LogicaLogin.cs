using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Comun;

namespace LogicaNegocio
{
    public class CN_LogicaLogin
    {
        CD_AccesoBD accesoDatos = new CD_AccesoBD();
        public void LoginUser(string usuario, string pass)
        {
            try
            {
                accesoDatos.Buscar(usuario, pass);
            }
            catch (Exception ex) {
                throw ex;
            }
        }
    }
}
