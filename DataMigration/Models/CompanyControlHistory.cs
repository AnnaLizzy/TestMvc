using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class CompanyControlHistory
    {
        public int CompanyControlHistoryId { get; set; }
        public int? CompanyId { get; set; }
        public bool ControlTag { get; set; }
        public DateTime? OperatTime { get; set; }
        public string? ControlMsg { get; set; }

        public virtual Company? Company { get; set; }
    }
}
