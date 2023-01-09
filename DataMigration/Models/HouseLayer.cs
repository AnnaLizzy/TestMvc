using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class HouseLayer
    {
        public int HouseLayerId { get; set; }
        public int? RegionHouseId { get; set; }
        public int? LayerId { get; set; }
    }
}
