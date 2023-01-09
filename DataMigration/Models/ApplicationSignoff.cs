using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ApplicationSignoff
    {
        public int ApplicationSignoffId { get; set; }
        public string? Name { get; set; }
        public string? ApplicationEmployeeNo { get; set; }
        public string? EmployeeNo { get; set; }
        public bool ApplicationPass { get; set; }
        public DateTime? ApplicationDate { get; set; }
        public int? Type { get; set; }
        public bool IsDeleted { get; set; }
    }
}
