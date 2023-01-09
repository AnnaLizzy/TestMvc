using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class DoorPowerManageAreaApplication
    {
        public int? DoorPowerManageId { get; set; }
        public int? AreaRegionId { get; set; }

        public virtual DoorPowerManageApplication? DoorPowerManage { get; set; }
    }
}
