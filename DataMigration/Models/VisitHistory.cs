using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class VisitHistory
    {
        public int VisitHistoryId { get; set; }
        public int? VisitGovernmentId { get; set; }
        public string? VisitInformation { get; set; }
        public string? UnderstandDegree { get; set; }
    }
}
