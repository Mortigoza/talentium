using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using Comun;

namespace LogicaNegocio
{
    public class CN_LogicaLogin
    {
        CD_AccesoBD accesoDatos = new CD_AccesoBD();
        public string message { get; set; }
        public DateTime fechaHoy { get; set; }

        public int id { get; set; }
        public bool LoginUser(string usuario, string pass)
        {
            string usr = Seguridad.Encriptar(usuario);
            string psw = Seguridad.Hash(usuario + pass);
            string dig = Seguridad.Hash(Seguridad.DigVerif(Seguridad.Hash(pass)).ToString());
            //Console.WriteLine(usr);
            //Console.WriteLine(psw);
            //Console.WriteLine(dig);
            try
            {
                accesoDatos.Buscar(usr);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            if (CN_Validaciones.ValUsr(usuario, pass))
            {
                return true;
            }
            else if (DateTime.Now < CN_Validaciones.GetHoraDesbloqueo())
            {
                MessageBox.Show($"Limite de intentos alcanzado, intente nuevamente a las {CN_Validaciones.GetHoraDesbloqueo().ToLongTimeString()}", "USUARIO BLOQUEADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                MessageBox.Show(CN_Validaciones.GetMensajeError(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }
        public void BloqueoUser(int id, DateTime? hBloqueo)
        {
            try
            {
                accesoDatos.Bloquear(id, hBloqueo);
            }
            catch
            {
            }
        }
        public void IntentosUser(int id, int intento)
        {
            try
            {
                accesoDatos.Intentos(id, intento);
            }
            catch
            {
            }
        }
        public void CargarFechaHoyIntentosUser(int id, DateTime fechaIntentos)
        {
            try
            {
                accesoDatos.CargarFechaHoyIntentos(id, fechaIntentos, 5);
            }
            catch
            {
            }
        }
        public static bool LogIn(string usuario, string password)
        {
            if (CN_Validaciones.camposVacios(usuario, password))
            {
                CN_LogicaLogin login = new CN_LogicaLogin();
                try
                {
                    if (login.LoginUser(usuario, password)) return true;
                    else return false;
                }
                catch
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Hay campos incompletos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public  void usuarioEmail(string usuario) 
        {
           // string user = Seguridad.Encriptar(usuario);
            DataTable tabla = accesoDatos.EmailDeRecupero(usuario);

            //se valida que el usuario sea ingresado correctamente
            if (tabla != null && tabla.Rows.Count > 0)
            {
                try
                {

                    CN_EnviarEmail email = new CN_EnviarEmail();

                    //el usuario es correcto, por ello debemos genear el codigo y enviar el email
                    string correo = Convert.ToString(tabla.Rows[0][0]);
                    id = Convert.ToInt32(tabla.Rows[0][2]);
                    var tup = email.obtenerCod();
                    string cod = tup.Item1;
                    DateTime fhCaducidad = tup.Item2;

                    message = email.Enviar( id, correo, cod,fhCaducidad );
                       

                    //string feHoy = Convert.ToString(DateTime.Now);
                    //string fechaHoy = feHoy.Substring(0, 8);
                    //string fecha = Convert.ToString(tabla.Rows[0][1]);
                    //string substFecha = fecha.Substring(0, 8);
                    //if (fechaHoy == substFecha && !string.IsNullOrWhiteSpace(fecha))
                    //{

                    //}
                    //else 
                    //{
                    //   /* string message = email.Enviar("mairaaracelirodriguez@gmail.com", "145E12");
                    //    MessageBox.Show(message); */
                    //}

                    //Console.WriteLine(tabla);
                    //Console.WriteLine(tabla.Rows[0][0]);


                    /* string message = email.Enviar("mairaaracelirodriguez@gmail.com", "145E12");
                      MessageBox.Show(message);*/
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error al intentar enviar el email: "+e);
                }
            }
            else 
            {
                MessageBox.Show("Usuario invalido. Porfavor verifique que el usuario sea correcto");
            }

            }

        public bool validCode(int id, string codEmail)
        {
            //verificar como traer el id del usuario, si con la memoria cache o que.
            DataTable tabla = accesoDatos.ValidCode(id);
            DateTime feHoy = DateTime.Now;
            DateTime fechaCaducidad = Convert.ToDateTime(tabla.Rows[0][0]);
            string cod = Convert.ToString(tabla.Rows[0][1]);    
            DateTime feCad = Convert.ToDateTime(tabla.Rows[0][0]).AddHours(-1);
            if (feHoy >= feCad && feHoy <= fechaCaducidad)
            {
                if (codEmail == cod)
                {
                    return true;
                }
                else
                {
                    return false;
                    //codigo erroneo, porfavor intente
                }
            }
            else
            { 
                //el codigo caducó, desea enviarlo nuevamente?
                return false;
            }

            //se realiza el metodo para traer los campos de cod y fecha y validar ambos:
            
        }
        public void cargarCatche(string usuario)
        {
            accesoDatos.Buscar(usuario);
        }
    }
}
