using AccesoDatos;
using Comun;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicaNegocio
{
    public class CN_LogicaUsuarios
    {
		CD_AccesoBD accesoDatos = new CD_AccesoBD();
        public DataTable ConsultarPersonalAltaUsuario(string cuil, string nombre, string apellido, int area)
        {
            if (string.IsNullOrEmpty(cuil)) cuil = "\0";
            if (string.IsNullOrEmpty(nombre)) nombre = "\0";
            if (string.IsNullOrEmpty(apellido)) apellido = "\0";

            try
            {
                return accesoDatos.ConsultarPersonalAltaUsuario(cuil, nombre, apellido, area);
            }
            catch (Exception ex)
            {
            }
            return null;
        }
        public void InsertarNuevoUsuario(int id_persona, string usuario, string password, int cambia_cada, int[] permisos, string mail)
        {
            string digito = Seguridad.Hash(Seguridad.DigVerif(Seguridad.Hash(password)).ToString());

            password = Seguridad.Hash(usuario + password);
            usuario = Seguridad.Encriptar(usuario);

            try
            {
                int id_usuario = accesoDatos.InsertarNuevoUsuario(id_persona, usuario, password, cambia_cada, digito, mail);
                if (permisos.Length > 0)
                {
                    foreach (int id_permiso in permisos)
                    {
                        accesoDatos.InsertarNuevoPermisoUsuario(id_usuario, id_permiso);
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
                dt.Rows.Add(new Object[] { -1, "Todas"});
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
                return accesoDatos.ConsultarPermisosLst();
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
                return accesoDatos.ConsultarPermisosPerfil(id_perfil);
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

            if (accesoDatos.ConsultarUsuarioRepetido(Seguridad.Encriptar(usr)).Rows.Count > 0)
            {
                return (false, "Ese nombre de usuario ya está en uso.");
            }


            return (true, "");
        }
    }
}
