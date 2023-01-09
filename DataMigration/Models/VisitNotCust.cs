using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class VisitNotCust
    {
        public int VisitNotCustId { get; set; }
        public string? ApplicationUnit { get; set; }
        public DateTime? ApplicationTime { get; set; }
        public DateTime? VisitTime { get; set; }
        public string? VisitUnits { get; set; }
        public string? VisitLeavel { get; set; }
        public int VisitNatureId { get; set; }
        public string? WorkItem { get; set; }
        public string? WorkResult { get; set; }
        public bool? IsDeleted { get; set; }
        public int? Status { get; set; }
        public int BackstageStatus { get; set; }
        public string? ReceiverNo { get; set; }
        public int? VipCardId { get; set; }
        public string? Number { get; set; }
        public string? Filepath { get; set; }
        public string? PosisionCar { get; set; }
    }
}
