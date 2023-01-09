using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class VisitGovernmentAdvanced
    {
        public int VisitGovernmentAdvancedId { get; set; }
        public string? ApplicationUnit { get; set; }
        public DateTime? ApplicationTime { get; set; }
        public DateTime? VisitTime { get; set; }
        public string? VisitUnit { get; set; }
        public DateTime? MeetingTime { get; set; }
        public string? DiscussMatters { get; set; }
        public string? VisitAim { get; set; }
        public string? Problem { get; set; }
        public string? SalutatoryPlace { get; set; }
        public string? SalutatoryContent { get; set; }
        public string? Number { get; set; }
        public int? Status { get; set; }
        public bool? Isdeleted { get; set; }
        public string? Applicationleavel { get; set; }
        public int BackstageStatus { get; set; }
        public string? ReceiverNo { get; set; }
        public int? VipCardId { get; set; }
        public string? Filepath { get; set; }
    }
}
