using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class AreaPowerManagerType
    {
        public int? Id { get; set; }
        public int? JurisdisctionTypeId { get; set; }
        public string? Memo { get; set; }
    }
}
