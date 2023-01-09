using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ViewDoorPowerManageBguser
    {
        public int PowerAdminId { get; set; }
        public int? PowerListId { get; set; }
        public string? PowerName { get; set; }
        public string PowerNum { get; set; } = null!;
        public int AdminId { get; set; }
        public string? Name { get; set; }
        public string? EmployeeNo { get; set; }
        public string? Notes { get; set; }
        public int Bgid { get; set; }
        public string? Bgname { get; set; }
        public int? BgsetupItemId { get; set; }
        public string? RoleName { get; set; }
    }
}
