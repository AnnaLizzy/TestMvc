using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class Area
    {
        public int AreaId { get; set; }
        public string AreaName { get; set; } = null!;
        public string? AreaMeno { get; set; }
        public string? ShortName { get; set; }
        public bool? IsDeleted { get; set; }
        public int? ListIndex { get; set; }
        public string? FullName { get; set; }
    }
}
