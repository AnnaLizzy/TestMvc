using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class GuiBinManage
    {
        public int FormType { get; set; }
        public int CustListId { get; set; }
        public int? VisitCustId { get; set; }
        public string? Name { get; set; }
        public bool? Sex { get; set; }
        public string? VisitNumber { get; set; }
        public int? ReceiverId { get; set; }
        public DateTime? ReceiverTime { get; set; }
        public int? ReturnId { get; set; }
        public DateTime? ReturnTime { get; set; }
        public DateTime? RemandTime { get; set; }
        public string? ApplicationUnit { get; set; }
        public DateTime? ApplicationTime { get; set; }
        public string? VisitUnits { get; set; }
        public int? Status { get; set; }
        public int? BackstageStatus { get; set; }
        public string? ReceiverNo { get; set; }
        public int? VipCardId { get; set; }
        public string? CardNum { get; set; }
        public string? EcardNum { get; set; }
        public int? CardStatus { get; set; }
        public string? Number { get; set; }
    }
}
