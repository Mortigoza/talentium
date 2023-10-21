using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using System.Data;
using System.Data.SqlClient;
using Comun;
using AccesoDatos.Administracion_Personal;
namespace LogicaNegocio.Administracion_Del_Personal
{
    public class CN_AdministracionDatosPersonal
    {
        private CD_AccesoBDPersonacs AccesoDatos = new CD_AccesoBDPersonacs();
        public void InsertarTelefono (Persona insert,int id_persona)
        {
            
            AccesoDatos.InsertarTelefono(id_persona,insert.telefono,insert.id_tipo,true);
            AccesoDatos.InsertarTelefono(id_persona, insert.telefono_alternativo, insert.id_tipo_alternativo, false ,insert.contacto);
        }


        public void InsertarPersona(Persona insert)
        {
            try
            {
              DataTable dt = AccesoDatos.InsertarPersona(insert);
                int id_persona = Convert.ToInt32(dt.Rows[0][0]);
                InsertarTelefono(insert,id_persona);
            }
            catch (Exception ex)
            {
                
                throw new Exception("Error al insertar persona en la base de datos: " + ex.Message);
            }

        }
        //se crea instancia y se almacena en "AccesoDatos"
        public bool ValidarCuit(string cuit_cuil)
        {
            return AccesoDatos.ValidarCuit(cuit_cuil);
            
        }



    }
}
