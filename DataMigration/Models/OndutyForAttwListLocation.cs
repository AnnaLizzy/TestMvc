using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class OndutyForAttwListLocation
    {
        public int Id { get; set; }
        public int? Type { get; set; }
        public string LocationId { get; set; } = null!;
        public string? LocationAbrevationName { get; set; }
        public string? LocationDetailName { get; set; }
        public int? AreaId { get; set; }
        public int? X { get; set; }
        public int? Y { get; set; }
        public int? Isdeleted { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
    }
}
