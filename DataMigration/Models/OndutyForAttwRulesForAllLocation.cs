using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class OndutyForAttwRulesForAllLocation
    {
        public int Id { get; set; }
        public int? Type { get; set; }
        public string? RuleId { get; set; }
        public string? RuleDetailName { get; set; }
        public string? LocationId { get; set; }
        public DateTime? Timeupdate { get; set; }
        public string? Notes { get; set; }
        public string? Isdeleted { get; set; }
    }
}
