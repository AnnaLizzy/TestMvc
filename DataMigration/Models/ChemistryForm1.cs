using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ChemistryForm1
    {
        public int Id { get; set; }
        public string? DepartmentRequitision { get; set; }
        public string? MinistrySn { get; set; }
        public string? DepartmentSn { get; set; }
        public int AreaId { get; set; }
        public string? DepartmentBuy { get; set; }
        public string EmployeeBuy { get; set; } = null!;
        public int? PhoneofEmpBuy { get; set; }
        public DateTime? DateOfApplication { get; set; }
        public DateTime? DateOfExpectedStart { get; set; }
        public DateTime? DateOfExpectedEnd { get; set; }
        public string? LocationAndTech { get; set; }
        public string? StoreLocation { get; set; }
        public int? Status { get; set; }
        public int? Category { get; set; }
        public int? Export { get; set; }
        public int? Needtodec { get; set; }
    }
}
