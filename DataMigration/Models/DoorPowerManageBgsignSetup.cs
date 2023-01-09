using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class DoorPowerManageBgsignSetup
    {
        public DoorPowerManageBgsignSetup()
        {
            DoorPowerManageBgsignSetupItems = new HashSet<DoorPowerManageBgsignSetupItem>();
        }

        public int BgsignSetupId { get; set; }
        public int? Bgid { get; set; }
        public int? ApplicationId { get; set; }
        public int? Status { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? IsUse { get; set; }
        public int? FirstSignUserId { get; set; }
        public DateTime? FirstSignDate { get; set; }
        public int? FirstStatus { get; set; }
        public string? FirstSignMeno { get; set; }

        public virtual ICollection<DoorPowerManageBgsignSetupItem> DoorPowerManageBgsignSetupItems { get; set; }
    }
}
