using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class GuiBinReceive
    {
        public int? VisitCustId { get; set; }
        public string? VisitUnits { get; set; }
        public int? PeopleNum { get; set; }
        public int? Status { get; set; }
        public DateTime? VisitStartTime { get; set; }
        public DateTime? VisitEndTime { get; set; }
        public int? Type { get; set; }
        public int? Id { get; set; }
        public string? Bgname { get; set; }
        public int? BackstageStatus { get; set; }
        public int? VipCardId { get; set; }
        public string? ReceiveCards { get; set; }
        public int? CardNum { get; set; }
        public DateTime? ReceiveTime { get; set; }
        public string? Extention { get; set; }
        public string? Tel { get; set; }
        public string? Notes { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? ApplicationTime { get; set; }
        public string? ApplicationUnit { get; set; }
        public string? ReceptionPeople { get; set; }
        public string? Number { get; set; }
        public string? AreaHh { get; set; }
    }
}
