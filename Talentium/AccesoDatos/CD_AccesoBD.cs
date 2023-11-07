using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using Comun;
using System.Linq.Expressions;

namespace AccesoDatos
{
    public class CD_AccesoBD : CD_EjecutarSP
    {
        public void CargarCodyFHRecupero( int id, string cod, DateTime fechaCaducidad )
        {
            SqlParameter param1 = new SqlParameter("@id_usuario", id) { SqlDbType = SqlDbType.Int };
            SqlParameter param2 = new SqlParameter("@fh_cod_email", fechaCaducidad) { SqlDbType = SqlDbType.DateTime };
            SqlParameter param3 = new SqlParameter("@cod_email", cod) { SqlDbType = SqlDbType.NChar };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2, param3 };
            
                DataTable resultado = EjecutarConsultas("upCodFechaRecupero_sp", listaParametros.ToArray(), true);
        
        }

        public void upPolPass(bool min_carct, bool comb_may, bool num_letras, bool caract_esp, bool contra_ant, bool datos_per)
        {
            SqlParameter param1 = new SqlParameter("@min_caracteres", min_carct) { SqlDbType = SqlDbType.Bit };
            SqlParameter param2 = new SqlParameter("@comb_mayus", comb_may) { SqlDbType = SqlDbType.Bit };
            SqlParameter param3 = new SqlParameter("@num_letras", num_letras) { SqlDbType = SqlDbType.Bit };
            SqlParameter param4 = new SqlParameter("@caract_especial", caract_esp) { SqlDbType = SqlDbType.Bit };
            SqlParameter param5 = new SqlParameter("@contra_anteriores", contra_ant) { SqlDbType = SqlDbType.Bit };
            SqlParameter param6 = new SqlParameter("@datos_personales", datos_per) { SqlDbType = SqlDbType.Bit };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2, param3, param4, param5, param6 };

            DataTable resultado = EjecutarConsultas("upPoliticaPass_sp", listaParametros.ToArray(), true);

        }
        public void ConsultaPoliticaPass()
        {
           
            List<SqlParameter> listaParametros = new List<SqlParameter>() { };

            DataTable resultado = EjecutarConsultas("consPoliticaPass_sp", listaParametros.ToArray());

            ConfigCache.caracteres = (bool)resultado.Rows[0][1];
            ConfigCache.mayusculas = (bool)resultado.Rows[0][2];
            ConfigCache.numeros = (bool)resultado.Rows[0][3];
            ConfigCache.especiales = (bool)resultado.Rows[0][4];
            ConfigCache.passAnteriores = (bool)resultado.Rows[0][5];
            ConfigCache.noDatosPersonales = (bool)resultado.Rows[0][6];
        }


        //METODOS CATEGORIA
    

        //METODOS CONVENIOS


      

        //public void EliminarCategorias(int id_categoria)
        //{

        //    List<SqlParameter> parametros = new List<SqlParameter>();
        //    parametros.Add(new SqlParameter("@id_categoria", id_categoria));
        //    EjecutarConsultas("EliminarCategoria", parametros.ToArray(), true);
        //}


        //public void ModificarCategoria(CategoriaDto categoria, int id)
        //{

        //    List<SqlParameter> parametros = new List<SqlParameter>();
        //    parametros.Add(new SqlParameter("@id_categoria", id));
        //    parametros.Add(new SqlParameter("@nombre_categoria", categoria.categoria));
        //    parametros.Add(new SqlParameter("@jornada", categoria.jornada));
        //    parametros.Add(new SqlParameter("@sueldos", categoria.sueldo));


        //    EjecutarConsultas("ModificarCategoria", parametros.ToArray(), true);
        //}



        public DataTable ConsultarTodasPregSeg()
        {
            DataTable resultado = EjecutarConsultasSinParam("consultarPreguntas_sp");

            return resultado;
        }
        public DataTable ConsultaRtaSeg(int usuario)
        {
            SqlParameter param1 = new SqlParameter("@id_usuario", usuario) { SqlDbType = SqlDbType.Int };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            DataTable resultado = EjecutarConsultas("consultarRespuestas_sp", listaParametros.ToArray());

            return resultado;
        }
        public DataTable Consulta1PgtaSeg(int pgtas)
        {
            SqlParameter param1 = new SqlParameter("@id_pregunta", pgtas) { SqlDbType = SqlDbType.Int };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            DataTable resultado = EjecutarConsultas("consultarPreg_sp", listaParametros.ToArray());

            return resultado;
        }

        public void InsertarNuevaPass( string user, string pass, string dig, bool nueva)
        {
            SqlParameter param1 = new SqlParameter("@usuario", user) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param2 = new SqlParameter("@password", pass) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param3 = new SqlParameter("@digitoVerf", dig) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param4 = new SqlParameter("@nuevo", nueva) { SqlDbType = SqlDbType.Bit };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2, param3, param4 };

            DataTable resultado = EjecutarConsultas("upPassword_sp", listaParametros.ToArray(), true);

        }
        public void InsertarRespuestaSeg( int idUs, string rta, int idPregunta)
        {
            SqlParameter param1 = new SqlParameter("@id_usuario", idUs) { SqlDbType = SqlDbType.Int };
            SqlParameter param2 = new SqlParameter("@respuesta", rta) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param3 = new SqlParameter("@id_pregunta", idPregunta) { SqlDbType = SqlDbType.Int };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2, param3 };

            DataTable resultado = EjecutarConsultas("InsRespuesta_sp", listaParametros.ToArray(), true);

        }
        public int InsertarNuevoUsuario(int id_persona, string usuario, string password, int cambia_cada, string digito, string mail)
        {
            SqlParameter param1 = new SqlParameter("@id_persona", id_persona) { SqlDbType = SqlDbType.Int };
            SqlParameter param2 = new SqlParameter("@usuario", usuario) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param3 = new SqlParameter("@password", password) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param4 = new SqlParameter("@cambia_cada", cambia_cada) { SqlDbType = SqlDbType.Int };
            SqlParameter param5 = new SqlParameter("@digito", digito) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param6 = new SqlParameter("@intentos", ConfigCache.Intentos) { SqlDbType = SqlDbType.Int };
            SqlParameter param7 = new SqlParameter("@email", mail) { SqlDbType = SqlDbType.NVarChar };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2, param3, param4, param5, param6, param7 };

            DataTable id_usuario = EjecutarConsultas("alta_usuario_sp", listaParametros.ToArray());
            return Convert.ToInt32(id_usuario.Rows[0][0]);
        }
        public void InsertarNuevoPermisoUsuario(int id_usuario, int id_permiso)
        {
            SqlParameter param1 = new SqlParameter("@id_usuario", id_usuario) { SqlDbType = SqlDbType.Int };
            SqlParameter param2 = new SqlParameter("@id_permiso", id_permiso) { SqlDbType = SqlDbType.Int };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2};

            EjecutarConsultas("alta_permiso_de_usuario_sp", listaParametros.ToArray(), true);

        }
        public DataTable ConsultarPersonalAltaUsuario(string cuil, string nombre, string apellido, int area)
        {
            SqlParameter param1 = new SqlParameter("@cuil", cuil) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param2 = new SqlParameter("@nombre", nombre) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param3 = new SqlParameter("@apellido", apellido) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param4 = new SqlParameter("@id_area", area) { SqlDbType = SqlDbType.Int };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2, param3, param4 };

            DataTable resultado = EjecutarConsultas("consultar_personal_alta_usuario_sp", listaParametros.ToArray());
            return resultado;

        }
        public DataTable ConsultaAreas()
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>() { };

            DataTable resultado = EjecutarConsultas("consultar_areas_sp", listaParametros.ToArray());
            return resultado;
        }
        public DataTable ConsultarPermisosLst()
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>() { };

            DataTable resultado = EjecutarConsultas("consultar_permisos_lst_sp", listaParametros.ToArray());
            return resultado;
        }
        public DataTable ConsultarPerfiles()
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>() { };

            DataTable resultado = EjecutarConsultas("consultar_perfiles_sp", listaParametros.ToArray());
            return resultado;
        }
        public DataTable ConsultarPermisosPerfil(int id_perfil)
        {
            SqlParameter param1 = new SqlParameter("@id_perfil", id_perfil) { SqlDbType = SqlDbType.Int };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };

            DataTable resultado = EjecutarConsultas("consultar_permisos_perfil_sp", listaParametros.ToArray());
            return resultado;
        }
        public DataTable ConsultarUsuarioRepetido(string usuario)
        {
            SqlParameter param1 = new SqlParameter("@usuario", usuario) { SqlDbType = SqlDbType.NVarChar };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };

            DataTable resultado = EjecutarConsultas("consultar_usuario_repetido_sp", listaParametros.ToArray());
            return resultado;
        }
        public string ConsultarMailPersona(int id_persona)
        {
            SqlParameter param1 = new SqlParameter("@id_persona", id_persona) { SqlDbType = SqlDbType.Int };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };

            DataTable email = EjecutarConsultas("consultar_mail_persona_sp", listaParametros.ToArray());
            return email.Rows[0][0].ToString();
        }

        /****************************** FORM AREA *****************************/

        public void InsertarArea(string area)
        {
            SqlParameter param1 = new SqlParameter("@area", area) { SqlDbType = SqlDbType.NVarChar };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };

            EjecutarConsultas("alta_area_sp", listaParametros.ToArray(), true);
        }

        public bool ConsultarAreaRepetida(string area)
        {
            SqlParameter param1 = new SqlParameter("@area", area) { SqlDbType = SqlDbType.NVarChar };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            DataTable resultadoArea = EjecutarConsultas("consultar_area_repetida_sp", listaParametros.ToArray());

            return resultadoArea.Rows.Count != 0;
        }

        public bool ModificarArea(int idRegistroSeleccionado, string nuevaArea)
        {
            SqlParameter param1 = new SqlParameter("@idArea", idRegistroSeleccionado) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param2 = new SqlParameter("@nuevaArea", nuevaArea) { SqlDbType = SqlDbType.NVarChar };
            
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2 };
            DataTable resultadoModifArea = EjecutarConsultas("modificar_area_sp", listaParametros.ToArray());
            return resultadoModifArea.Rows.Count != 0;
        }

        public bool ConsultarAreaConPersona(int idArea)
        {
            SqlParameter param1 = new SqlParameter("@idArea", idArea) { SqlDbType = SqlDbType.NVarChar };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            DataTable resultadoPersonaArea = EjecutarConsultas("consultar_persona_area_sp", listaParametros.ToArray());
            return resultadoPersonaArea.Rows.Count != 0;
        }

        public bool EliminarArea(int idArea)
        {
            SqlParameter param1 = new SqlParameter("@idArea", idArea) { SqlDbType = SqlDbType.NVarChar };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            DataTable resultadoEliminarArea = EjecutarConsultas("eliminar_area_sp", listaParametros.ToArray());
            return resultadoEliminarArea.Rows.Count != 0;
        }

        /****************************** FORM PUESTOS *****************************/
        public DataTable ConsultaPuestos()
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>() { };

            DataTable resultado = EjecutarConsultas("consultar_puestos_sp", listaParametros.ToArray());
            return resultado;
        }

        public void InsertarPuesto(string puesto)
        {
            SqlParameter param1 = new SqlParameter("@puesto", puesto) { SqlDbType = SqlDbType.NVarChar };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };

            EjecutarConsultas("alta_puesto_sp", listaParametros.ToArray(), true);
        }

        public bool ConsultarPuestoRepetido(string puesto)
        {
            SqlParameter param1 = new SqlParameter("@puesto", puesto) { SqlDbType = SqlDbType.NVarChar };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            DataTable resultadoPuesto = EjecutarConsultas("consultar_puesto_repetido_sp", listaParametros.ToArray());

            return resultadoPuesto.Rows.Count != 0;
        }

        public bool ModificarPuesto(int idRegistroSeleccionado, string nuevoPuesto)
        {
            SqlParameter param1 = new SqlParameter("@idPuesto", idRegistroSeleccionado) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param2 = new SqlParameter("@nuevoPuesto", nuevoPuesto) { SqlDbType = SqlDbType.NVarChar };

            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2 };
            DataTable resultadoModifPuesto = EjecutarConsultas("modificar_puesto_sp", listaParametros.ToArray());
            return resultadoModifPuesto.Rows.Count != 0;
        }

        public bool ConsultarPuestoConPersona(int idPuesto)
        {
            SqlParameter param1 = new SqlParameter("@idPuesto", idPuesto) { SqlDbType = SqlDbType.NVarChar };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            DataTable resultadoPersonaPuesto = EjecutarConsultas("consultar_persona_puesto_sp", listaParametros.ToArray());
            return resultadoPersonaPuesto.Rows.Count != 0;
        }

        public bool EliminarPuesto(int idPuesto)
        {
            SqlParameter param1 = new SqlParameter("@idPuesto", idPuesto) { SqlDbType = SqlDbType.NVarChar };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            DataTable resultadoEliminarPuesto = EjecutarConsultas("eliminar_puesto_sp", listaParametros.ToArray());
            return resultadoEliminarPuesto.Rows.Count != 0;
        }

        /******************** FORM ALTA EVALUACION DE DESEMPEÑO ********************/
        public DataTable ConsultarPersonaConArea(int idArea)
        {
            SqlParameter param1 = new SqlParameter("@idArea", idArea) { SqlDbType = SqlDbType.NVarChar };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            DataTable resultadoPersonaArea = EjecutarConsultas("consultar_persona_area_sp", listaParametros.ToArray());
            return resultadoPersonaArea;
        }

        public void InsertarEvaluacionDesempenio(string anio, string mes, int efectTareas, int puntualidad, int relSup, 
            int disciplina, int desempEquipo, int id_persona, int id_area)
        {
            SqlParameter param1 = new SqlParameter("@anio", anio) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param2 = new SqlParameter("@mes", mes) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param3 = new SqlParameter("@efectTareas", efectTareas) { SqlDbType = SqlDbType.Int };
            SqlParameter param4 = new SqlParameter("@puntualidad", puntualidad) { SqlDbType = SqlDbType.Int };
            SqlParameter param5 = new SqlParameter("@relSup", relSup) { SqlDbType = SqlDbType.Int };
            SqlParameter param6 = new SqlParameter("@disciplina", disciplina) { SqlDbType = SqlDbType.Int };
            SqlParameter param7 = new SqlParameter("@desempEquipo", desempEquipo) { SqlDbType = SqlDbType.Int };
            SqlParameter param8 = new SqlParameter("@id_persona", id_persona) { SqlDbType = SqlDbType.Int };
            SqlParameter param9 = new SqlParameter("@id_area", id_area) { SqlDbType = SqlDbType.Int };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2, param3, param4, param5, 
                param6, param7, param8, param9 };

            EjecutarConsultas("insertar_evaluacion_desempenio_sp", listaParametros.ToArray(), true);
        }
        public bool ConsultarEvaluacionRepetida(string anio, string mes, int id_persona)
        {
            SqlParameter param1 = new SqlParameter("@anio", anio) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param2 = new SqlParameter("@mes", mes) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param3 = new SqlParameter("@id_persona", id_persona) { SqlDbType = SqlDbType.Int };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2, param3 };
            DataTable resultadoEvaluacionRepetida = EjecutarConsultas("consultar_evaluacion_repetida_sp", listaParametros.ToArray());

            return resultadoEvaluacionRepetida.Rows.Count != 0;
        }

        public DataTable ConsultarEvaluacion(string anio, int id_persona)
        {
            SqlParameter param1 = new SqlParameter("@anio", anio) { SqlDbType = SqlDbType.NVarChar };
            SqlParameter param2 = new SqlParameter("@id_persona", id_persona) { SqlDbType = SqlDbType.Int };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2 };
            DataTable resultadoEvaluacion = EjecutarConsultas("consultar_evaluacion_sp", listaParametros.ToArray());

            return resultadoEvaluacion;
        }

        public DataTable ConsultarEvaluacionSoloPersona(int id_persona)
        {
            SqlParameter param1 = new SqlParameter("@id_persona", id_persona) { SqlDbType = SqlDbType.Int };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            DataTable resultadoEvaluacionPersona = EjecutarConsultas("consultar_evaluacion_persona_sp", listaParametros.ToArray());

            return resultadoEvaluacionPersona;
        }
    }
}

