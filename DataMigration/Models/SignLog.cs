using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class SignLog
    {
        public int SignLogId { get; set; }
        public int? FormstatusId { get; set; }
        public DateTime? SignDae { get; set; }
        public string? SignResult { get; set; }
        public string? Meno { get; set; }
        public int? RollbackId { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
