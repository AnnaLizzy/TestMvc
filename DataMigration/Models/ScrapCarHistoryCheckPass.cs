using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ScrapCarHistoryCheckPass
    {
        public int Id { get; set; }
        public string? Idpl { get; set; }
        public string? Type { get; set; }
        public string? PartPass { get; set; }
        public DateTime? Passtime { get; set; }
        public int? Weight { get; set; }
    }
}
