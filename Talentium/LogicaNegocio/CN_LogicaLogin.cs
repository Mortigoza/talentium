using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.Linq;
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
        public void LoginUser(string usuario, string pass)
        {
            string usr = Seguridad.Encriptar(usuario);
            string psw = Seguridad.Hash(usuario + pass);
            string dig = Seguridad.Hash(Seguridad.DigVerif(Seguridad.Hash(pass)).ToString());
            //Console.WriteLine(usr);
            //Console.WriteLine(psw);
            //Console.WriteLine(dig);
            try
            {
                accesoDatos.Buscar(usr, psw);
            }
            catch (Exception ex)
            {
                throw ex;
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
        public static void LogIn(string usuario, string password)
        {
            if (CN_Validaciones.camposVacios(usuario, password))
            {
                CN_LogicaLogin login = new CN_LogicaLogin();
                try
                {
                    login.LoginUser(usuario, password);
                }
                catch
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                try
                {
                    if (CN_Validaciones.ValUsr(usuario, password))
                    {
                        MessageBox.Show("ENTRASTE", "BIEN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (DateTime.Now < CN_Validaciones.GetHoraDesbloqueo())
                    {
                        MessageBox.Show($"Limite de intentos alcanzado, intente nuevamente a las {CN_Validaciones.GetHoraDesbloqueo().ToLongTimeString()}", "USUARIO BLOQUEADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show(CN_Validaciones.GetMensajeError(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch { }
            }
            else
            {
                MessageBox.Show("Hay campos incompletos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
