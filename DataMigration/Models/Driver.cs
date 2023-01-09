using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class Driver
    {
        public int DriverId { get; set; }
        public string DriverGuid { get; set; } = null!;
        public string? CredentialNumber { get; set; }
        public string? EmployeeNo { get; set; }
        public string? Name { get; set; }
        public int? PeopleType { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string? Address { get; set; }
        public string? EmployeeCardNo { get; set; }
    }
}
