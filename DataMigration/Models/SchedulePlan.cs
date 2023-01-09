using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class SchedulePlan
    {
        public int ScheduleId { get; set; }
        public int VisitCustId { get; set; }
        public DateTime? ScheduleTime { get; set; }
        public string? Dept { get; set; }
        public string? VisitLeavel { get; set; }
        public string? ReceptionPeople { get; set; }
        public string? VisitStress { get; set; }
        public string? Preparation { get; set; }
    }
}
