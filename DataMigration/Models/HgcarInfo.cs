using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class HgcarInfo
    {
        public int HgcarId { get; set; }
        public string? CarNumber { get; set; }
        public string? TranCom { get; set; }
        public string? Name { get; set; }
        public string? Idno { get; set; }
        public DateTime? CreateTime { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? DeleteTime { get; set; }
    }
}
