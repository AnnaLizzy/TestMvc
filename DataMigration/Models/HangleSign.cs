using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class HangleSign
    {
        public int Id { get; set; }
        public string? EmpNo { get; set; }
        public string? EmpNameCn { get; set; }
        public string? EmpNameVn { get; set; }
        public string? Notes { get; set; }
        public int? IsDeleted { get; set; }
        public string? AreaId { get; set; }
        public string? Mobile { get; set; }
        public string? Ext { get; set; }
    }
}
