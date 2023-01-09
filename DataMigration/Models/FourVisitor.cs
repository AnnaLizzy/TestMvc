using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class FourVisitor
    {
        public int CustListId { get; set; }
        public int? VisitCustId { get; set; }
        public string? VisitNumber { get; set; }
        public int? ReceiverId { get; set; }
    }
}
