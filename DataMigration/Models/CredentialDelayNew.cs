using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class CredentialDelayNew
    {
        public int Id { get; set; }
        public string CardNumber { get; set; } = null!;
        public int? Type { get; set; }
        public int? CompanyId { get; set; }
        public string? ContactPersonId { get; set; }
        public string? ContactDeparmentId { get; set; }
        public int? ContactPhoneNum { get; set; }
        public DateTime? ApplicationTime { get; set; }
        public DateTime? EndTimeNew { get; set; }
        public string? DocforCredentialDelay { get; set; }
        public string? Applicant { get; set; }
        public int? Status { get; set; }
        public string? ContactEmail { get; set; }
        public int? OldNewTable { get; set; }
    }
}
