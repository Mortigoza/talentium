using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Accesibilidad
{
    public class CD_Entrevista : CD_EjecutarSP
    {
        public DataTable InsertarEntrevista(int instancia, string entrevista)
        {
            SqlParameter param1 = new SqlParameter("instancia", instancia) { SqlDbType = SqlDbType.Int };
            SqlParameter param2 = new SqlParameter("entrevista", entrevista) { SqlDbType = SqlDbType.NVarChar };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2 };
            DataTable resultado = EjecutarConsultas("alta_entrevista_sp", listaParametros.ToArray(), true);

            return resultado;
        }
        public bool ConsultarEntrevistaRepetida(string entrevista)
        {
            SqlParameter param1 = new SqlParameter("@entrevista", entrevista) { SqlDbType = SqlDbType.NVarChar };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            DataTable resultadoEntrevista = EjecutarConsultas("consultar_entrevista_repetida_sp", listaParametros.ToArray());

            return resultadoEntrevista.Rows.Count != 0;
        }
        public DataTable ConsultarEntrevistas()
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>() { };

            DataTable resultado = EjecutarConsultas("consultar_entrevistas_sp", listaParametros.ToArray());
            return resultado;
        }
        public bool ModificarEntrevista(int idRegistroSeleccionado, int etapa, string nuevaEntrevista)
        {
            SqlParameter param1 = new SqlParameter("@id_entrevista", idRegistroSeleccionado) { SqlDbType = SqlDbType.Int };
            SqlParameter param2 = new SqlParameter("@etapa", etapa) { SqlDbType = SqlDbType.Int };
            SqlParameter param3 = new SqlParameter("@entrevista", nuevaEntrevista) { SqlDbType = SqlDbType.NVarChar };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2, param3 };
            DataTable resultadoModifEntrevista = EjecutarConsultas("modificar_entrevista_sp", listaParametros.ToArray());
            return resultadoModifEntrevista.Rows.Count != 0;
        }
        public bool EliminarEntrevista(int id_entrevista)
        {
            SqlParameter param1 = new SqlParameter("@id_entrevista", id_entrevista) { SqlDbType = SqlDbType.Int };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            DataTable resultadoEliminarEntrevista = EjecutarConsultas("eliminar_entrevista_sp", listaParametros.ToArray());
            return resultadoEliminarEntrevista.Rows.Count != 0;
        }
    }
}
