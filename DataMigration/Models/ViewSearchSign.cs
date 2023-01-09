using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ViewSearchSign
    {
        public string Typename { get; set; } = null!;
        public int TypeId { get; set; }
        public int Madon { get; set; }
        public string? EmployeeNo { get; set; }
        public string? EmployeeName { get; set; }
        public DateTime? TimeApp { get; set; }
        public string? EmpNoSign { get; set; }
        public string? EmpNameSign { get; set; }
        public string? Ip { get; set; }
        public DateTime? TimeSign { get; set; }
    }
}
