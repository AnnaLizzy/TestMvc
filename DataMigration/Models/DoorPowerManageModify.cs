using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class DoorPowerManageModify
    {
        public int DoorPowerManageModifyId { get; set; }
        public int DoorPowerManageId { get; set; }
        public DateTime ActionDate { get; set; }
        public int ActionAdminId { get; set; }
        public string? ActionMeno { get; set; }
        public string? Files { get; set; }
        public string? Ip { get; set; }
        public string? Mac { get; set; }
    }
}
