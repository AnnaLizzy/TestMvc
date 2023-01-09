using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ScrapCarAuthority
    {
        public int Id { get; set; }
        public string? ScrapAuthorityId { get; set; }
        public int? BgId { get; set; }
        public string? EmpId { get; set; }
        public string? Email { get; set; }
        public string? EmpNameV { get; set; }
        public string? EmpNameT { get; set; }
        public int? AreaId { get; set; }
        public int? Isdeleted { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? Endtime { get; set; }
        public string? EmpNoUpdate { get; set; }
        public string? Notes { get; set; }
        public string? ParaCode { get; set; }
        public string? RuleName { get; set; }
    }
}
