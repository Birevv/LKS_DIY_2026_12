using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace LKS_DIY_2026_12.Models
{
    [Table("users")]
    public class users
    {
        public int id { get; set; }
        public enum tipe_user { get; set; }
        public string nama { get; set; }
        public string alamat { get; set;}
        public string email { get; set; }
        public string telepon { get; set; }
        public string password { get; set; }
    }
}
