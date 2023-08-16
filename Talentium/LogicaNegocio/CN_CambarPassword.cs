using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Data;
using AccesoDatos;
using Comun;
using System.Windows.Forms;

namespace LogicaNegocio
{
   public class CN_CambarPassword
    {
        CD_AccesoBD acceso = new CD_AccesoBD();


        public DataTable ObtenerPregutasUsuarios(int id)
        {
            return acceso.ConsultaPregSeg(id);
        }

        public void insertarPass(string user, string pass) 
        {
            //user ya viene hasheado
            try 
            {
                string usrBd = Seguridad.DesEncriptar(UserCache.usuario);
                string psw = Seguridad.Hash(usrBd + pass);
                string dig = Seguridad.Hash(Seguridad.DigVerif(Seguridad.Hash(pass)).ToString());

                acceso.InsertarNuevaPass(user, psw, dig);
            }catch(Exception ex)
            {
                MessageBox.Show("Error al actualiar la contraseña" + ex);
            }
        }
    }
}
