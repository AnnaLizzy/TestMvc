using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class WorkNote
    {
        public int Id { get; set; }
        public DateTime? ApplicationTime { get; set; }
        public string? EmpName { get; set; }
        public int? Area { get; set; }
        public int? WorkTime { get; set; }
        public int? Status { get; set; }
        public int? IsDeleted { get; set; }
    }
}
