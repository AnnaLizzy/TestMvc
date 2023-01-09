using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class AppointPerson
    {
        public int AppointId { get; set; }
        public string? ApplicationNo { get; set; }
        public string? AuditNo { get; set; }
        public string? AuditName { get; set; }
        public string? AuditNote { get; set; }
    }
}
