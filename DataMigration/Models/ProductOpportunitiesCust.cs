using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ProductOpportunitiesCust
    {
        public int ProductOpportunitiesCustId { get; set; }
        public int? ProductOppId { get; set; }
        public int? VisitCustId { get; set; }
        public string? Other { get; set; }
    }
}
