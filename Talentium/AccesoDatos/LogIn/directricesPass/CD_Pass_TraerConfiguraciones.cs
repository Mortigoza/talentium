using CapaSesion;
using CapaSistema;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos.Loguin.directricesPass
{
    public class CD_Pass_TraerConfiguraciones : CD_EjecutarConsultasSP
    {
        readonly List<SqlParameter> listaParametros = new List<SqlParameter>();
        public void Pass_TraerConfiguraciones()
        {
            DataTable DT = EjecutarConsultas("Pass_TraerConfiguraciones", listaParametros.ToArray());
            if (DT != null | DT.Rows.Count > 0)
            {
                foreach (DataRow row in DT.Rows)
                {
                    DirectricesPassword.LDirectricesPAss.Add(new DirectrizPass()
                    {
                        IdRestriccion = (int)row["IdConf"],
                        Descripcion = (string)row["DescripConfig"],
                        Estado = (bool)row["Activo"],
                        Tipo = (int)row["Tipo"]
                    });
                }
            }
        }
    }
}
