﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AccesoDatos
{
    public class CD_Bakup : CD_Conexion
    {
        public string Path { get; set; }
        public void HacerBakup()
        {
            string fecha = DateTime.Now.ToFileTime().ToString();
            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();
                    string backupQuery = $@"BACKUP DATABASE Talentium TO DISK= N'{Path}Talentium {fecha}.bak'";
                    SqlCommand command = new SqlCommand(backupQuery, connection);
                    command.ExecuteNonQuery();
                    Console.WriteLine("¡Respaldo realizado con éxito!"); // Bitacora
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al realizar el respaldo: " + ex.Message); //Bitacora
            }
        }
        public void CargarBakup(string filePath)
        {
            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();
                    string restoreQuery = $"USE master RESTORE DATABASE Talentium FROM DISK= N'{filePath}' WITH REPLACE";
                    SqlCommand command = new SqlCommand(restoreQuery, connection);
                    command.ExecuteNonQuery();
                    Console.WriteLine("¡Restauración realizada con éxito!"); // Bitacora
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al restaurar la base de datos: " + ex.Message); //Bitacora
            }
        }
    }
}
