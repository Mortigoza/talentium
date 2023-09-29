using AccesoDatos.Analisis_y_reportes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Analisis_y_reportes
{
    public class CN_ConsultarCertificacionServicios
    {
        CD_ConsultaCertificacionServicios ccs = new CD_ConsultaCertificacionServicios();
        public DataTable ConsultaCertificacionServicios(string cuit, string nombre, string apellido, int etapa)
        {
            if (string.IsNullOrEmpty(cuit)) cuit = "\0";
            if (string.IsNullOrEmpty(nombre)) nombre = "\0";
            if (string.IsNullOrEmpty(apellido)) apellido = "\0";

            DataTable dt = ccs.ConsultaCertificacionServicios(cuit, nombre, apellido, etapa);
            return dt;
        }
    }
}
