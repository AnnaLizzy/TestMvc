using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ChemistryForm
    {
        public int Id { get; set; }
        public string? DepartmentRequitision { get; set; }
        public string? MinistrySn { get; set; }
        public string? DepartmentSn { get; set; }
        public int AreaId { get; set; }
        public string? DepartmentBuy { get; set; }
        public string EmployeeBuy { get; set; } = null!;
        public string? PhoneofEmpBuy { get; set; }
        public DateTime? DateOfApplication { get; set; }
        public DateTime? DateOfExpectedStart { get; set; }
        public DateTime? DateOfExpectedEnd { get; set; }
        public string? LocationAndTech { get; set; }
        public string? StoreLocation { get; set; }
        public int? Status { get; set; }
        public int? Category { get; set; }
        public int? Export { get; set; }
        public int? Needtodec { get; set; }
        public string? Applicant { get; set; }
        public string? Email { get; set; }
        public string? FactoryGate { get; set; }
        public int? Type { get; set; }
        public int? IsShow { get; set; }
        public int? Isdeleted { get; set; }
        public int? Bgid { get; set; }
    }
}
