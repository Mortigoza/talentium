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
            string psw = Seguridad.Hash(user + pass);
                acceso.InsertarNuevaPass(user, psw);
            }catch(Exception ex)
            {
                MessageBox.Show("Error al actualiar la contraseña" + ex);
            }
        }
    }
}
