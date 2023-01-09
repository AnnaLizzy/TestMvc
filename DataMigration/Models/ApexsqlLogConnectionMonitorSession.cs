using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ApexsqlLogConnectionMonitorSession
    {
        public int SessionId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? StopTime { get; set; }
        public string? ServerName { get; set; }
    }
}
