using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ReceptionProgramGovernment
    {
        public int ReceptionId { get; set; }
        public DateTime? ReceptionTime { get; set; }
        public string? ReceptionPlace { get; set; }
        public string? ReceptionPosition { get; set; }
        public string? ReceptionManagePosition { get; set; }
        public int? Type { get; set; }
        public int VisitGlistId { get; set; }
    }
}
