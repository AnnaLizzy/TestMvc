using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ViewAreaRegionByCard
    {
        public int? Type { get; set; }
        public int? Id { get; set; }
        public string? AreaId { get; set; }
        public string? AreaName { get; set; }
    }
}
