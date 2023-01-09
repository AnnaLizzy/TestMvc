using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ViewCredential
    {
        public string? CertifiCateName { get; set; }
        public int? TypeId { get; set; }
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int? Status { get; set; }
        public string? WorkType { get; set; }
        public string? EmployeeNo { get; set; }
        public string? EmployeeName { get; set; }
        public DateTime? CreateTime { get; set; }
        public string? CredentialsNumber { get; set; }
        public int ControlStatus { get; set; }
        public string? Name { get; set; }
        public int CardId { get; set; }
        public int? AreaId { get; set; }
        public DateTime? InureStartDate { get; set; }
        public DateTime? InureEndDate { get; set; }
        public string? CarNumber { get; set; }
        public string Bill { get; set; } = null!;
    }
}
