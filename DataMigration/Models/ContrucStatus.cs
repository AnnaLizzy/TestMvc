using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ContrucStatus
    {
        public int StatusId { get; set; }
        public int? Id { get; set; }
        public int? FormId { get; set; }
        public string? EmpNo { get; set; }
        public string? EmpName { get; set; }
        public string? Notes { get; set; }
        public int? Leavel { get; set; }
        public int? Over { get; set; }
        public string? Para { get; set; }
        public DateTime? WorkDate { get; set; }
        public string? Memo { get; set; }
        public int? Status { get; set; }
        public int? Type { get; set; }
        public string? Ip { get; set; }
    }
}
