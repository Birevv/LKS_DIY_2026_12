using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib;

namespace LKS_DIY_2026_12.Models
{
    [Table ("produk")]
    public class produk
    {
        [Key]
        public int id { get; set; }
        public string kode_barang { get; set; }
        public string nama_barang { get; set; }
        public DateTime expired_date { get; set; }
        public int jumlah_barang { get; set; }
        public string satuan { get; set; }
        public int harga_satuan { get; set; }
    }
}
