using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class Location
    {
        public int Id { get; set; }
        public string LocationId { get; set; } = null!;
        public string? LocationName { get; set; }
        public string? LocationDetail { get; set; }
        public int? AreaId { get; set; }
    }
}
