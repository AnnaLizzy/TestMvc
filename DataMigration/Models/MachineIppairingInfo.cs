using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class MachineIppairingInfo
    {
        public string? MachineName { get; set; }
        public string? Ip { get; set; }
        public int? AreaId { get; set; }
        public string? AreaName { get; set; }
        public bool IsDeleted { get; set; }
    }
}
