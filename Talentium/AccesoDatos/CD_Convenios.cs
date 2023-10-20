﻿using Comun;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class CD_Convenios : CD_EjecutarSP
    {

        public DataTable ObtenerConvenios()
        {
            DataTable resultado = EjecutarConsultasSinParam("SelectConvenios");

            return resultado;
        }


        public DataTable ObtenerCategoriaPorId(int id)
        {


            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@id_categoria", id));
            DataTable resultado = EjecutarConsultas("ObtenerCategoriaPorID_sp", parametros.ToArray());

            return resultado;
        }

        public void InsertarConvenios(ConvenioDto convenio)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@convenio", convenio.convenio));
            parametros.Add(new SqlParameter("@seguridad_salud", convenio.seguridad_salud));
            parametros.Add(new SqlParameter("@obra_social", convenio.obra_social));
            parametros.Add(new SqlParameter("@id_categoria", convenio.id_categoria));


            EjecutarConsultas("InsertarConvenio", parametros.ToArray(), true);
        }


        public void ModificarConvenio(ConvenioDto convenio, int id)
        {

            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@id_convenio", id));
            parametros.Add(new SqlParameter("@convenio", convenio.convenio));
            parametros.Add(new SqlParameter("@obra_social", convenio.obra_social));
            parametros.Add(new SqlParameter("@seguridad_salud", convenio.seguridad_salud)); 
            parametros.Add(new SqlParameter("@id_categoria", convenio.id_categoria));


            EjecutarConsultas("ModificarConvenio_sp", parametros.ToArray(), true);
        }


        public DataTable EliminarConvenio(int id_convenio)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@id_convenio", id_convenio));
            DataTable dt = EjecutarConsultas("EliminarConvenio_sp", parametros.ToArray());
            return dt; 
        }
    }
}
