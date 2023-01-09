using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class VisitCredentialsStatus
    {
        public int StatusId { get; set; }
        public int? VisitId { get; set; }
        public string? Name { get; set; }
        public string? Notes { get; set; }
        public int? Status { get; set; }
        public double? Leavel { get; set; }
        public DateTime? WorkTime { get; set; }
        public string? FormMeno { get; set; }
        public string? EmployeeNo { get; set; }
        public int? ApplicationId { get; set; }
        public string? Emp { get; set; }
        public int? Order { get; set; }
        public int? Sort { get; set; }
        public string? Ip { get; set; }
    }
}
