using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class VisitStatus
    {
        public int VisitStatusId { get; set; }
        public int? ApplicationId { get; set; }
        public string? EmployeeNo { get; set; }
        public string? Name { get; set; }
        public string? Notes { get; set; }
        public int? Status { get; set; }
        public double? Leavel { get; set; }
        public DateTime? WorkTime { get; set; }
        public string? VisitMemo { get; set; }
        public bool IsDeleted { get; set; }
    }
}
