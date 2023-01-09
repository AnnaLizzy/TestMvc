using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ProductOpportunity
    {
        public int ProductOppId { get; set; }
        public string? ProductOpportunitiesName { get; set; }
        public bool IsDeleted { get; set; }
    }
}
