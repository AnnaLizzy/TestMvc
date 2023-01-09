using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ApexsqlLogString
    {
        public int ColType { get; set; }
        public string ColName { get; set; } = null!;
        public string? ServerName { get; set; }
    }
}
