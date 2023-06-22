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
        private static int intentos = 5;
        private static DateTime horaBloqueo;
        private static bool bloqueado;
        private static double lapsoBloqueo = 1;

        public static int GetIntentos() { return intentos; }
        public static DateTime GetHoraDesbloqueo() { return horaBloqueo.AddMinutes(lapsoBloqueo); }

        public static bool ValUsr(string usuario, string password)
        {
            bool usrVal = false, pswDigVal = false;

            string usrForm = Seguridad.Hash(Convert.ToString(usuario + password));
            string usrBd = "d33f5358e56f51e8ec97773106f03f23e45f2b86a96770e99e3fd06128b7aca4";

            string digitoForm = Seguridad.Hash(Seguridad.DigVerif(Seguridad.Hash(password)).ToString());
            string digitoBd = "5feceb66ffc86f38d952786c6d696c79c2dbc239dd4e91b46729d73a27fb57e9";

            if (comparar(usrBd, usrForm)) usrVal = true;
            else valIntentos();
            if (comparar(digitoBd, digitoForm)) pswDigVal = true;

            return usrVal && pswDigVal;
        }
        private static bool comparar(string x1, string x2)
        {
            return x1 == x2;
        }
        private static void valIntentos()
        {
            if (intentos > 0)
            {
                intentos--;
            }
            else if (bloqueado == false)
            {
                horaBloqueo = System.DateTime.Now;
                bloqueado = true;
            }
            else
            {
                reactivar();
            }
        }
        private static void reactivar()
        {
            if (bloqueado == false)
            {

            }
            else if (DateTime.Now > horaBloqueo.AddMinutes(lapsoBloqueo))
            {
                bloqueado = false;
                intentos = 5;
            }
        }
    }
}
