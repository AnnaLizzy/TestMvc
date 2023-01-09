using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class DealType
    {
        public int DealTypeId { get; set; }
        public string? DealType1 { get; set; }
        public string? Meno { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
