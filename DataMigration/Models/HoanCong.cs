using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class HoanCong
    {
        public int Id { get; set; }
        public int? FormId { get; set; }
        public string? EmpNo { get; set; }
        public string? EmpName { get; set; }
        public string? Notes { get; set; }
        public int? Status { get; set; }
        public DateTime? WorkDate { get; set; }
        public string? Para { get; set; }
        public string? Memo { get; set; }
    }
}
