using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ProcMer
    {
        public int ProcId { get; set; }
        public int? StatusId { get; set; }
        public int? Id { get; set; }
        public string? Memo { get; set; }
        public string? Act { get; set; }
    }
}
