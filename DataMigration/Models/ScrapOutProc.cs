using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ScrapOutProc
    {
        public int ProcId { get; set; }
        public int? StatusId { get; set; }
        public int? Idpl { get; set; }
        public int? Act { get; set; }
        public string? Memo { get; set; }
        public DateTime? WorkDate { get; set; }
        public int? FormId { get; set; }
        public string? RuleName { get; set; }
        public string? Ip { get; set; }
    }
}
