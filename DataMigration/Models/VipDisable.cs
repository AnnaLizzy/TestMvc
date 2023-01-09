using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class VipDisable
    {
        public int VipDisableId { get; set; }
        public string? EmpNo { get; set; }
        public string? EmpName { get; set; }
        public int? IsDelete { get; set; }
        public DateTime? DeleteDate { get; set; }
        public string? DeleteReason { get; set; }
    }
}
