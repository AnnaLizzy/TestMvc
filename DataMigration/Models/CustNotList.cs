using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class CustNotList
    {
        public int CustNotListId { get; set; }
        public int VisitNotCustId { get; set; }
        public string? Name { get; set; }
        public bool? Sex { get; set; }
        public string? Position { get; set; }
        public string? Specialty { get; set; }
        public string? DiscussItem { get; set; }
        public string? VisitNumber { get; set; }
        public DateTime? RemandTime { get; set; }
        public int? ReturnId { get; set; }
        public DateTime? ReturnTime { get; set; }
        public int? ReceiverId { get; set; }
        public DateTime? ReceiverTime { get; set; }
        public string? ReceiverNo { get; set; }
        public string? ReturnReason { get; set; }
        public string? VisitImage { get; set; }
    }
}
