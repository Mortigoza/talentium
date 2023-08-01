using AccesoDatos;
using Comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public static class CN_Validaciones
    {
        private static int intentos = 5;
        private static DateTime horaBloqueo;
        private static double lapsoBloqueo = 10;
        private static bool activo = true;

        public static int GetIntentos() { return intentos; }
        public static DateTime GetHoraDesbloqueo() { valIntentos(); return horaBloqueo.AddMinutes(lapsoBloqueo); }

        // VALIDA USUARIO Y CONTRASEÑA.
        // MANEJA LOS INTENTOS DE CONTRASEÑA INCORRECTA.
        private static void valIntentos()
        {
            if (userCache.bloqueo != null)
            {
                DateTime horaBloqueo = Convert.ToDateTime(userCache.bloqueo);
            }
            if (intentos > 0)
            {
                intentos--; // Resta un intento.
            }
            else if (userCache.bloqueo == null)
            {
                horaBloqueo = System.DateTime.Now; // Bloquea y marca la hora de bloqueo.
                activo = false;
                Console.WriteLine("bloqueado");
            }
            else
            {
                reactivar(); // Chekea si ya paso el lapso de bloqueo.
            }
        }
        // CHEKEA SI SE DEBE O NO DESBLOQUEAR EL USUARIO.
        private static void reactivar()
        {
            if (userCache.bloqueo == null);
            else if (DateTime.Now > horaBloqueo.AddMinutes(lapsoBloqueo)) // Si ya paso el tiempo de bloqueo;
            {
                intentos = 5; // Desbloquea y restablece los intentos.
                activo = true;
            }
        }
        // VALIDACION FINAL DE USUARIO Y CONTRASEÑA
        public static bool ValUsr(string usuario, string password)
        {
            bool pswVal = false, pswDigVal = false;//true provicional

            string usrForm = usuario;
            string usrBd = Seguridad.DesEncriptar(userCache.usuario);

            string pswForm = Seguridad.Hash(Convert.ToString(usuario + password));
            string pswBd = userCache.password;

            string digitoForm = Seguridad.Hash(Seguridad.DigVerif(Seguridad.Hash(password)).ToString());
            string digitoBd = userCache.digito;

            if (string.Equals(usrForm, usrBd))
            {
                if (string.Equals(pswBd, pswForm)) pswVal = true;
                else valIntentos();
            }
            if (string.Equals(digitoBd, digitoForm)) pswDigVal = true;

            return pswVal && pswDigVal && activo;
        }


        // VALIDAR CARACTERES

        // VALIDA SI HAY DATOS INGRESADOS
        public static bool camposVacios(string usr, string psw)
        {
            if ((string.IsNullOrWhiteSpace(usr) | usr == "Usuario") | string.IsNullOrWhiteSpace(psw) | psw == "Contraseña") return false;
            else return true;
        }
        // VALIDA SI TIENE MINIMO 8 CARACTERES.
        private static bool minimoDeCaracteres(string str)
        {
            if (str.Length >= 8) return true;
            return false;
        }
        // VALIDA SI TIENE MAYUSCULAS.
        private static bool tieneMayuscula(string str)
        {
            string mayusculas = @"[A-Z]";
            if (Regex.IsMatch(str, mayusculas)) return true;
            return false;
        }
        // VALIDA SI TIENE MINUSCULAS.
        private static bool tieneMinuscula(string str)
        {
            string mayusculas = @"[a-z]";
            if (Regex.IsMatch(str, mayusculas)) return true;
            return false;
        }
        // VALIDA SI TIENE NUMEROS.
        private static bool tieneNumero(string str)
        {
            string numeros = @"[0-9]";
            if (Regex.IsMatch(str, numeros)) return true;
            return false;
        }
        // VALIDA SI TIENE CARACTERES ESPECIALES.
        private static bool tieneCaracterEspecial(string str)
        {
            string numeros = @"[^\w \-]";
            if (Regex.IsMatch(str, numeros)) return true;
            return false;
        }
        // VALIDACION FINAL DE CARACTERES: SE ELIGE QUE VALIDACIONES SE USAN, Y SI LAS SELECCIONADAS SON true DEVUELVE true.
        public static bool ValCar(string str, bool minCaracteres, bool mayusculas, bool numeros, bool minusculas, bool especiales)
        {
            bool minCar, may, num, min, esp;

            if (minCaracteres) minCar = minimoDeCaracteres(str); else minCar = true;
            if (mayusculas) may = tieneMayuscula(str); else may = true;
            if (numeros) num = tieneNumero(str); else num = true;
            if (minusculas) min = tieneMinuscula(str); else min = true;
            if (especiales) esp = tieneCaracterEspecial(str); else esp = true;

            return minCar && may && num && min && esp;
        }
    }
}
