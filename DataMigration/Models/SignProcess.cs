using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class SignProcess
    {
        public int SignProcessId { get; set; }
        public string? Name { get; set; }
        public string? EmployeeNo { get; set; }
        public DateTime? SignTime { get; set; }
        public string? SignAct { get; set; }
        public string? SignMeno { get; set; }
        public int? Id { get; set; }
        public int TypeId { get; set; }
        public bool IsUnderWriteFlow { get; set; }
        public bool IsDeleted { get; set; }
        public string RoleName { get; set; } = null!;
    }
}
