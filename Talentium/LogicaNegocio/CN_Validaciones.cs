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
        private static DateTime horaBloqueo;
        private static double lapsoBloqueo = 0.1;
        private static string mensajeError;

        private static string mensajeErrorLabel; // NOTA: mover a otra clase mas adelante

        public static int GetIntentos() { return UserCache.intentos; }
        public static DateTime GetHoraDesbloqueo() { valIntentos(); return horaBloqueo.AddMinutes(lapsoBloqueo); }
        public static string GetMensajeError() { return mensajeError; }
        public static string GetMensajeErrorLabel() { return mensajeErrorLabel; }

        // VALIDA USUARIO Y CONTRASEÑA.
        // MANEJA LOS INTENTOS DE CONTRASEÑA INCORRECTA.
        private static void valIntentos()
        {
            if (UserCache.baja == null)
            {
                CN_LogicaLogin logicaLogin = new CN_LogicaLogin();

                if (UserCache.intentos > 0 && UserCache.bloqueo == null)
                {
                    try
                    {
                        UserCache.intentos--;
                        logicaLogin.IntentosUser(UserCache.id, UserCache.intentos);
                    }
                    catch { }
                }
                else if (UserCache.intentos <= 0 && UserCache.bloqueo == null)
                {
                    logicaLogin.BloqueoUser(UserCache.id, System.DateTime.Now);
                }
                else
                {
                    reactivar(); // Chekea si ya paso el lapso de bloqueo.
                    mensajeError = "Usuario reactivado";
                }
            }
        }
        // CHEKEA SI SE DEBE O NO DESBLOQUEAR EL USUARIO.
        private static void reactivar()
        {
            CN_LogicaLogin logicaLogin = new CN_LogicaLogin();
            horaBloqueo = Convert.ToDateTime(UserCache.bloqueo);

            if (DateTime.Now > horaBloqueo.AddMinutes(lapsoBloqueo) && UserCache.bloqueo != null) // Si ya paso el tiempo de bloqueo;
            {
                logicaLogin.BloqueoUser(UserCache.id, null);
                logicaLogin.IntentosUser(UserCache.id, 5);
            }
        }

        private static void valFechaHoy()
        {
            DateTime fechaHoy = DateTime.Now;
            DateTime fechaIntentos = UserCache.fechaIntentos;
            if (fechaHoy != fechaIntentos)
            {
                CN_LogicaLogin logicaLogin = new CN_LogicaLogin();
                logicaLogin.CargarFechaHoyIntentosUser(UserCache.id, fechaHoy);
            }
        }
        // VALIDACION FINAL DE USUARIO Y CONTRASEÑA
        public static bool ValUsr(string usuario, string password)
        {
            bool pswVal = false, pswDigVal = false, bloqVal = false, bajaVal = false;

            string usrForm = usuario;
            string usrBd = Seguridad.DesEncriptar(UserCache.usuario);

            string pswForm = Seguridad.Hash(Convert.ToString(usrBd + password));
            string pswBd = UserCache.password;

            // Se hashea el digito con solo la password (reveer)
            string digitoForm = Seguridad.Hash(Seguridad.DigVerif(Seguridad.Hash(password)).ToString());
            string digitoBd = UserCache.digito;

            mensajeError = "Sin errores de validacion";

            if (UserCache.baja == null)
            {
                bajaVal = true;
                if (string.Equals(digitoBd, digitoForm)) pswDigVal = true;
                // El mensaje de error es provisorio porque hay que bloquear el usuario
                else mensajeError = "MODIFICACION NO AUTORIZADA DE LA BASE DE DATOS.";

                if (string.Equals(usrForm, usrBd))
                {
                    if (string.Equals(pswBd, pswForm)) pswVal = true;
                    else
                    {
                        // Se va a llamar al metodo para validar la fecha de intentos con la de hoy
                        valFechaHoy();
                        valIntentos();
                        mensajeError = "Usuario o contraseña incorrectos.";
                    }
                }
                else
                {
                    // Se va a llamar al metodo para validar la fecha de intentos con la de hoy
                    valFechaHoy();
                    valIntentos();
                    mensajeError = "Usuario o contraseña incorrectos.";
                }

                if (UserCache.bloqueo == null) bloqVal = true;
                else mensajeError = "Usuario bloqueado.";
            }
            else mensajeError = "El usuario se encuentra dado de baja.";

            return pswVal && pswDigVal && bloqVal && bajaVal;
        }


        // VALIDAR CARACTERES // NOTA: mover a otra clase mas adelante

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
            mensajeErrorLabel = "Debe ingresar minimo 8 caracteres";
            return false;
        }
        // VALIDA SI TIENE MAYUSCULAS.
        private static bool tieneMayuscula(string str)
        {
            string mayusculas = @"[A-Z]";
            if (Regex.IsMatch(str, mayusculas)) return true;
            mensajeErrorLabel = "Debe ingresar minimo una mayuscula";
            return false;
        }
        // VALIDA SI TIENE MINUSCULAS.
        private static bool tieneMinuscula(string str)
        {
            string minusculas = @"[a-z]";
            if (Regex.IsMatch(str, minusculas)) return true;
            mensajeErrorLabel = "Debe ingresar minimo una minuscula";
            return false;
        }
        // VALIDA SI TIENE NUMEROS.
        private static bool tieneNumero(string str)
        {
            string numeros = @"[0-9]";
            if (Regex.IsMatch(str, numeros)) return true;
            mensajeErrorLabel = "Debe ingresar minimo un numero";
            return false;
        }
        // VALIDA SI TIENE CARACTERES ESPECIALES.
        private static bool tieneCaracterEspecial(string str)
        {
            string especiales = @"[^\w \-]";
            if (Regex.IsMatch(str, especiales)) return true;
            mensajeErrorLabel = "Debe ingresar minimo un caracter especial";
            return false;
        }
        // VALIDACION FINAL DE CARACTERES: SE ELIGE QUE VALIDACIONES SE USAN, Y SI LAS SELECCIONADAS SON true DEVUELVE true.
        public static bool ValCar(string str, bool minCaracteres, bool mayusculas, bool numeros, bool especiales, bool passAnteriores, bool noDatosPersonales)
        {
            bool minCar, may, num, min, esp, antPass, noDat;

            if (tieneMinuscula(str)) min = true; else min = false;
            if (minCaracteres) minCar = minimoDeCaracteres(str); else minCar = true;
            if (mayusculas) may = tieneMayuscula(str); else may = true;
            if (numeros) num = tieneNumero(str); else num = true;
            if (especiales) esp = tieneCaracterEspecial(str); else esp = true;
            //if (passAnteriores) ; else
                antPass = true;
            //if (noDatosPersonales) ; else
                noDat = true;

            return minCar && may && num && min && esp && antPass && noDat;
        }
    }
}
