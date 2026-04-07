using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib;

namespace LKS_DIY_2026_12.Models
{
    [Table("tbl_log")]

    public class tbl_log
    {
        [Key]
        public int id { get; set; }
        public DateTime waktu { get; set; }
        public string aktivitas { get; set; }
        public int id_user { get; set; }
    }
}
