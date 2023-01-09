using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class EhsSign
    {
        public int Id { get; set; }
        public string? EmpNo { get; set; }
        public string? EmpName { get; set; }
        public string? EmpNameV { get; set; }
        public string? Notes { get; set; }
        public int? Bgid { get; set; }
        public int? Leave { get; set; }
        public int? Area { get; set; }
        public int? Sort { get; set; }
        public int? IsDeleted { get; set; }
    }
}
