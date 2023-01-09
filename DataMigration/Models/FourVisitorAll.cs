using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class FourVisitorAll
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
    }
}
