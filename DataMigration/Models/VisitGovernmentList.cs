using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class VisitGovernmentList
    {
        public int VisitGlistId { get; set; }
        public int? VisitGovernmentId { get; set; }
        public string? Name { get; set; }
        public bool? Sex { get; set; }
        public string? Position { get; set; }
        public string? VisitNumber { get; set; }
        public DateTime? RemandTime { get; set; }
        public int? ReturnId { get; set; }
        public DateTime? ReturnTime { get; set; }
        public int? ReceiverId { get; set; }
        public DateTime? ReceiverTime { get; set; }
        public string? ReceiverNo { get; set; }
        public string? ReturnReason { get; set; }
    }
}
