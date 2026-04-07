using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using LKS_DIY_2026_12.Helpers;


namespace LKS_DIY_2026_12.Repositories
{
    public class BaseRepository<T> where T : class
    {

        // SHOW PRODUCT
        public IEnumerable<T> GetAll()
        {
            using (SqlConnection db = Koneksi.GetConn())
            {
                return db.GetAll<T>();
            }
        }
                

        public T GetById(int id)
        {
            using (SqlConnection db = Koneksi.GetConn()) 
            {
                return db.Get<T>(id);
            }
        }

        public long Insert(T entity) 
        {
            using (SqlConnection db = Koneksi.GetConn())
            {
                return db.Insert<T>(entity);
            }
        }

        public bool Update(T entity)
        {
            using (SqlConnection db = Koneksi.GetConn())
            {
               return db.Update<T>(entity);
            }
        }

        public bool DeleteById(int id)
        {
            using (SqlConnection db = Koneksi.GetConn())
            {
                var entity = db.Get<T>(id);
                if (entity != null)
                {
                    return db.Delete(entity);
                }
                return false;
            }
        }

    }
}
