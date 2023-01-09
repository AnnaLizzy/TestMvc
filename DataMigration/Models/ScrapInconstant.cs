using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ScrapInconstant
    {
        public int Id { get; set; }
        public int? Idpl { get; set; }
        public string? FileInc { get; set; }
        public int? Status { get; set; }
        public DateTime? TimeApplication { get; set; }
        public int? WeightInc { get; set; }
        public string? EmpNoApp { get; set; }
        public string? EmpNameApp { get; set; }
        public string? Memo { get; set; }
    }
}
