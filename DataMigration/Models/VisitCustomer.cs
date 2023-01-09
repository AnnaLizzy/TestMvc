using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class VisitCustomer
    {
        public int VisitCustId { get; set; }
        public int? ProductOppId { get; set; }
        public int? VisitNatureId { get; set; }
        public string? ApplicationUnit { get; set; }
        public DateTime? ApplicationTime { get; set; }
        public string? VisitUnits { get; set; }
        public bool? IsNewCust { get; set; }
        public string? VisitAim { get; set; }
        public string? Traffic { get; set; }
        public int? Status { get; set; }
        public bool? IsDeleted { get; set; }
        public bool ShowAttachment { get; set; }
        public string? AdviceItem { get; set; }
        public int BackstageStatus { get; set; }
        public string? ReceiverNo { get; set; }
        public int? VipCardId { get; set; }
        public string? Number { get; set; }
        public string? Filepath { get; set; }
        public string? PosisionCar { get; set; }
    }
}
