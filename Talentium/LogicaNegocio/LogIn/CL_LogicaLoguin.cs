using AccesoDatos.LogIn;
using Comun;
using Comun.LogIn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.LogIn
{
    public class CL_LogicaLoguin : CL_Validaciones
    {
        private readonly CD_ConectarUsuario CDCargarUsuario = new CD_ConectarUsuario();
        private readonly CD_BuscarUser CDBuscar = new CD_BuscarUser();
        int IdUser = 0;

        public string VerificarUsuario(string User, string Pass)
        {
            string mensaje;
            if (CDCargarUsuario.CDVerificarUsuario(User, Seguridad.Hash(Pass)) == false)
            {
                mensaje = "Usuario o Password inexistente";
                IdUser = CDBuscar.CDbuscarUser(User);
                if (IdUser != 0)
                {
                    _ = new CD_GuardarLogueosErroneos(IdUser);
                    CD_ConsultarLogueos buscar = new CD_ConsultarLogueos();
                    if (buscar.Buscar(IdUser) >= 3)
                    {
                        _ = new CL_BloquearUsuario(IdUser);
                        mensaje = "Usuario o Password inexistente \n \n El USUARIO HA SIDO BLOQUEADO!!";
                    }
                }
            }
            else
            {
                //Cargo en la capa de sistema las restricciones para las passwords
                CD_Pass_TraerConfiguraciones configPAss = new CD_Pass_TraerConfiguraciones();
                configPAss.Pass_TraerConfiguraciones();


                //VALIDACIONES
                if (verificarBaja()) //verifico si esta dado de baja
                    mensaje = "Usuario dado de baja";
                else if (UserCache.UsuarioDesactivado == true) //verifico si esta bloqueado
                    mensaje = "EL USUARIO SE ENCUENTRA BLOQUEADO \n \n " +
                        "COMUNIQUESE CON EL ADMINISTRADOR DEL SISTEMA!!";
                else if (Vencida())  //verifico si la password vencio y debe cambiarla
                    mensaje = "la clave se encuentra vencida";
                else if (Faltan().Item3) //verifico cuanto falta para el vencimiento
                    mensaje = $"La clave expira en {Faltan().Item1} dias.";
                else
                    mensaje = "Ingreso Exitoso"; // si todo esta OK que ingrese
                LeerPermmisos();
            }
        }
    }
}
