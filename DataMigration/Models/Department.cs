using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class Department
    {
        public int DepartmentId { get; set; }
        public string? DepartmentName { get; set; }
        public string? Type { get; set; }
        public string? Information { get; set; }
    }
}
