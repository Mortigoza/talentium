﻿using System;
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
        // Tipo de documento
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
            DataTable resultadoEliminarTipoDoc = EjecutarConsultas("eliminar_tipoDoc_sp", listaParametros.ToArray());
            return resultadoEliminarTipoDoc.Rows.Count != 0;
        }
        public bool ConsultarTipoDocConPersona(int id_tipo_doc)
        {
            SqlParameter param1 = new SqlParameter("@id_tipo_doc", id_tipo_doc) { SqlDbType = SqlDbType.Int };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            DataTable resultadoPersonaTipoDoc = EjecutarConsultas("consultar_persona_tipoDoc_sp", listaParametros.ToArray());
            return resultadoPersonaTipoDoc.Rows.Count != 0;
        }

        // Tipo de teléfono
        public DataTable ObtenerTipoTel()
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>() { };

            DataTable resultado = EjecutarConsultas("obtener_tipoTel_sp", listaParametros.ToArray());
            return resultado;
        }
        public bool ConsultarTipoTelRepetido(string tipoTelRepetido)
        {
            SqlParameter param1 = new SqlParameter("@tipoTelRepetido", tipoTelRepetido) { SqlDbType = SqlDbType.NVarChar };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            DataTable resultadoTipoTel = EjecutarConsultas("consultar_tipoTel_repetido_sp", listaParametros.ToArray());

            return resultadoTipoTel.Rows.Count != 0;
        }
        public DataTable InsertarTipoTel(string tipoTel)
        {
            SqlParameter param1 = new SqlParameter("@tipo", tipoTel) { SqlDbType = SqlDbType.NVarChar };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            DataTable resultado = EjecutarConsultas("insertar_tipoTel_sp", listaParametros.ToArray(), true);

            return resultado;
        }
        public bool ModificarTipoTel(int id_tipo, string tipo)
        {
            SqlParameter param1 = new SqlParameter("@id_tipo", id_tipo) { SqlDbType = SqlDbType.Int };
            SqlParameter param2 = new SqlParameter("@tipo", tipo) { SqlDbType = SqlDbType.NVarChar };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2 };
            DataTable resultadoModifTipoTel = EjecutarConsultas("modificar_tipoTel_sp", listaParametros.ToArray());
            return resultadoModifTipoTel.Rows.Count != 0;
        }
        public bool EliminarTipoTel(int id_tipo)
        {
            SqlParameter param1 = new SqlParameter("@id_tipo", id_tipo) { SqlDbType = SqlDbType.Int };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            DataTable resultadoEliminarTipoTel = EjecutarConsultas("eliminar_tipoTel_sp", listaParametros.ToArray());
            return resultadoEliminarTipoTel.Rows.Count != 0;
        }
        public bool ConsultarTipoTelConPersona(int id_tipo)
        {
            SqlParameter param1 = new SqlParameter("@id_tipo", id_tipo) { SqlDbType = SqlDbType.Int };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            DataTable resultadoPersonaTipoTel = EjecutarConsultas("consultar_persona_tipoTel_sp", listaParametros.ToArray());
            return resultadoPersonaTipoTel.Rows.Count != 0;
        }
        // Nacionalidad
        public DataTable ObtenerNacionalidad()
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>() { };

            DataTable resultado = EjecutarConsultas("obtener_nacionalidad_sp", listaParametros.ToArray());
            return resultado;
        }
        public bool ConsultarNacionalidadRepetida(string nacionalidadRepetida)
        {
            SqlParameter param1 = new SqlParameter("@nacionalidadRepetida", nacionalidadRepetida) { SqlDbType = SqlDbType.NVarChar };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            DataTable resultadoNacionalidad = EjecutarConsultas("consultar_nacionalidad_repetida_sp", listaParametros.ToArray());

            return resultadoNacionalidad.Rows.Count != 0;
        }
        public DataTable InsertarNacionalidad(string nacionalidad)
        {
            SqlParameter param1 = new SqlParameter("@nacionalidad", nacionalidad) { SqlDbType = SqlDbType.NVarChar };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            DataTable resultado = EjecutarConsultas("insertar_nacionalidad_sp", listaParametros.ToArray(), true);

            return resultado;
        }
        public bool ModificarNacionalidad(int id_nacionalidad, string nacionalidad)
        {
            SqlParameter param1 = new SqlParameter("@id_nacionalidad", id_nacionalidad) { SqlDbType = SqlDbType.Int };
            SqlParameter param2 = new SqlParameter("@nacionalidad", nacionalidad) { SqlDbType = SqlDbType.NVarChar };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2 };
            DataTable resultadoModifNacionalidad = EjecutarConsultas("modificar_nacionalidad_sp", listaParametros.ToArray());
            return resultadoModifNacionalidad.Rows.Count != 0;
        }
        public bool EliminarNacionalidad(int id_nacionalidad)
        {
            SqlParameter param1 = new SqlParameter("@id_nacionalidad", id_nacionalidad) { SqlDbType = SqlDbType.Int };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            DataTable resultadoEliminarNacionalidad = EjecutarConsultas("eliminar_nacionalidad_sp", listaParametros.ToArray());
            return resultadoEliminarNacionalidad.Rows.Count != 0;
        }
        public bool ConsultarNacionalidadConPersona(int id_nacionalidad)
        {
            SqlParameter param1 = new SqlParameter("@id_nacionalidad", id_nacionalidad) { SqlDbType = SqlDbType.Int };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            DataTable resultadoPersonaNacionalidad = EjecutarConsultas("consultar_persona_nacionalidad_sp", listaParametros.ToArray());
            return resultadoPersonaNacionalidad.Rows.Count != 0;
        }
        // Género
        public DataTable ObtenerGenero()
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>() { };

            DataTable resultado = EjecutarConsultas("obtener_genero_sp", listaParametros.ToArray());
            return resultado;
        }
        public bool ConsultarGeneroRepetido(string generoRepetido)
        {
            SqlParameter param1 = new SqlParameter("@generoRepetido", generoRepetido) { SqlDbType = SqlDbType.NVarChar };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            DataTable resultadoGenero = EjecutarConsultas("consultar_genero_repetida_sp", listaParametros.ToArray());

            return resultadoGenero.Rows.Count != 0;
        }
        public DataTable InsertarGenero(string genero)
        {
            SqlParameter param1 = new SqlParameter("@genero", genero) { SqlDbType = SqlDbType.NVarChar };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            DataTable resultado = EjecutarConsultas("insertar_genero_sp", listaParametros.ToArray(), true);

            return resultado;
        }
        public bool ModificarGenero(int id_genero, string genero)
        {
            SqlParameter param1 = new SqlParameter("@id_genero", id_genero) { SqlDbType = SqlDbType.Int };
            SqlParameter param2 = new SqlParameter("@genero", genero) { SqlDbType = SqlDbType.NVarChar };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2 };
            DataTable resultadoModifGenero = EjecutarConsultas("modificar_genero_sp", listaParametros.ToArray());
            return resultadoModifGenero.Rows.Count != 0;
        }
        public bool EliminarGenero(int id_genero)
        {
            SqlParameter param1 = new SqlParameter("@id_genero", id_genero) { SqlDbType = SqlDbType.Int };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            DataTable resultadoEliminarGenero = EjecutarConsultas("eliminar_genero_sp", listaParametros.ToArray());
            return resultadoEliminarGenero.Rows.Count != 0;
        }
        public bool ConsultarGeneroConPersona(int id_genero)
        {
            SqlParameter param1 = new SqlParameter("@id_genero", id_genero) { SqlDbType = SqlDbType.Int };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            DataTable resultadoPersonaGenero = EjecutarConsultas("consultar_persona_genero_sp", listaParametros.ToArray());
            return resultadoPersonaGenero.Rows.Count != 0;
        }
    }
}
