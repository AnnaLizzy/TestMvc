using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class Request114Sign
    {
        public int Id { get; set; }
        public string? EmpNo { get; set; }
        public string? EmpName { get; set; }
        public string? Notes { get; set; }
        public int? Sort { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? Order { get; set; }
    }
}
