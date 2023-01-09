using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class CarVipStatus
    {
        public int StatusId { get; set; }
        public int? Id { get; set; }
        public string? EmployeeNo { get; set; }
        public string? Name { get; set; }
        public string? Meno { get; set; }
        public DateTime? Worktime { get; set; }
        public double? Leavel { get; set; }
        public string? Notes { get; set; }
        public int? Status { get; set; }
    }
}
