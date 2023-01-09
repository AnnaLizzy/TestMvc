using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class CameraStatus
    {
        public int? Id { get; set; }
        public int? StatusId { get; set; }
        public int? Leavel { get; set; }
        public int? Order { get; set; }
        public string? EmpNo { get; set; }
        public string? EmpName { get; set; }
        public string? Notes { get; set; }
        public int? Status { get; set; }
        public DateTime? WorkDate { get; set; }
    }
}
