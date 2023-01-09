using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ChemistryAuthorityHistory
    {
        public int Id { get; set; }
        public string AuthorityId { get; set; } = null!;
        public int? DeparmentSnid { get; set; }
        public string? EmployeesId { get; set; }
        public string? Email { get; set; }
        public string? EmployeesNameV { get; set; }
        public string? EmployeesNameT { get; set; }
        public DateTime? ApplicationTime { get; set; }
    }
}
