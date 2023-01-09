using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class OndutySignOfAttwListEmpNo
    {
        public int Id { get; set; }
        public string? EmpNo { get; set; }
        public string? EmpName { get; set; }
        public int? Type { get; set; }
        public string? Notes { get; set; }
        public DateTime? TimeUpdate { get; set; }
        public int? Isdeleted { get; set; }
    }
}
