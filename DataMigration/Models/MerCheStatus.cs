using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class MerCheStatus
    {
        public int StatusId { get; set; }
        public int? Id { get; set; }
        public string? EmpNo { get; set; }
        public string? EmpName { get; set; }
        public string? Notes { get; set; }
        public int? Status { get; set; }
        public int? Leavel { get; set; }
        public int? Order { get; set; }
        public DateTime? WordTime { get; set; }
        public string? Para { get; set; }
        public string? Ip { get; set; }
    }
}
