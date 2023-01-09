using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class DoorReplace
    {
        public int Id { get; set; }
        public string? EmpNo { get; set; }
        public string? EmpName { get; set; }
        public string? Notes { get; set; }
        public string? EmpNoReplace { get; set; }
        public string? EmpNameReplace { get; set; }
        public string? NotesReplace { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? Status { get; set; }
        public string? Extel { get; set; }
        public string? Mobi { get; set; }
        public string? ExtelReplace { get; set; }
        public string? MobiReplace { get; set; }
    }
}
