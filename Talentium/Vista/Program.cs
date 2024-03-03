﻿using Comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Evaluacion_de_desempeño;
using Vista.Accesibilidad;
using Vista.Analisis_y_reportes;
using Vista.Gestion_de_Talento;

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
            ConfigCache.intentos = 5; //INTENTOS POR DEFECTO PARA QUE SE BLOQUEE
            Application.Run(new frmLogin());





        }
    }
}
