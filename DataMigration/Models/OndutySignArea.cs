using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class OndutySignArea
    {
        public int Id { get; set; }
        public int? AreaId { get; set; }
        public string? AreaName { get; set; }
        public string? AreaShortName { get; set; }
        public int? ListIndex { get; set; }
        public int? Isdeleted { get; set; }
    }
}
