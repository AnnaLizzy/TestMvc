using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class Cmc812log
    {
        public int Cmc812logId { get; set; }
        public string? Cmc812logMsg { get; set; }
        public DateTime? Cmc812logCreateTime { get; set; }
        public string? Ip { get; set; }
        public string? Mac { get; set; }
    }
}
