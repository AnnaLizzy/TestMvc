using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class DoorPowerManage
    {
        public DoorPowerManage()
        {
            DoorPowerManageTypes = new HashSet<DoorPowerManageType>();
        }

        public int DoorPowerManageId { get; set; }
        public int? Bgid { get; set; }
        public string? EmployeeName { get; set; }
        public string? EmployeeNo { get; set; }
        public string? Position { get; set; }
        public string? Bu { get; set; }
        public string? Dept { get; set; }
        public DateTime? CreateTime { get; set; }
        public string? Notes { get; set; }
        public string? Password { get; set; }
        public string? Picture { get; set; }
        public string? EnglishPicture { get; set; }
        public string? Tel { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime RePwdTime { get; set; }
        public bool? IsFind { get; set; }
        public string? File { get; set; }
        public bool? WhetherJob { get; set; }
        public bool IsOverTime { get; set; }
        public DateTime? MailSendDate { get; set; }
        public DateTime? InsertDate { get; set; }
        public int? OldApplicationId { get; set; }

        public virtual ICollection<DoorPowerManageType> DoorPowerManageTypes { get; set; }
    }
}
