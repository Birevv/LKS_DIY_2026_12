using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKS_DIY_2026_12.Models
{
    [Table("transaksi")]
    public class transaksi
    {
        public int id { get; set; }
        public string no_transaksi { get; set; }
        public DateTime tgl_transakasi { get; set; }
        public string nama_kasir { get; set; }
        public int user_id { get; set; }
        public int pelanggan_id { get; set;  }

    }
}
