using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class DoorPowerManageApplication
    {
        public DoorPowerManageApplication()
        {
            DoorPowerManageTypeApplications = new HashSet<DoorPowerManageTypeApplication>();
        }

        public int DoorPowerManageId { get; set; }
        public int? ApplicationId { get; set; }
        public int? Bgid { get; set; }
        public string? EmployeeName { get; set; }
        public string? EmployeeNo { get; set; }
        public string? Bu { get; set; }
        public string? Dept { get; set; }
        public DateTime? CreateTime { get; set; }
        public string? Position { get; set; }
        public string? Notes { get; set; }
        public string? File { get; set; }
        public string? Picture { get; set; }
        public string? EnglishPicture { get; set; }
        public int? Status { get; set; }
        public DateTime? EndTime { get; set; }
        public string BackMeno { get; set; } = null!;
        public bool? IsFind { get; set; }
        public string? Tel { get; set; }

        public virtual ApplicationDoor? Application { get; set; }
        public virtual ICollection<DoorPowerManageTypeApplication> DoorPowerManageTypeApplications { get; set; }
    }
}
