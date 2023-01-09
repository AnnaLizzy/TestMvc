using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class SecuretyTable
    {
        public int SecuretyId { get; set; }
        public int? FormType { get; set; }
        public int? Id { get; set; }
        public string? EmployeeNo { get; set; }
        public string? EmployeeName { get; set; }
        public DateTime? TimeIn { get; set; }
        public string? Memo { get; set; }
    }
}
