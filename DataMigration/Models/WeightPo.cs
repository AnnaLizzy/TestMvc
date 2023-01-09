using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class WeightPo
    {
        public int Id { get; set; }
        public DateTime? TimeAdd { get; set; }
        public int? WeightIn { get; set; }
        public int? WeightIncotant { get; set; }
    }
}
