using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ChemistryAuthorityChangeEmail
    {
        public int Id { get; set; }
        public string EmployeesId { get; set; } = null!;
        public string? Email1 { get; set; }
        public string? Email2 { get; set; }
        public DateTime? ApplicationTime { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? Status { get; set; }
        public string? EmployeesId2 { get; set; }
        public string? EmployeesName2 { get; set; }
    }
}
