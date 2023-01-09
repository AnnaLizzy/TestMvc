using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ApexsqlLogLogin
    {
        public int Spid { get; set; }
        public DateTime? LoginTime { get; set; }
        public string? LoginName { get; set; }
        public string? ClientHost { get; set; }
        public string? ApplicationName { get; set; }
        public string? ServerName { get; set; }
    }
}
