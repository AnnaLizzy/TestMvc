using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class DoorPowerManageArea
    {
        public int? DoorPowerManageId { get; set; }
        public int? AreaRegionId { get; set; }

        public virtual DoorPowerManage? DoorPowerManage { get; set; }
    }
}
