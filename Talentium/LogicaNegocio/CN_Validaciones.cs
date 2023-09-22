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
        private static DateTime fechaDefecto = Convert.ToDateTime("1900-01-01");

        private static string mensajeErrorLabel; // NOTA: mover a otra clase mas adelante

        public static int GetIntentos() { return UserCache.intentos; }
        public static DateTime GetHoraDesbloqueo() {
            try
            {
                horaBloqueo = Convert.ToDateTime(UserCache.bloqueo);
                return horaBloqueo.AddMinutes(lapsoBloqueo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static string GetMensajeError() { return mensajeError; }
        public static string GetMensajeErrorLabel() { return mensajeErrorLabel; }

        // VALIDA USUARIO Y CONTRASEÑA.
        // MANEJA LOS INTENTOS DE CONTRASEÑA INCORRECTA.
        private static void valIntentos()
        {
            if (UserCache.baja == fechaDefecto)
            {
                CN_LogicaLogin logicaLogin = new CN_LogicaLogin();

                if (UserCache.intentos > 0 && UserCache.bloqueo == fechaDefecto)
                {
                    try
                    {
                        UserCache.intentos--;
                        logicaLogin.IntentosUser(UserCache.id, UserCache.intentos);
                    }
                    catch { }
                }
                else if (UserCache.intentos <= 0 && UserCache.bloqueo == fechaDefecto)
                {
                    logicaLogin.BloqueoUser(UserCache.id, System.DateTime.Now);
                    logicaLogin.cargarCatche(UserCache.usuario);
                }
                else
                {
                    mensajeError = "Usuario reactivado";
                    reactivar(); // Chekea si ya paso el lapso de bloqueo.
                }
            }
        }
        // CHEKEA SI SE DEBE O NO DESBLOQUEAR EL USUARIO.
        private static void reactivar()
        {
            CN_LogicaLogin logicaLogin = new CN_LogicaLogin();
            horaBloqueo = Convert.ToDateTime(UserCache.bloqueo);

            if (DateTime.Now > horaBloqueo.AddMinutes(lapsoBloqueo) && UserCache.bloqueo != fechaDefecto) // Si ya paso el tiempo de bloqueo;
            {
                logicaLogin.BloqueoUser(UserCache.id, fechaDefecto);
                logicaLogin.IntentosUser(UserCache.id, ConfigCache.intentos);
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
             DateTime valorFechaDefecto = Convert.ToDateTime("1900-01-01");
            if (UserCache.baja != fechaDefecto || UserCache.baja == valorFechaDefecto)
            {
                bajaVal = true;
                if (string.Equals(digitoBd.Trim(), digitoForm)) pswDigVal = true;
                // El mensaje de error es provisorio porque hay que bloquear el usuario
                else mensajeError = "MODIFICACION NO AUTORIZADA DE LA BASE DE DATOS.";

                if (string.Equals(usrForm, usrBd))
                {
                    
                    if (string.Equals(pswBd.Trim(), pswForm)) pswVal = true;
                    else
                    {
                        mensajeError = "Usuario o contraseña incorrectos.";
                        valIntentos();
                    }
                }

                if (UserCache.bloqueo == fechaDefecto) bloqVal = true;
                else
                {
                    mensajeError = "Usuario bloqueado.";
                    valIntentos();
                }
            }
            else mensajeError = "El usuario se encuentra dado de baja.";

            return pswVal && pswDigVal && bloqVal && bajaVal;
        }


        // VALIDAR CARACTERES // NOTA: mover a otra clase mas adelante

        // VALIDA SI HAY DATOS INGRESADOS
        public static bool camposVacios(string usr, string psw)
        {
            if (string.IsNullOrWhiteSpace(usr) | string.IsNullOrWhiteSpace(psw)) return false;
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
