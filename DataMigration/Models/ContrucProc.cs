using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ContrucProc
    {
        public int ProcId { get; set; }
        public int? Id { get; set; }
        public int? StatusId { get; set; }
        public int? FormId { get; set; }
        public int? Act { get; set; }
        public string? Memo { get; set; }
        public DateTime? WorkTime { get; set; }
        public int? Leavel { get; set; }
        public int? Over { get; set; }
        public string? EmpNo { get; set; }
        public string? EmpName { get; set; }
        public string? Ip { get; set; }
    }
}
