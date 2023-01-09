using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class Company
    {
        public Company()
        {
            CompanyControlHistories = new HashSet<CompanyControlHistory>();
            TemporaryCredentials = new HashSet<TemporaryCredential>();
            VisitantCertificates = new HashSet<VisitantCertificate>();
        }

        public int CompanyId { get; set; }
        public string CompanyName { get; set; } = null!;
        public string? CompanyPhone { get; set; }
        public string? CompanyAddress { get; set; }
        public string? ContactPhone { get; set; }
        public string? CooperationProjects { get; set; }
        public string? Acknowledgment { get; set; }
        public string? File { get; set; }
        public string? Responsible { get; set; }
        public bool? ControlTag { get; set; }
        public DateTime? CreateTime { get; set; }
        public string? EmployeeNo { get; set; }
        public int Status { get; set; }
        public bool IsDeleted { get; set; }
        public string? NameAbbreviation { get; set; }
        public int? Type { get; set; }
        public string Code { get; set; } = null!;
        public string Reason { get; set; } = null!;
        public string EmployeeName { get; set; } = null!;
        public int ControlStatus { get; set; }
        public DateTime? InureStartDate { get; set; }
        public DateTime? InureEndDate { get; set; }
        public string? ControlMsg { get; set; }
        public string? CompanyCheckingFile { get; set; }
        public int? FlowType { get; set; }

        public virtual ICollection<CompanyControlHistory> CompanyControlHistories { get; set; }
        public virtual ICollection<TemporaryCredential> TemporaryCredentials { get; set; }
        public virtual ICollection<VisitantCertificate> VisitantCertificates { get; set; }
    }
}
