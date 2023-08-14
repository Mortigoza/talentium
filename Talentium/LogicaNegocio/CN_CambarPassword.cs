using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LogicaNegocio
{
   public class CN_CambarPassword
    {

        public static bool ValidatePassword(string password)
        {
            // Expresión regular que verifica la contraseña
            string pattern = @"^(?=.*[A-Za-z0-9])(?=.*[@#$%^&+=!]).{8,}$";

            return Regex.IsMatch(password, pattern);
        }

        //public string ChangePassword()
        //{ 


        //}
    }
}
