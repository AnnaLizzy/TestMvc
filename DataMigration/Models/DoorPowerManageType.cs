using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class DoorPowerManageType
    {
        public int DoorPowerManageTypeId { get; set; }
        public int? JurisdictionTypeId { get; set; }
        public int? DoorPowerManageId { get; set; }
        public string? Meno { get; set; }

        public virtual DoorPowerManage? DoorPowerManage { get; set; }
    }
}
