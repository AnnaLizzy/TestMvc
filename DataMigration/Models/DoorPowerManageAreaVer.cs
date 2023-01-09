using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class DoorPowerManageAreaVer
    {
        public int? DoorPowerManageVerId { get; set; }
        public int? AreaRegionId { get; set; }

        public virtual DoorPowerManageVer? DoorPowerManageVer { get; set; }
    }
}
