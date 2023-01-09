using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class UnderWriteNoClosed
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
        public int? CertificatesControlStatus { get; set; }
        public string? Name { get; set; }
        public int CardId { get; set; }
        public int AreaId { get; set; }
        public string AreaName { get; set; } = null!;
        public DateTime? InureStartDate { get; set; }
        public DateTime? InureEndDate { get; set; }
        public string? CarNumber { get; set; }
    }
}
