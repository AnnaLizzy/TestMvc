using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class VisitNature
    {
        public int VisitNatureId { get; set; }
        public string? VisitNatureName { get; set; }
        public bool IsDeleted { get; set; }
    }
}
