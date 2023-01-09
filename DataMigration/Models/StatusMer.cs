using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class StatusMer
    {
        public int StatusId { get; set; }
        public int? Id { get; set; }
        public string? EmployeeNo { get; set; }
        public string? EmployeeName { get; set; }
        public string? Notes { get; set; }
        public int? Status { get; set; }
        public string? Memo { get; set; }
    }
}
