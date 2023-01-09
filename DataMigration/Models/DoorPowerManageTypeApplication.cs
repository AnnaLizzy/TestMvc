using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class DoorPowerManageTypeApplication
    {
        public int DoorPowerManageTypeId { get; set; }
        public int? JurisdictionTypeId { get; set; }
        public int? DoorPowerManageId { get; set; }
        public string? Meno { get; set; }

        public virtual DoorPowerManageApplication? DoorPowerManage { get; set; }
    }
}
