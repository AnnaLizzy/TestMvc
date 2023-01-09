using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ViewVipCardApp
    {
        public int? Id { get; set; }
        public string? VisitNumber { get; set; }
        public DateTime? VisitStartTime { get; set; }
        public DateTime? VisitEndTime { get; set; }
        public int Type { get; set; }
    }
}
