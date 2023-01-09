using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class OndutyListLocation
    {
        public int Id { get; set; }
        public string? LocationId { get; set; }
        public string? LocationAbrevationName { get; set; }
        public string? LocationDetailName { get; set; }
        public int? AreaId { get; set; }
        public int? X { get; set; }
        public int? Y { get; set; }
        public int? Isdeleted { get; set; }
    }
}
