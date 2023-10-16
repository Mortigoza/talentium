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
        CD_Seleccion seleccionDatos = new CD_Seleccion();
        CD_AccesoBD accesoDatos = new CD_AccesoBD();

        public bool ExisteCandidato(string cuil)
        {
            return seleccionDatos.ConsultarCandidato(cuil);
        }

        public DataTable obtenerProvincia()
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

        public DataTable ObtenerCandidatosFiltros(string cuil, int id_puesto, string etapa)
        {
            return seleccionDatos.ConsultarCandidatoFiltros(cuil, id_puesto, etapa);
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
            //return seleccionDatos.ModificarEtapa(estado, etapa);
            return true;
        }

        public bool ModificarEstado(int id_candidato, string estado, string patologias)
        {
            return seleccionDatos.ModificarEstado(id_candidato, estado, patologias);
        }
        public bool InsertarEtapa(int id_candidato, DateTime fecha_etapa, string area, string entrevistador)
        {
            return seleccionDatos.InsertarEtapa(id_candidato, fecha_etapa, area, entrevistador);
        }
        public DataTable ObtenerDatosEtapas(int id_candidato)
        {
            return seleccionDatos.ConsultarDatosEtapas(id_candidato);
        }
    }
}
