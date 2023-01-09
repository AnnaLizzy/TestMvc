using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class GuiBinReturnSin
    {
        public int CustListId { get; set; }
        public string? Name { get; set; }
        public bool? Sex { get; set; }
        public string? Position { get; set; }
        public DateTime? RemandTime { get; set; }
        public int? VisitCustId { get; set; }
        public string? VisitUnits { get; set; }
        public DateTime? ApplicationTime { get; set; }
        public string? ApplicationUnit { get; set; }
        public int? Status { get; set; }
        public int? BackstageStatus { get; set; }
        public DateTime? VisitStartTime { get; set; }
        public DateTime? VisitEndTime { get; set; }
        public string? ReceptionDept { get; set; }
        public string? ReceptionPeople { get; set; }
        public string? Tel { get; set; }
        public int? Type { get; set; }
        public int? Bgid { get; set; }
        public string? Bgname { get; set; }
        public int? VisitorCardId { get; set; }
        public string? CardNum { get; set; }
        public string? EcardNum { get; set; }
        public int? CardStatus { get; set; }
        public int? IsDelete { get; set; }
        public string? FormName { get; set; }
        public string? SubmitName { get; set; }
        public int? ReturnId { get; set; }
        public DateTime? ReturnTime { get; set; }
        public int? ReceiverId { get; set; }
        public DateTime? ReceiverTime { get; set; }
        public string? Number { get; set; }
        public string? AreaHh { get; set; }
    }
}
