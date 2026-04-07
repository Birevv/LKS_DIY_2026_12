using Dapper;
using Dapper.Contrib.Extensions;
using LKS_DIY_2026_12.Helpers; 
using LKS_DIY_2026_12.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace LKS_DIY_2026_12.Repositories
{
    public class LogRepository
    {
      
        public void TambahLog(tbl_log log)
        {
            try
            {
                using (SqlConnection db = Koneksi.GetConn())
                {
                    db.Insert(log); 
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal menyimpan aktivitas Log: " + ex.Message);
            }
        }

      
        public object GetAllLog()
        {
            try
            {
                using (SqlConnection db = Koneksi.GetConn())
                {
                    string query = @"
                        SELECT 
                            l.id, 
                            u.nama, 
                            l.waktu, 
                            l.aktivitas 
                        FROM tbl_log l
                        INNER JOIN users u ON l.id_user = u.id
                        ORDER BY l.waktu DESC";

                    return db.Query(query);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal mengambil data Log: " + ex.Message);
            }
        }
    }
}