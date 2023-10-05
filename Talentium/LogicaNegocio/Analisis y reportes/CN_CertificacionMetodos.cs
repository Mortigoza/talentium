using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicaNegocio.Analisis_y_reportes
{
    public class CN_CertificacionMetodos
    {
        public (bool, string) verif(DateTimePicker dtt, DataGridView dtg, int idEmpleado)
        {
            if (dtg.DataSource == null | dtg.RowCount == 0)
            {
                return (false, "Debe seleccionar un empleado");
            }
            CN_CertificacionServicios cs = new CN_CertificacionServicios();
            DateTime? dateTime = cs.ConsultaFechaUltimaCertificacion(idEmpleado);
            if (dateTime != null)
            {
                if (DateTime.Today < Convert.ToDateTime(dateTime).AddDays(30))
                {
                    return (false, "Este empleado ya tiene un pedido de certificacion de servicios en los ultimos 30 días");
                }
            }
            return (true, "");
        }
        public DateTime fechaNula(DataGridViewCell fecha)
        {
            if (string.IsNullOrEmpty(fecha.Value.ToString()))
            {
                return DateTime.Today;
            }
            return Convert.ToDateTime(fecha.Value);
        }
        public DateTime fechaNula(DataGridViewCell fecha, DateTime nula)
        {
            if (string.IsNullOrEmpty(fecha.Value.ToString()))
            {
                return nula;
            }
            return Convert.ToDateTime(fecha.Value);
        }
    }
}
