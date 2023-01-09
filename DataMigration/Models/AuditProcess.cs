using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class AuditProcess
    {
        public int AuditId { get; set; }
        public string? AuditPeople { get; set; }
        public string? AuditResult { get; set; }
        public DateTime? AuditTime { get; set; }
        public string? AuditMeno { get; set; }
        public int? Id { get; set; }
        public int? FormId { get; set; }
        public string? Employee { get; set; }
        public double? Leavel { get; set; }
    }
}
