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
        private bool filtroUtilizado = false;
        private int filas;
        private int nFilas;
        private string cuil;
        private string cuilCuit;
        private string etapaDT;
        private string etapaDG;
        private string nomCol;
        private string nomEtapa;
        private string valFecha;
        private string newNomCol;
        private DataTable lista;
        private DataTable entrevPersonal;
        private DataTable todasEtapas;
        private DataTable dtCandidatos;
        private bool todasCoinciden = true;
        private bool etapaAntDatos = true;

        public bool Tcoinciden
        {
            get { return todasCoinciden; }
            set { todasCoinciden = value; }
        }
        public DataTable DtCandidatos
        {
            get { return dtCandidatos; }
            set { dtCandidatos = value; }
        } 

        public DataTable Lista
        {
            get { return lista; }
            set { lista = value; }
        }
        public string NewNomCol
        {
            get { return newNomCol; }
            set { newNomCol = value; }
        }
        public string NomCol
        {
            get { return nomCol; }
            set { nomCol = value; }
        }
        public string ValFecha
        {
            get { return valFecha; }
            set { valFecha = value; }
        } 
        public string EtapaDT
        {
            get { return etapaDT; }
            set { etapaDT = value; }
        } 
        public string EtapaDG
        {
            get { return etapaDG; }
            set { etapaDG = value; }
        }
        public string CuilCuit
        {
            get { return cuilCuit; }
            set { cuilCuit = value; }
        }
        public string Cuil
        {
            get { return cuil; }
            set { cuil = value; }
        }
        public int Nfilas
        {
            get { return nFilas; }
            set { nFilas = value; }
        }
        public int Filas
        {
            get { return filas; }
            set { filas = value; }
        }
        public bool FiltroUtilizado
        {
            get { return filtroUtilizado; }
            set { filtroUtilizado = value; }
        }
        public DataTable ConsultarCandidato(int id_persona)
        {
            return seleccionDatos.ConsultarCandidato(id_persona);
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
        public int ObtenerIDEntrevistas(string entrevista)
        {
            return entrevistaDatos.ObtenerIDEntrevistas(entrevista);
        }
        public int ObtenerIDPersona(string cuil)
        {
            return seleccionDatos.ConsultarIDporCuil(cuil);
        }
    }
}
