using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class MerCheProc
    {
        public int ProcId { get; set; }
        public int? Id { get; set; }
        public int? StatusId { get; set; }
        public DateTime? WorkDate { get; set; }
        public int? Act { get; set; }
        public string? Memo { get; set; }
    }
}
