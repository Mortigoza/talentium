using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class CN_AsignarCapacitaciones
    {
        public int id_capacitacion { get; set; }

        CD_AccesoBD acceso = new CD_AccesoBD();
        CD_AsignarCapacitaciones cd_asignar = new CD_AsignarCapacitaciones();
        public DataTable ConsultarAreas()
        {
            DataTable dt = acceso.ConsultaAreas();
            DataRow dr = dt.NewRow();
            dt.Rows.Add(new Object[] { -1, "Todas" });
            return dt;
        }
        public DataTable ConsultarCapacitacionesLst()
        {
            DataTable dt = cd_asignar.ConsultarCapacitacionesLst();
            for (int i = 0, len = dt.Rows.Count; i < len; i++)
            {
                if (dt.Rows[i][1].ToString().Contains("))1(("))
                {
                    dt.Columns[1].ReadOnly = false;
                    dt.Rows[i][1] = dt.Rows[i]["capacitacion"].ToString().Replace("))1((", $"({Niveles.cmbNivel1})");
                }
            }
            return dt;
        }
        public DataTable ConsultarPersonal(string cuit, string nombre, string apellido, object area)
        {
            return cd_asignar.ConsultarPersonal(cuit, nombre, apellido, (int)area);
        }
    }
}
