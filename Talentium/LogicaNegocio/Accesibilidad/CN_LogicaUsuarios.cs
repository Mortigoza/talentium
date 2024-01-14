using AccesoDatos;
using AccesoDatos.Accesibilidad;
using Comun;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicaNegocio
{
    public class CN_LogicaUsuarios
    {
        public string UsrName { get; set; }
        public string Contrasenia { get; set; }
        public string Mail { get; set; }
        public decimal CambiaCada { get; set; }
        public int IdPersona { get; set; }
        public int RowIndex { get; set; }

        CD_Usuario cd_usuario = new CD_Usuario();
        CD_AccesoBD accesoDatos = new CD_AccesoBD();
        public DataTable ConsultarPersonalAltaUsuario(string cuil, string nombre, string apellido, int area)
        {
            if (string.IsNullOrEmpty(cuil)) cuil = "\0";
            if (string.IsNullOrEmpty(nombre)) nombre = "\0";
            if (string.IsNullOrEmpty(apellido)) apellido = "\0";

            try
            {
                return cd_usuario.ConsultarPersonalAltaUsuario(cuil, nombre, apellido, area);
            }
            catch (Exception ex)
            {
            }
            return null;
        }
        public void InsertarNuevoUsuario(int id_persona, string usuario, string password, int cambia_cada, int[] permisos, string mail, object idPerfil)
        {
            string digito = Seguridad.Hash(Seguridad.DigVerif(Seguridad.Hash(password)).ToString());
            int _idPerfil = (int)idPerfil;
            password = Seguridad.Hash(usuario + password);
            usuario = Seguridad.Encriptar(usuario);

            try
            {
                int id_usuario = cd_usuario.InsertarNuevoUsuario(id_persona, usuario, password, cambia_cada, digito, mail, _idPerfil);
                if (_idPerfil == -1 && permisos.Length > 0)
                {
                    foreach (int id_permiso in permisos)
                    {
                        cd_usuario.InsertarNuevoPermisoUsuario(id_usuario, id_permiso);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable ConsultarAreas()
        {
            try
            {
                DataTable dt = accesoDatos.ConsultaAreas();
                DataRow dr = dt.NewRow();
                dt.Rows.Add(new Object[] { -1, "Todas" });
                return dt;
            }
            catch (Exception ex)
            {
            }
            return null;
        }
        public DataTable ConsultarPermisosLst()
        {
            try
            {
                return cd_usuario.ConsultarPermisosLst();
            }
            catch (Exception ex)
            {
            }
            return null;
        }
        public DataTable ConsultarPerfiles(bool cmb = true)
        {
            try
            {
                DataTable dt = accesoDatos.ConsultarPerfiles();
                if (cmb)
                {
                    DataRow dr = dt.NewRow();
                    dt.Rows.Add(new Object[] { -1, "Personalizado" });
                }
                return dt;
            }
            catch (Exception ex)
            {
            }
            return null;
        }
        public DataTable ConsultarPermisosPerfil(int id_perfil)
        {
            try
            {
                return cd_usuario.ConsultarPermisosPerfil(id_perfil);
            }
            catch (Exception ex)
            {
            }
            return null;
        }
        public string MandarMail(int id_persona, string psw, string mail)
        {
            CN_EnviarEmail email = new CN_EnviarEmail();
            return email.EnviarContraseña(mail, psw);
        }
        public (bool, string) ValidarAltaUsuario(string usr, string psw, DataGridView dtg, int rowIndex)
        {
            if (string.IsNullOrWhiteSpace(usr) | string.IsNullOrWhiteSpace(psw))
            {
                return (false, "Debe completar los campos.");
            }

            if (dtg.DataSource == null)
            {
                return (false, "Debe seleccionar a un empleado para asignarle este usuario.");
            }

            if (!string.IsNullOrEmpty(dtg.Rows[rowIndex].Cells[5].Value.ToString()))
            {
                return (false, "Este empleado ya tiene un usuario asignado.");
            }

            if (cd_usuario.ConsultarUsuarioRepetido(Seguridad.Encriptar(usr)).Rows.Count > 0)
            {
                return (false, "Ese nombre de usuario ya está en uso.");
            }


            return (true, "");
        }
        public bool AltaUsuario(DataTable dtListaMem, object idPerfil, DataGridView dtg)
        {
            int len;
            string msg;
            List<int> permisos = new List<int>();
            Tuple<bool, string> verif = ValidarAltaUsuario(UsrName, Contrasenia, dtg, RowIndex).ToTuple();

            if (verif.Item1)
            {
                // lista de permisos
                len = dtListaMem.Rows.Count;

                if ((int)idPerfil == -1)
                {
                    for (int i = 0; i < len; i++)
                    {
                        // carga todos los permisos del dtListaMem en la lista permisos
                        permisos.Add(Convert.ToInt32(dtListaMem.Rows[i][0]));
                    }
                }
                // Intenta enviar un mail (si se puede manda la contraseña y devuelve un mensaje vacio, sino devuelve un mensaje de error)
                msg = MandarMail(IdPersona, Contrasenia, Mail);
                if (string.IsNullOrEmpty(msg))
                {
                    InsertarNuevoUsuario(IdPersona, UsrName, Contrasenia, (int)CambiaCada, permisos.ToArray(), Mail, idPerfil);
                    return true;
                }
                else
                {
                    MessageBox.Show(msg);
                }
            }
            else
            {
                MessageBox.Show(verif.Item2);
            }
            return false;
        }
    }
}
