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

        private static List<string> mensajeErrorLabel = new List<string>(); // NOTA: mover a otra clase mas adelante
        public static string[] GetMensajeErrorLabel() { return mensajeErrorLabel.ToArray(); }

        // VALIDA SI TIENE MINIMO 8 CARACTERES.
        private static bool minimoDeCaracteres(string str)
        {
            if (str.Length >= 8) return true;
            mensajeErrorLabel.Add("Debe ingresar minimo 8 caracteres");
            return false;
        }
        // VALIDA SI TIENE MAYUSCULAS.
        private static bool tieneMayuscula(string str)
        {
            string mayusculas = @"[A-Z]";
            if (Regex.IsMatch(str, mayusculas)) return true;
            mensajeErrorLabel.Add("Debe ingresar minimo una mayuscula");
            return false;
        }
        // VALIDA SI TIENE MINUSCULAS.
        private static bool tieneMinuscula(string str)
        {
            string minusculas = @"[a-z]";
            if (Regex.IsMatch(str, minusculas)) return true;
            mensajeErrorLabel.Add("Debe ingresar minimo una minuscula");
            return false;
        }
        // VALIDA SI TIENE NUMEROS.
        private static bool tieneNumero(string str)
        {
            string numeros = @"[0-9]";
            if (Regex.IsMatch(str, numeros)) return true;
            mensajeErrorLabel.Add("Debe ingresar minimo un numero");
            return false;
        }
        // VALIDA SI TIENE CARACTERES ESPECIALES.
        private static bool tieneCaracterEspecial(string str)
        {
            string especiales = @"[^\w \-]";
            if (Regex.IsMatch(str, especiales)) return true;
            mensajeErrorLabel.Add("Debe ingresar minimo un caracter especial");
            return false;
        }
        // VALIDACION FINAL DE CARACTERES: SE ELIGE QUE VALIDACIONES SE USAN, Y SI LAS SELECCIONADAS SON true DEVUELVE true.
        public static bool ValCar(string str, bool minCaracteres, bool mayusculas, bool numeros, bool especiales, bool passAnteriores, bool noDatosPersonales)
        {
            mensajeErrorLabel.Clear();
            bool minCar, may, num, min, esp, antPass, noDat;

            if (!tieneMinuscula(str)) min = false; else min = true;
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
