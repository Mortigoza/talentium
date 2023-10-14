using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using System.Data;

namespace LogicaNegocio
{
    public class CN_LogicaProcesoSeleccion
    {
        CD_AccesoBD accesoDatos = new CD_AccesoBD();

        public bool ExisteCandidato(string cuil)
        {
            return accesoDatos.ConsultarCandidato(cuil);
        }

        public DataTable obtenerProvincia()
        {
            return accesoDatos.ConsultarProvincia();
        }

        public DataTable ObtenerPartido(int id_provincia)
        {
            return accesoDatos.ConsultarPartido(id_provincia);
        }

        public DataTable ObtenerLocalidad(int id_partido)
        {
            return accesoDatos.ConsultarLocalidad(id_partido);
        }

        public bool InsertarCandidato(string cuil, string nombres, string apellidos, string tel_celular, string tel_alternativo,
            string correo, DateTime fecha_nacimiento, int id_localidad, string calle, int nro, string dpto, string piso,
            int id_puesto)
        {
            accesoDatos.IngresarCandidato(cuil, nombres, apellidos, tel_celular, tel_alternativo, correo, fecha_nacimiento,
                id_localidad, calle, nro, dpto, piso, id_puesto);
            return true;
        }

        public DataTable ObtenerPuestos()
        {
            return accesoDatos.ConsultaPuestos();
        }

        public DataTable ObtenerCandidatosFiltros(string cuil, int id_puesto, string etapa)
        {
            return accesoDatos.ConsultarCandidatoFiltros(cuil, id_puesto, etapa);
        }

        public DataTable ObtenerEmpleados(int id_area)
        {
            return accesoDatos.ConsultarPersonaConArea(id_area);
        }

        public DataTable ObtenerAreas()
        {
            return accesoDatos.ConsultaAreas();
        }

        public bool ModificarEtapa(string estado, string etapa)
        {
            return accesoDatos.ModificarEtapa(estado, etapa);
        }

        public bool ModificarEstado(int id_candidato, string estado)
        {
            return accesoDatos.ModificarEstado(id_candidato, estado);
        }
        public bool InsertarSegundaEntrevista(int id_candidato, DateTime fecha_etapa, string area, string entrevistador)
        {
            return accesoDatos.InsertarSegundaEntrevista(id_candidato, fecha_etapa, area, entrevistador);
        }
    }
}
