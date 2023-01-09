using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class WeeklyReport
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime? TimeUpload { get; set; }
        public string? FileReport { get; set; }
    }
}
