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
        public DataTable ObtenerTipoDoc()
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>() { };

            DataTable resultado = EjecutarConsultas("obtener_tipoDoc_sp", listaParametros.ToArray());
            return resultado;
        }
        public bool ModificarTipoDoc(int id_tipo_doc, string tipo_doc)
        {
            SqlParameter param1 = new SqlParameter("@id_tipo_doc", id_tipo_doc) { SqlDbType = SqlDbType.Int };
            SqlParameter param2 = new SqlParameter("@tipo_doc", tipo_doc) { SqlDbType = SqlDbType.NVarChar };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2 };
            DataTable resultadoModifTipoDoc = EjecutarConsultas("modificar_tipoDoc_sp", listaParametros.ToArray());
            return resultadoModifTipoDoc.Rows.Count != 0;
        }
        public bool EliminarTipoDoc(int id_tipo_doc)
        {
            SqlParameter param1 = new SqlParameter("@id_tipo_doc", id_tipo_doc) { SqlDbType = SqlDbType.Int };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            DataTable resultadoEliminarEntrevista = EjecutarConsultas("eliminar_tipoDoc_sp", listaParametros.ToArray());
            return resultadoEliminarEntrevista.Rows.Count != 0;
        }
        public bool ConsultarTipoDocConPersona(int id_tipo_doc)
        {
            SqlParameter param1 = new SqlParameter("@id_tipo_doc", id_tipo_doc) { SqlDbType = SqlDbType.Int };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            DataTable resultadoPersonaTipoDoc = EjecutarConsultas("consultar_persona_tipoDoc_sp", listaParametros.ToArray());
            return resultadoPersonaTipoDoc.Rows.Count != 0;
        }
    }
}
