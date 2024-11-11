using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VienaStore.C_Presentacion;


namespace VienaStore.C_Datos
{
    internal class DataAccesBackUp
    {
        
            public void BackUpDatabase(string consulta)
            {
                try
                {                
                    DataAccess.DatabaseConnection.GetConnection();
                    SqlCommand cmd = new SqlCommand(consulta, DataAccess.DatabaseConnection.GetConnection());
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al realizar el respaldo de la base de datos.", ex);
            }
            finally { DataAccess.DatabaseConnection.GetConnection().Close(); }
            
            }        

    }
}
