using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class CustCardRecord
    {
        public string? Fullname { get; set; }
        public string? Applyname { get; set; }
        public string? Type { get; set; }
        public string? Cardno { get; set; }
        public string Ecardno { get; set; } = null!;
        public string? Areaname { get; set; }
        public string? Machinename { get; set; }
        public DateTime Datatime { get; set; }
        public string? Cardstatus { get; set; }
        public string? Reason { get; set; }
    }
}
