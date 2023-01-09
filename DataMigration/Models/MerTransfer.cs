using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class MerTransfer
    {
        public int Id { get; set; }
        public int? Area { get; set; }
        public string? Unit { get; set; }
        public DateTime? Applicationtime { get; set; }
        public string? UserTime { get; set; }
        public string? EmployeeNo { get; set; }
        public string? EmployeeName { get; set; }
        public string? CarNumber { get; set; }
        public string? CarType { get; set; }
        public string? NameTool { get; set; }
        public string? EmployeeNoApp { get; set; }
        public string? EmployeeNameApp { get; set; }
        public string? ExtTel { get; set; }
        public string? Notes { get; set; }
        public int? Status { get; set; }
    }
}
