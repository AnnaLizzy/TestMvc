using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class DboChrEmployee2
    {
        public string EmpNo { get; set; } = null!;
        public string? SiteId { get; set; }
        public DateTime? KeyDate { get; set; }
        public string? EmpName { get; set; }
        public string? Sex { get; set; }
        public string? Cos { get; set; }
        public DateTime? Birthday { get; set; }
        public DateTime? InDate { get; set; }
        public string? ClassNo { get; set; }
        public string? StatusNo { get; set; }
        public string? Married { get; set; }
        public string? JobSituation { get; set; }
        public DateTime? LevDate { get; set; }
        public string? Oldhome { get; set; }
        public string? EmpId { get; set; }
        public DateTime? Lasteditdt { get; set; }
        public string? Address { get; set; }
        public string? Urgtel { get; set; }
        public DateTime? TransferDate { get; set; }
        public string? Photo { get; set; }
        public string? Id { get; set; }
        public string? InitSiteId { get; set; }
        public string? BgCode { get; set; }
    }
}
