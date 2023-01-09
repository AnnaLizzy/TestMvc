using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class PllistOutProtectorReset
    {
        public int Id { get; set; }
        public int? Idpl { get; set; }
        public string? Ip { get; set; }
        public DateTime? TimeReset { get; set; }
    }
}
