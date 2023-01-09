using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ScrapOutStatus
    {
        public int StatusId { get; set; }
        public int? Idpl { get; set; }
        public string? EmpNo { get; set; }
        public string? EmpName { get; set; }
        public string? Notes { get; set; }
        public string? ParaCode { get; set; }
        public int? Status { get; set; }
        public int? Leavel { get; set; }
        public string? Memo { get; set; }
        public DateTime? WorkDate { get; set; }
        public int? FormId { get; set; }
        public int? Sort { get; set; }
        public string? Ip { get; set; }
        public string? RuleName { get; set; }
    }
}
