using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class AreaDetail
    {
        public int? Id { get; set; }
        public int? AreaRegionId { get; set; }
        public string? DetailAreaName { get; set; }
    }
}
