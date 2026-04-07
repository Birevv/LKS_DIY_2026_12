using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKS_DIY_2026_12.Helpers
{
    public static class DbConnection
    {
        private static string connectionString = "Data Source=BIRE;Initial Catalog=DIY_SMART;Integrated Security=True;TrustServerCertificate=True";

        public static SqlConnection GetConn()
        {
            return new SqlConnection(connectionString);
        }

    }
}