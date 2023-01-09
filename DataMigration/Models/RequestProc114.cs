using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class RequestProc114
    {
        public int ProcId { get; set; }
        public int? StatusId { get; set; }
        public int? Id { get; set; }
        public string? EmpNo { get; set; }
        public string? EmpName { get; set; }
        public string? ParaCode { get; set; }
        public string? Notes { get; set; }
        public int? Sort { get; set; }
        public int? Order { get; set; }
        public int? Status { get; set; }
        public DateTime? WorkTime { get; set; }
        public string? Memo { get; set; }
        public string? Ip { get; set; }
    }
}
