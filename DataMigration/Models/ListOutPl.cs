using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ListOutPl
    {
        public int Id { get; set; }
        public string? EmpNo { get; set; }
        public DateTime? TimeOut { get; set; }
        public string? Ip { get; set; }
        public string? Mac { get; set; }
        public int? Weight { get; set; }
        public string? CarNumber { get; set; }
    }
}
