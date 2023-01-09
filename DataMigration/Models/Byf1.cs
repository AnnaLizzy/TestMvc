using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class Byf1
    {
        public int? Id { get; set; }
        public string? Carlicense { get; set; }
        public int? Num { get; set; }
        public DateTime? Audittime { get; set; }
        public int? Isdeleted { get; set; }
        public string? Cause { get; set; }
    }
}
