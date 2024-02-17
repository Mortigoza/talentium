using AccesoDatos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class CN_Backup
    {
        CD_Backup bk = new CD_Backup();
        private string path = @"c:\TalentiumBaks\";
        public string Path
        {
            get => path;
        }
        public CN_Backup()
        {
            bk.Path = Path;
            // Verificar si el directorio existe
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                Console.WriteLine("Directorio creado exitosamente.");
            }
        }
        public void HacerBackup()
        {
            bk.HacerBackup();
        }
        public void CargarBackup(string filePath)
        {
            bk.CargarBackup(filePath);
        }
    }
}
