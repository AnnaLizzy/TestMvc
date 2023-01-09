using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class DoorPowerManageTypeVer
    {
        public int DoorPowerManageTypeId { get; set; }
        public int? JurisdictionTypeId { get; set; }
        public int? DoorPowerManageVerId { get; set; }
        public string? Meno { get; set; }

        public virtual DoorPowerManageVer? DoorPowerManageVer { get; set; }
    }
}
