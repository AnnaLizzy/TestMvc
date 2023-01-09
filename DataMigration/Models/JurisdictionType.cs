using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class JurisdictionType
    {
        public int JurisdictionTypeId { get; set; }
        public string? JurisdictionType1 { get; set; }
        public bool? IsDeleted { get; set; }
        public string? Meno { get; set; }
        public string? Arrangement { get; set; }
        public bool? IsBegin { get; set; }
    }
}
