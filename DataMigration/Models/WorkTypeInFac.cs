using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class WorkTypeInFac
    {
        public int WorkTypeId { get; set; }
        public string? WorkTypeNameC { get; set; }
        public string? WorkTypeNameV { get; set; }
        public string? Type { get; set; }
        public string? Meno { get; set; }
        public int? Isdeleted { get; set; }
    }
}
