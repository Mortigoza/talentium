using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using AccesoDatos.Accesibilidad;
using System.Data;

namespace LogicaNegocio
{
    public class CN_LogicaProcesoSeleccion
    {
        CD_Seleccion seleccionDatos = new CD_Seleccion();
        CD_AccesoBD accesoDatos = new CD_AccesoBD();
        CD_Entrevista entrevistaDatos = new CD_Entrevista();

        public DataTable ConsultarCandidato(int id_persona)
        {
            return seleccionDatos.ConsultarCandidato(id_persona);
        }

        public DataTable ObtenerProvincia()
        {
            return seleccionDatos.ConsultarProvincia();
        }

        public DataTable ObtenerPartido(int id_provincia)
        {
            return seleccionDatos.ConsultarPartido(id_provincia);
        }

        public DataTable ObtenerLocalidad(int id_partido)
        {
            return seleccionDatos.ConsultarLocalidad(id_partido);
        }

        public bool InsertarCandidato(string cuil, string nombres, string apellidos, string tel_celular, string tel_alternativo,
            string correo, DateTime fecha_nacimiento, int id_localidad, string calle, int nro, string dpto, string piso,
            int id_puesto)
        {
            seleccionDatos.IngresarCandidato(cuil, nombres, apellidos, tel_celular, tel_alternativo, correo, fecha_nacimiento,
                id_localidad, calle, nro, dpto, piso, id_puesto);
            return true;
        }

        public DataTable ObtenerPuestos()
        {
            return accesoDatos.ConsultaPuestos();
        }

        public DataTable ObtenerCandidatosFiltros(string cuil)
        {
            return seleccionDatos.ConsultarCandidatoFiltros(cuil);
        }

        public DataTable ObtenerEmpleados(int id_area)
        {
            return accesoDatos.ConsultarPersonaConArea(id_area);
        }

        public DataTable ObtenerAreas()
        {
            return accesoDatos.ConsultaAreas();
        }
        public bool ModificarEstado(int id_candidato, string estado, string patologias)
        {
            return seleccionDatos.ModificarEstado(id_candidato, estado, patologias);
        }
        public bool ModificarEtapa(int id_persona, int id_entrevista, DateTime fechaEntrevista, string entrevistador, string estado, string patologias)
        {
            return entrevistaDatos.ModificarEtapa(id_persona, id_entrevista, fechaEntrevista, entrevistador, estado, null);
        }
        public bool InsertarEtapa(int id_candidato, int id_entrevista, DateTime fecha_etapa, string entrevistador,
            string estado, string patologias)
        {
            return seleccionDatos.InsertarEtapa(id_candidato, id_entrevista, fecha_etapa, entrevistador, estado, patologias);
        }
        public DataTable ObtenerDatosEtapas(int id)
        {
            return seleccionDatos.ConsultarDatosEtapas(id);
        }
        public bool ModificarCandidato(string cuil, string nombres, string apellidos, string tel_celular, string tel_alternativo,
            string correo, DateTime fecha_nacimiento, int id_localidad, string calle, int nro, string dpto, string piso,
            int id_puesto)
        {
            return seleccionDatos.ModificarCandidato(cuil, nombres, apellidos, tel_celular, tel_alternativo, correo, fecha_nacimiento,
                id_localidad, calle, nro, dpto, piso, id_puesto);
        }
        public int ObtenerIDEntrevistas(string entrevista)
        {
            return entrevistaDatos.ObtenerIDEntrevistas(entrevista);
        }
    }
}
