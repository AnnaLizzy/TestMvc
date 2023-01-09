using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ChemistryFormAuthority
    {
        public int Id { get; set; }
        public string AuthorityId { get; set; } = null!;
        public int? DeparmentSnid { get; set; }
        public string? EmployeesId { get; set; }
        public string? Email { get; set; }
        public string? EmployeesNameV { get; set; }
        public string? EmployeesNameT { get; set; }
        public int? Isdeleted { get; set; }
        public int? AreaId { get; set; }
        public string? PositionName { get; set; }
        public int? IsImposition { get; set; }
        public int? PosOrder { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
