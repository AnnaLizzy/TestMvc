using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class AreaPowerManagerStatus
    {
        public int StatusId { get; set; }
        public int? Id { get; set; }
        public string? EmpNo { get; set; }
        public string? EmpName { get; set; }
        public string? Notes { get; set; }
        public int? Status { get; set; }
        public int? Leavel { get; set; }
        public int? Order { get; set; }
        public DateTime? WordDate { get; set; }
        public string? ParameterCode { get; set; }
        public string? Memo { get; set; }
    }
}
