using Comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Evaluacion_de_desempeño;
using Vista.Accesibilidad;
using Vista.Analisis_y_reportes;
using LogicaNegocio;
using System.Threading;

namespace Vista
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Properties.Settings.Default.Idioma);
            CN_LogicaLogin.Terminal(); // Checkeo del estado de la terminal
            if (LogicaNegocio.Properties.Terminal.Default.Estado_terminal == true)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmLogin());
            }
        }
    }
}
