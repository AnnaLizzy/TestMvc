using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class VisitArrangement
    {
        public int VisitArrangementsId { get; set; }
        public int VisitNotCustId { get; set; }
        public string? AccessUnit { get; set; }
        public string? AccessContent { get; set; }
        public DateTime? AccessTime { get; set; }
        public string? AccessMeno { get; set; }
        public int? AreaId { get; set; }
        public string? Area { get; set; }
    }
}
