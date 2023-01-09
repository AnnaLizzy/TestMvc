using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class TemporaryCredential
    {
        public int TemporaryCredentialsId { get; set; }
        public int? CompanyId { get; set; }
        public int? Bgid { get; set; }
        public string? Bu { get; set; }
        public string? Dept { get; set; }
        public DateTime? ApplicationDate { get; set; }
        public string? FactoryDoor { get; set; }
        public string? ApplicationType { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string? Content { get; set; }
        public string? LedPeople { get; set; }
        public string? ReceptionDept { get; set; }
        public string? ReceptionPeople { get; set; }
        public string? ReceptionExt { get; set; }
        public int? UserMemberId { get; set; }
        public bool? IsDeleted { get; set; }
        public string? Signoff { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? Status { get; set; }
        public int? AreaRegionId { get; set; }
        public string? Build { get; set; }
        public string? Floor { get; set; }
        public string? Office { get; set; }

        public virtual Company? Company { get; set; }
    }
}
