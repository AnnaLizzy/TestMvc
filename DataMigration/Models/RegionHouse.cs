using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class RegionHouse
    {
        public int RegionHouseId { get; set; }
        public int? AreaRegionId { get; set; }
        public int? BuildingId { get; set; }
    }
}
