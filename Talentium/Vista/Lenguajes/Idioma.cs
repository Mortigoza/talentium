using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Properties;

namespace Vista.Lenguajes
{
    public class Idioma
    {
        public string Nombre { get; set; }
        public string Abreviacion { get; set; }
        public string Pais { get; set; }
        public string AbreviacionPais { get; set; }
        public string NombrePais { get => Nombre + "(" + Pais + ")"; }
        //public String NombrePais { get { return Nombre + "(" + Pais + ")"; } }
        public string InfoCultura { get => Abreviacion + "-" + AbreviacionPais; }

        public static List<Idioma> ObtenerIdiomas()
        {
            return new List<Idioma> {
                new Idioma
                {
                    Nombre = "Español",
                    Abreviacion = "es",
                    Pais = "Argentina",
                    AbreviacionPais = "AR"
                },
                new Idioma
                {
                    Nombre = "English",
                    Abreviacion = "en",
                    Pais = "Estados Unidos",
                    AbreviacionPais = "US"
                }
            };
        }

        public static void CargarIdioma(Control.ControlCollection controls, Form frm)
        {
            //Este metodo recibe dos parametros, 
            //Asigno el idioma a utilizar 
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Settings.Default.Idioma);
            //Llamo al metodo interno pasandole los parametros necesarios
            //para que cambie los nombres de los objetos
            CambiarTexto(controls, frm);
        }

        private static void CambiarTexto(Control.ControlCollection controls, Form frm)
        {

            frm.Text = Strings.ResourceManager.GetString(frm.Name);

            foreach (Control c in controls)
            {
                if (c is Panel | c is GroupBox)
                {
                    CambiarTexto(c.Controls, frm);
                }
                string text = Strings.ResourceManager.GetString(c.Name);
                if (text != null)
                {
                    c.Text = text;
                }
            }
        }
    }
}