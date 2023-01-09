using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ViewSafeCheckResultCheckP
    {
        public int Id { get; set; }
        public int? HistoryCheckId { get; set; }
        public int? RuleId { get; set; }
        public string? NameAbevation { get; set; }
        public bool? Passed { get; set; }
    }
}
