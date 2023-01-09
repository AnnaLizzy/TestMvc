using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class GroupType
    {
        public int GroupTypeId { get; set; }
        public string? GroupTypeName { get; set; }
        public bool? IsDeleted { get; set; }
        public int? AreaGroupId { get; set; }
    }
}
