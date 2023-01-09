using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class VisitantCertificate
    {
        public int VisitantCertificateId { get; set; }
        public int? CompanyId { get; set; }
        public int? CardId { get; set; }
        public string? VisitingUnits { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? Bgid { get; set; }
        public string? ReceptionDept { get; set; }
        public string? ReceptionPeople { get; set; }
        public string? ReceptionExt { get; set; }
        public string? ReceptionPhone { get; set; }
        public string? EmployeeNo { get; set; }
        public bool? IsDeleted { get; set; }
        public string? Signoff { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? Status { get; set; }
        public string? File { get; set; }

        public virtual Card? Card { get; set; }
        public virtual Company? Company { get; set; }
    }
}
