using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class WebVisitRecord
    {
        public int WebVisitRecordId { get; set; }
        public DateTime? VisitDate { get; set; }
        public string Mac { get; set; } = null!;
        public string Ip { get; set; } = null!;
        public bool IsLoding { get; set; }
        public string EmployeeNo { get; set; } = null!;
        public string EmployeeName { get; set; } = null!;
        public bool IsDeleted { get; set; }
        public bool IsBefore { get; set; }
    }
}
