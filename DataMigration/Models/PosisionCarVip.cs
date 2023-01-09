using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class PosisionCarVip
    {
        public int Id { get; set; }
        public int? AreaId { get; set; }
        public string? PosisionName { get; set; }
        public int? IsDeleted { get; set; }
    }
}
