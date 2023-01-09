using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class DoorPowerManageModifyList
    {
        public int DoorPowerManageModifyId { get; set; }
        public int? DoorPowerManageId { get; set; }
        public int? AreaRegionId { get; set; }
        public int? JurisdictionTypeId { get; set; }
        public string? Meno { get; set; }
        public string ActionType { get; set; } = null!;

        public virtual DoorPowerManageModify DoorPowerManageModify { get; set; } = null!;
    }
}
