using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class Ttt
    {
        public long? Id { get; set; }
        public string? EmployeeNo { get; set; }
        public DateTime? CreateTime { get; set; }
        public int DoorPowerManageId { get; set; }
        public int Tag { get; set; }
    }
}
