using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class VisitCredentialsProc
    {
        public int VisitProcId { get; set; }
        public int? StatusId { get; set; }
        public int? ApplicationId { get; set; }
        public string? Act { get; set; }
        public DateTime? WorkDate { get; set; }
        public string? Meno { get; set; }
    }
}
