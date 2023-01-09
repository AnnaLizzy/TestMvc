using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class DoorPowerManageBgsetupItem
    {
        public int BgsetupItemId { get; set; }
        public int? PowerAdminId { get; set; }
        public string? RoleName { get; set; }
        public int? CreateUserId { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? ModifyUserId { get; set; }
        public DateTime? ModifyDate { get; set; }
        public int? DelUserId { get; set; }
        public DateTime? DelDate { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
