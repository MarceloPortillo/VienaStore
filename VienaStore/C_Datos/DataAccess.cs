using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VienaStore.C_Negocio;

namespace VienaStore.C_Datos
{
    internal class DataAccess
    {
        public static class DatabaseConnection
        {
            private static string ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=VienaStore;Data Source=MARCELO\\SQLEXPRESS";

            public static SqlConnection GetConnection()
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();
                return conn;
            }
        }
    }
}
