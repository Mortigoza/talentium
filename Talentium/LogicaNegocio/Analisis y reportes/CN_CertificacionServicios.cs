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
    public class CN_CertificacionServicios
    {
        CD_CertificacionServicios cs = new CD_CertificacionServicios();
        public DataTable ConsultaCertificacionServicios(string cuit, string nombre, string apellido, int etapa)
        {
            if (string.IsNullOrEmpty(cuit)) cuit = "\0";
            if (string.IsNullOrEmpty(nombre)) nombre = "\0";
            if (string.IsNullOrEmpty(apellido)) apellido = "\0";

            DataTable dt = cs.ConsultaCertificacionServicios(cuit, nombre, apellido, etapa);
            return dt;
        }
        public DataTable ConsultaPersonalCertificacion(string cuit, string nombre, string apellido, bool estado)
        {
            if (string.IsNullOrEmpty(cuit)) cuit = "\0";
            if (string.IsNullOrEmpty(nombre)) nombre = "\0";
            if (string.IsNullOrEmpty(apellido)) apellido = "\0";

            DataTable dt = cs.ConsultaPersonalCertificacion(cuit, nombre, apellido, estado);
            return dt;
        }
        public void AltaCertificacion(int idEmpleado, DateTime fechaPedido)
        {
            cs.AltaCertificacion(idEmpleado, fechaPedido);
        }
        public DateTime? ConsultaFechaUltimaCertificacion(int idEmpleado)
        {
            DataTable resultado = cs.ConsultaFechaUltimaCertificacion(idEmpleado);
            switch (resultado.Rows.Count)
            {
                default:
                    return Convert.ToDateTime(resultado.Rows[0][0]);
                case 0:
                    return null;
            }
             
        }
        public DataTable ConsultaPersonaCertificacion(int idCertificacion)
        {
            DataTable dt = cs.ConsultaPersonaCertificacion(idCertificacion);
            return dt;
        }
        public void UpFechaCertificacion(int idCertificacion, DateTime fecha, int fechaIndex)
        {
            cs.UpFechaCertificacion(idCertificacion, fecha, fechaIndex);
        }
    }
}
