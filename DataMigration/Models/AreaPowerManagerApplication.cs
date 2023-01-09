using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class AreaPowerManagerApplication
    {
        public int ApplicationId { get; set; }
        public string? EmpNo { get; set; }
        public string? EmpName { get; set; }
        public string? Notes { get; set; }
        public int? Status { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? IsDeleted { get; set; }
        public int? Bgid { get; set; }
        public string? Tel { get; set; }
    }
}
