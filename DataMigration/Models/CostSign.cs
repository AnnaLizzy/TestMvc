using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class CostSign
    {
        public int Id { get; set; }
        public string? EmpNo { get; set; }
        public string? EmpName { get; set; }
        public string? Notes { get; set; }
        public int? Leavel { get; set; }
        public int? Sort { get; set; }
        public int? IsDeleted { get; set; }
        public int? AreaId { get; set; }
        public int? Bgid { get; set; }
    }
}
