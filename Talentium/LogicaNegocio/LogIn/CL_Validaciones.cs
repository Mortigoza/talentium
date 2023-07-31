using Comun.LogIn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.LogIn
{
    public class CL_Validaciones
    {

        public Tuple<int, bool, bool> Faltan()
        {
            int dias = 0;
            bool cambia = false;
            bool muestra = false;
            if (UserCache.CambiaCada > 0)
            {
                DateTime fechaCambio = ((DateTime)UserCache.FechaUltimoCambio).AddDays((int)UserCache.CambiaCada);
                TimeSpan difFechas = (TimeSpan)(fechaCambio - DateTime.Now);
                dias = difFechas.Days;
                if (dias <= 5)
                {
                    cambia = true;
                    muestra = true;
                }
            }
            return Tuple.Create(dias, cambia, muestra);
        }


        public bool Vencida()
        {
            bool cambia = false;
            if (UserCache.CambiaCada > 0)
            {
                DateTime fechaCambio = ((DateTime)UserCache.FechaUltimoCambio).AddDays((int)UserCache.CambiaCada);
                TimeSpan difFechas = (fechaCambio - DateTime.Now);
                int dias = difFechas.Days;
                if (dias <= 0)
                {
                    cambia = true;
                }
            }
            return cambia;
        }

        public bool verificarBaja()
        {
            if (UserCache.FechaBaja != null)
            {
                return true;
            }
            return false;
        }


    }
}
