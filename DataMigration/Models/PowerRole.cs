using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class PowerRole
    {
        public int PowerRoleId { get; set; }
        public int? AdminRoleId { get; set; }
        public int? PowerListId { get; set; }
    }
}
