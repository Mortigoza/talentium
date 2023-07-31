using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun.LogIn
{
    public static class UserCache
    {
        public static int IdUsuario { get; set; }
        public static string Usuario { get; set; }
        public static string Password { get; set; }
        public static int? IdPersona { get; set; }
        public static DateTime? FechaAlta { get; set; }
        public static DateTime? FechaBaja { get; set; }
        public static int? CambiaCada { get; set; }
        public static DateTime? FechaUltimoCambio { get; set; }
        public static bool? UsuarioDesactivado { get; set; }
        public static DateTime? FechaDesactivacion { get; set; }
        public static string Apellido { get; set; }
        public static string Nombres { get; set; }
        public static string Cargo { get; set; }

        public static Hashtable PermisosUsuario = new Hashtable();

    }
}
