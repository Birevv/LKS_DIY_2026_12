using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace LKS_DIY_2026_12.Models
{
    [Table("detail_transaksi")]
    public class detail_transaksi
    {
        public int id { get; set; } 
        public int transaksi_id { get; set; }   
        public int produk_id { get; set;  }
        public int jumlah_produk { get; set; }
        public double sub_total { get; set; }
    }
}
