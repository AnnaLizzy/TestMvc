using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class VisitGovernment
    {
        public int VisitGovernmentId { get; set; }
        public string? Number { get; set; }
        public string? ApplicationUnit { get; set; }
        public DateTime? ApplicationTime { get; set; }
        public DateTime? VisitTime { get; set; }
        public string? VisitUnits { get; set; }
        public string? VisitAim { get; set; }
        public string? VisitIssues { get; set; }
        public string? SalutatoryPlace { get; set; }
        public string? SalutatoryContent { get; set; }
        public int? Status { get; set; }
        public bool? Isdeleted { get; set; }
        public int BackstageStatus { get; set; }
        public string? ReceiverNo { get; set; }
        public int? VipCardId { get; set; }
        public string? Filepath { get; set; }
    }
}
