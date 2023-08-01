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
            string psw = Seguridad.Hash(usuario + pass);
            string dig = Seguridad.Hash(Seguridad.DigVerif(Seguridad.Hash(pass)).ToString());
            //Console.WriteLine(usr);
            //Console.WriteLine(psw);
            //Console.WriteLine(dig);
            try
            {
                accesoDatos.Buscar(usr, psw);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void BloqueoUser(int id, DateTime? hBloqueo)
        {
            try
            {
                accesoDatos.Bloquear(id, hBloqueo);
            }
            catch
            {
            }
        }
        public void IntentosUser(int id, int intento)
        {
            try
            {
                accesoDatos.Intentos(id, intento);
            }
            catch
            {
            }
        }
    }
}
