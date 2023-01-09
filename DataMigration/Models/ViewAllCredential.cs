using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ViewAllCredential
    {
        public string? CredentialsNumber { get; set; }
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string? Name { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? Type { get; set; }
        public string? EmployeeNo { get; set; }
        public string? EmployeeName { get; set; }
        public int TypeId { get; set; }
        public int? Status { get; set; }
        public bool IsDeleted { get; set; }
        public int CardId { get; set; }
        public string CompanyName { get; set; } = null!;
        public string? NameAbbreviation { get; set; }
    }
}
