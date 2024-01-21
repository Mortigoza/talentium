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
        public DataTable InsertarEntrevista(string entrevista)
        {
            SqlParameter param1 = new SqlParameter("entrevista", entrevista) { SqlDbType = SqlDbType.NVarChar };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
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
    }
}
