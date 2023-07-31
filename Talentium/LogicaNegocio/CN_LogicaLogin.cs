using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;


namespace LogicaNegocio
{
    public class CN_LogicaLogin
    {
        CD_AccesoBD accesoDatos = new CD_AccesoBD();
        public DataTable LoginUser(string usuario, string pass)
        {
            try
            {
                return accesoDatos.Buscar(usuario, pass); ;
            }
            catch (Exception ex) {
                throw ex;
            }
        }
    }
}
