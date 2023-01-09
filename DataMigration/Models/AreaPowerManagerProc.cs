using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class AreaPowerManagerProc
    {
        public int ProcId { get; set; }
        public int? StatusId { get; set; }
        public int? Id { get; set; }
        public int? Act { get; set; }
        public string? Memo { get; set; }
        public DateTime? WordTime { get; set; }
    }
}
