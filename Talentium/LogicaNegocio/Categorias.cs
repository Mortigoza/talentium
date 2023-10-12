﻿using AccesoDatos;
using Comun;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Categorias
    {
        CD_AccesoBD _CDAcceso = new CD_AccesoBD();

        public DataTable ObtenerCategoria()
        {
            return _CDAcceso.ObtenerCategorias();
        }


        public void InsertarCategoria (CategoriaDto categorias)
        {
            _CDAcceso.InsertarCategorias (categorias);
        }

        public void EliminarCategoria (int id_categoria)
        {
         _CDAcceso.EliminarCategorias (id_categoria);
        }

        public void ModificarCategoria (CategoriaDto categoria, int id)
        {
            _CDAcceso.ModificarCategoria(categoria,id);
        }
    }
}