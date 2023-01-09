using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class DietAttention
    {
        public int DietAttentionId { get; set; }
        public int? VisitCustId { get; set; }
        public int? VegetarianFoodNum { get; set; }
        public string? Preferences { get; set; }
        public string? Other { get; set; }
        public string? Eat { get; set; }
    }
}
