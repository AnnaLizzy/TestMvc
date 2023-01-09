using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class Lodging
    {
        public int LodgingId { get; set; }
        public int? VisitCustId { get; set; }
        public int? LodgingNum { get; set; }
        public int? SingleRoom { get; set; }
        public int? DoubleRoom { get; set; }
        public string? Address { get; set; }
    }
}
