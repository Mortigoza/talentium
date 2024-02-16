using AccesoDatos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class CN_Bakup
    {
        CD_Bakup bk = new CD_Bakup();
        private string path = @"c:\TalentiumBaks\";
        public string Path
        {
            get => path;
        }
        public CN_Bakup()
        {
            bk.Path = Path;
            // Verificar si el directorio existe
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                Console.WriteLine("Directorio creado exitosamente.");
            }
        }
        public void HacerBakup()
        {
            bk.HacerBakup();
        }
        public void CargarBakup(string filePath)
        {
            bk.CargarBakup(filePath);
        }
    }
}
