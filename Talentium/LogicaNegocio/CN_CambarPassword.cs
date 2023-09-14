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


        public DataTable ObtenerTodasPregutasSeg()
        {
            return acceso.ConsultarTodasPregSeg();
        }
        public DataTable ObtenerPregutasUsuarios(int id_preg)
        {
            return acceso.Consulta1PgtaSeg(id_preg);
            //return acceso.ConsultaPregSeg(id);
        }
        public DataTable ObtenerRespuetasUsuarios(int id)
        {
            return acceso.ConsultaRtaSeg(id);
            
        }
        public void insertarRta(int idUsuario, string rta, int idPregunta)
        {
            //user ya viene hasheado
            try
            {
               

                acceso.InsertarRespuestaSeg(idUsuario, rta, idPregunta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualiar la contraseña" + ex);
            }
        }
        public void insertarPass(string user, string pass) 
        {
            //user ya viene hasheado
            try 
            {
                string usrBd = Seguridad.DesEncriptar(UserCache.usuario);
                string psw = Seguridad.Hash(usrBd + pass);
                string dig = Seguridad.Hash(Seguridad.DigVerif(Seguridad.Hash(pass)).ToString());
                //el nueva es false porqe en el unico momento que va a ser true es cuando se crea el usuario.
                bool nueva = false;
                acceso.InsertarNuevaPass(user, psw, dig, nueva );
            }catch(Exception ex)
            {
                MessageBox.Show("Error al actualiar la contraseña" + ex);
            }
        }
    }
}
