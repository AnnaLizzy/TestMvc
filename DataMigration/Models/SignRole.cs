using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class SignRole
    {
        public int SignRoleId { get; set; }
        public int? FormType { get; set; }
        public string? RoleName { get; set; }
        public string? RoleEmp { get; set; }
        public string? Notes { get; set; }
        public string? EmployeeNo { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
