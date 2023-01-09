using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class SecurityReport
    {
        public int SecurityReportId { get; set; }
        public int? AreaId { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? IsDeleted { get; set; }
        public int? Status { get; set; }
        public string? SignName { get; set; }
        public string? SignMail { get; set; }
        public DateTime? SignTime { get; set; }
        public string? SignMeno { get; set; }
    }
}
