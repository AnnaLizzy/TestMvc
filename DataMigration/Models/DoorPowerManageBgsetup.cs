using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class DoorPowerManageBgsetup
    {
        public int BgsetupId { get; set; }
        public int? Bgid { get; set; }
        public int? CreateUserId { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? DelUserId { get; set; }
        public DateTime? DelDate { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
