using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class DepartmentAuditPerson
    {
        public int DepartmentAuditId { get; set; }
        public string? EmployeeNo { get; set; }
        public string? Name { get; set; }
        public int? Bgid { get; set; }
        public string? Notes { get; set; }
        public bool? Isdeleted { get; set; }
        public DateTime? DeleteTime { get; set; }
    }
}
