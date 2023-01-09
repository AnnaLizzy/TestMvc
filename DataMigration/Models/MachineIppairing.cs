using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class MachineIppairing
    {
        public int MachineIppairingId { get; set; }
        public string? MachineName { get; set; }
        public string Ip { get; set; } = null!;
        public string Mac { get; set; } = null!;
        public int? AreaId { get; set; }
        public string? AreaName { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
