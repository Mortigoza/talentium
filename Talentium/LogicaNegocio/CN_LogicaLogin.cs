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
            string usr = Seguridad.Encriptar(usuario);
            string psw =  Seguridad.Hash(usuario+pass);
            Console.WriteLine(usr);
            Console.WriteLine(psw);
            try
            {
                accesoDatos.Buscar(usr, psw);
            }
            catch (Exception ex) {
                throw ex;
            }
        }
    }
}
