using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class PowerAdmin
    {
        public int PowerAdminId { get; set; }
        public int? AdminId { get; set; }
        public int? PowerListId { get; set; }
    }
}
