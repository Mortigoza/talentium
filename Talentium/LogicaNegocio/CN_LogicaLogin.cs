using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace LogicaNegocio
{
    public class CN_LogicaLogin
    {
        CD_AccesoBD accesoDatos = new CD_AccesoBD();
        public bool LoginUser(string usuario, string pass)
        {
            try
            {
                accesoDatos.Buscar(usuario, pass);
                return true;
            }
            catch (Exception ex) { 
            
                return false;   
            }
        }
    }
}
