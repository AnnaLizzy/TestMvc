using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class GoingOut
    {
        public int Id { get; set; }
        public DateTime? TimeApplication { get; set; }
        public string? EmpNo { get; set; }
        public string? EmpName { get; set; }
        public string? Bu { get; set; }
        public string? Destination { get; set; }
        public DateTime? TimeOut { get; set; }
        public DateTime? TimeInPlan { get; set; }
        public DateTime? TimeInReal { get; set; }
        public int? Type { get; set; }
        public int? Status { get; set; }
        public string? EmpNoApp { get; set; }
        public string? EmpNameApp { get; set; }
        public string? NotesApp { get; set; }
        public int? AreaId { get; set; }
        public int? Bgid { get; set; }
        public int? AreaRegionId { get; set; }
        public string? PhoneApp { get; set; }
        public string? EmpPhone { get; set; }
    }
}
