using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class DoorPowerManageBgsignSetupItem
    {
        public int BgsignSetupItemId { get; set; }
        public int? BgsignSetupId { get; set; }
        public int? SignAdminId { get; set; }
        public int? SignOrderId { get; set; }
        public string? SignRole { get; set; }
        public string? SignMeno { get; set; }
        public int? SignStatusId { get; set; }
        public DateTime? SignDate { get; set; }
        public bool? IsSign { get; set; }

        public virtual DoorPowerManageBgsignSetup? BgsignSetup { get; set; }
    }
}
