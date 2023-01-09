using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class RecovertRecord
    {
        public int RecovertId { get; set; }
        public int? InvalidId { get; set; }
        public string? Reasons { get; set; }
        public DateTime? RecovertTime { get; set; }
        public int? AdminId { get; set; }

        public virtual InvalidRecord? Invalid { get; set; }
    }
}
