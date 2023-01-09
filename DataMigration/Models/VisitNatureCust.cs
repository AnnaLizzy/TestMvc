using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class VisitNatureCust
    {
        public int VisitNatureCustId { get; set; }
        public int? VisitNatureId { get; set; }
        public int? VisitCustId { get; set; }
        public string? Other { get; set; }
    }
}
