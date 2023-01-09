using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class SecurityReportSigner
    {
        public int SecurityReportSignerId { get; set; }
        public string? SignEmployeeNo { get; set; }
        public string? SignName { get; set; }
        public string? Email { get; set; }
        public string? Meno { get; set; }
    }
}
