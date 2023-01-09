using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class DoorReplaceBg
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
        public int? IsDeleted { get; set; }
    }
}
