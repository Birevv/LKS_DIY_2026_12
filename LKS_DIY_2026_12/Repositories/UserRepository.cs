using Dapper;
using LKS_DIY_2026_12.Helpers;
using LKS_DIY_2026_12.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKS_DIY_2026_12.Repositories
{
    public class UserRepository : BaseRepository<users>
    {
        // Login Logic
        public users Login (string email, string password)
        {
            try
            {
                using (IDbConnection db = Koneksi.GetConn())
                {
                    string query = @"SELECT * FROM users WHERE email = @email AND password = @password";
                    return db.QueryFirstOrDefault<users>(query, new { Email = email, Password = password });
                }
            }
            catch (SqlException sqlEx)
            {
                throw new Exception("Terjadi Kesalahan pada database: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Terjadi Kesalahan " + ex.Message);
            }
        }
    }
}
