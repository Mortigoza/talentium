﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun
{
    public class Persona 

    {
        public string apellidos { get; set; }
        public string nombres { get; set; }
        public int id_tipo_doc { get; set; }
        public string nro_doc { get; set; }
        public string cuit_cuil { get; set; }
        public string calle { get; set; }
        public int nro { get; set; }
        public string dpto { get; set; }
        public string piso { get; set; }
        public int id_localidad { get; set; }
        public int id_puesto { get; set; }
        public  int id_area { get; set; }
        public string email { get; set; }
        public int id_nacionalidad { get; set; }
        public int id_genero { get; set; } 
        public DateTime fecha_nacimiento { get; set; }
        public int id_estado_civil { get; set; } 
        public int hijos { get; set; }
        public int id_convenio { get; set; }

        public byte[] foto_perfil  { get; set; }
        
        public string telefono { get; set; }
        public int id_tipo { get; set; }
        public string telefono_alternativo { get; set; }
        public int id_tipo_alternativo { get; set; }
        public string contacto   { get; set; }


   

        //informacion academica
        public int id_nivel1{ get; set; }
        public int id_nivel2 { get; set; }
        public int id_nivel3 { get; set; }

        public string institucion1 { get; set; }
        public string institucion2 { get; set; }
        public string institucion3 { get; set; }
        public string carrera1 { get; set; }
        public string carrera2 { get; set; }
        public string carrera3 { get; set; }
        public int  año_ingreso1 { get; set; }
        public int año_ingreso2 { get; set; }
        public int año_ingreso3 { get; set; }
        public int año_egreso1 { get; set; }
        public int año_egreso2 { get; set; }
        public int año_egreso3 { get; set; }
        public string titulo1 { get; set; }
        public string titulo2 { get; set; }
        public string titulo3 { get; set; }
        public int id_progreso1 { get; set; }
        public int id_progreso2 { get; set; }
        public int id_progreso3 { get; set; }


        //informacion laboral
        public string puesto1 { get; set; }
        public string puesto2 { get; set; }
        public string puesto3 { get; set; }
        public string puesto4 { get; set; }
        public string empresa1 { get; set; }
        public string empresa2{ get; set; }
        public string empresa3 { get; set; }
        public string empresa4 { get; set; }
        public int fecha_ingreso1 { get; set; }
        public int fecha_ingreso2 { get; set; }
        public int fecha_ingreso3 { get; set; }
        public int fecha_ingreso4 { get; set; }
        public int fecha_egreso1 { get; set; }
        public int fecha_egreso2 { get; set; }
        public int fecha_egreso3 { get; set; }
        public int fecha_egreso4 { get; set; }
        public int personal_a_cargo1{ get; set; }
        public int personal_a_cargo2 { get; set; }
        public int personal_a_cargo3 { get; set; }
        public int personal_a_cargo4 { get; set; }



    }
}
