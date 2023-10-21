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


        public void InsertarPersona(Persona insert, int infoLaborales)
        {
            try
            {
                DataTable dt = AccesoDatos.InsertarPersona(insert);
                int id_persona = Convert.ToInt32(dt.Rows[0][0]);
                InsertarTelefono(insert, id_persona);
                InsertarInformacionLaboral(insert,id_persona,infoLaborales);

    
            }
            catch (Exception ex)
            {
                
                throw new Exception("Error al insertar persona en la base de datos: " + ex.Message);
            }

        }

        public void InsertarInformacionLaboral (Persona insert,int id_persona,int cantidad)
        {
            Dictionary<int, (string puesto, string empresa, int fecha_ingreso, int fecha_egreso, int personal_a_cargo)> informacionLaboral
                = new Dictionary<int, (string, string, int, int, int)>
            {
                { 1, (insert.puesto1, insert.empresa1, insert.fecha_ingreso1,  insert.fecha_egreso1, insert.personal_a_cargo1) },
                { 2, (insert.puesto2, insert.empresa2, insert.fecha_ingreso2,  insert.fecha_egreso2, insert.personal_a_cargo2) },
                { 3, (insert.puesto3, insert.empresa3, insert.fecha_ingreso3,  insert.fecha_egreso3, insert.personal_a_cargo3) },
                { 4, (insert.puesto4, insert.empresa4, insert.fecha_ingreso4,  insert.fecha_egreso4, insert.personal_a_cargo4) }

            };
            for (int i = 1; i <= cantidad; i++)
            {
                string _puesto = informacionLaboral[i].puesto;
                string _empresa = informacionLaboral[i].empresa;
                int _fecha_ingreso = informacionLaboral[i].fecha_ingreso;
                int _fecha_egreso = informacionLaboral[i].fecha_egreso;
                int _personal_a_cargo = informacionLaboral[i].personal_a_cargo;
                AccesoDatos.InsertarInformacionLaboral(id_persona,_puesto,_empresa,_fecha_ingreso,_fecha_egreso,_personal_a_cargo);
                //Console.WriteLine($"ID: {i}, Puesto: {_puesto}, Empresa: {_empresa}, Ingreso: {_fecha_ingreso}, Egreso:" +
                //    $" {_fecha_egreso}, Personal a cargo: {_personal_a_cargo}");


            }
            //Console.WriteLine("----------------------------------------------------");


        }

        //se crea instancia y se almacena en "AccesoDatos"
        public bool ValidarCuit(string cuit_cuil)
        {
            return AccesoDatos.ValidarCuit(cuit_cuil);
            
        }



    }
}
