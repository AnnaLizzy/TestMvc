using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class DoorPowerManageVer
    {
        public DoorPowerManageVer()
        {
            DoorPowerManageTypeVers = new HashSet<DoorPowerManageTypeVer>();
        }

        public int DoorPowerManageVerId { get; set; }
        public int DoorPowerManageId { get; set; }
        public int? Bgid { get; set; }
        public string? EmployeeName { get; set; }
        public string? EmployeeNo { get; set; }
        public string? Position { get; set; }
        public string? Bu { get; set; }
        public string? Dept { get; set; }
        public DateTime? CreateTime { get; set; }
        public string? Notes { get; set; }
        public DateTime? EndTime { get; set; }
        public bool? IsFind { get; set; }
        public string? File { get; set; }
        public string? DeleteReason { get; set; }
        public DateTime? DeleteDate { get; set; }
        public int? DeleteAdminId { get; set; }
        public string? FilesForDelete { get; set; }
        public string? Picture { get; set; }
        public string? EnglishPicture { get; set; }
        public bool? WhetherJob { get; set; }
        public DateTime? InsertDate { get; set; }
        public int? OldApplicationId { get; set; }

        public virtual ICollection<DoorPowerManageTypeVer> DoorPowerManageTypeVers { get; set; }
    }
}
