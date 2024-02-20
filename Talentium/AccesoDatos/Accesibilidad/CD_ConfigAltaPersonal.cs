using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Accesibilidad
{
    public class CD_ConfigAltaPersonal : CD_EjecutarSP
    {
        public DataTable InsertarTipoDoc (string tipoDoc)
        {
            SqlParameter param1 = new SqlParameter("@tipo_doc", tipoDoc) { SqlDbType = SqlDbType.NVarChar };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            DataTable resultado = EjecutarConsultas("insertar_tipoDoc_sp", listaParametros.ToArray(), true);

            return resultado;
        }
        public bool ConsultarTipoDocRepetido(string tipoDocRepetido)
        {
            SqlParameter param1 = new SqlParameter("@tipoDocRepetido", tipoDocRepetido) { SqlDbType = SqlDbType.NVarChar };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            DataTable resultadoTipoDoc = EjecutarConsultas("consultar_tipoDoc_repetido_sp", listaParametros.ToArray());

            return resultadoTipoDoc.Rows.Count != 0;
        }
    }
}
