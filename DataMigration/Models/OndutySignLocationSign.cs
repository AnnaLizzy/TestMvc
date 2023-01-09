using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class OndutySignLocationSign
    {
        public int Id { get; set; }
        public int? OndutySignId { get; set; }
        public string? EmpNo { get; set; }
        public string? EmpName { get; set; }
        public int? Status { get; set; }
        public string? Notes { get; set; }
        public string? Image { get; set; }
        public string? LocationId { get; set; }
        public DateTime? TimeSign { get; set; }
        public int? Isdeleted { get; set; }
        public string? ReceivedEmpNo { get; set; }
        public DateTime? ReceivedTime { get; set; }
        public int? ReceivedStatus { get; set; }
        public string? DepartMentName { get; set; }
    }
}
