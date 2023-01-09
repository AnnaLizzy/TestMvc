using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ApplicationDoor
    {
        public ApplicationDoor()
        {
            DoorPowerManageApplications = new HashSet<DoorPowerManageApplication>();
        }

        public int ApplicationId { get; set; }
        public string? EmployeeNo { get; set; }
        public DateTime? ApplicationTime { get; set; }
        public int? Status { get; set; }
        public string? Notes { get; set; }
        public string? File { get; set; }
        public string? BgledName { get; set; }
        public string? BgledNo { get; set; }
        public string? Bgpost { get; set; }

        public virtual ICollection<DoorPowerManageApplication> DoorPowerManageApplications { get; set; }
    }
}
