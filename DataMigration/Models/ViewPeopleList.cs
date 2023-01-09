using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ViewPeopleList
    {
        public string? EmpName { get; set; }
        public string? Idno { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? Area { get; set; }
        public int? Status { get; set; }
    }
}
