﻿using Comun;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
