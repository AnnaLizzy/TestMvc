using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ViewOndytyApprove
    {
        public string? AreaShortName { get; set; }
        public int? AreaId { get; set; }
        public string? LocationDetailName { get; set; }
        public string LocationId { get; set; } = null!;
        public int? FrameTime { get; set; }
        public DateTime? TimeCheck { get; set; }
        public string? EmpName { get; set; }
        public string? EmpNo { get; set; }
        public string? RuleDetailName { get; set; }
        public int Idsign { get; set; }
        public string? Notes { get; set; }
        public string TrangThai { get; set; } = null!;
    }
}
