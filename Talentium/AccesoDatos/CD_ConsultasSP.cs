using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public abstract class CD_ConsultasSP : Conexion
    {
        public DataTable EjecutarConsultas(string NombreSP, SqlParameter[] sqlParameters, bool Directa = false)
        {
            DataTable DT = new DataTable();
            try
            {
                using (SqlConnection CNN = GetConexion())
                {
                    CNN.Open();
                    using (SqlCommand comando = new SqlCommand(NombreSP, CNN))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddRange(sqlParameters);
                        if (!Directa)
                        {
                            DT.Load(comando.ExecuteReader());
                        }
                        else
                        {
                            comando.ExecuteNonQuery();
                        }
                    }
                }
                return DT;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar procedimiento almacenado o Conexion a la Base de Datos. \n \n" + ex.Message);
            }
            finally
            {

            }
        }
    }
}
