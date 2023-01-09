using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class VwGuiBingCarInfo
    {
        public string? Cardno { get; set; }
        public string? Ecardno { get; set; }
        public string? Company { get; set; }
        public string Cardnumber { get; set; } = null!;
        public string? Name { get; set; }
        public string? CarCode { get; set; }
        public int? CarType { get; set; }
        public string? CarColor { get; set; }
        public string? Tel { get; set; }
        public int? FormId { get; set; }
        public int? ReportId { get; set; }
    }
}
