using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKS_DIY_2026_12.Models
{
    [Table("pelanggan")]
    public class pelanggan
    {
        public int id { get; set; }
        public string nama { get; set; }
        public string telepon { get; set; }
    }
}
