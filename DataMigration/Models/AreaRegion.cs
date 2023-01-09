using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class AreaRegion
    {
        public int AreaRegionId { get; set; }
        public int? AreaId { get; set; }
        public long? RegionId { get; set; }
    }
}
