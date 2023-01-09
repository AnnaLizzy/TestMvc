using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ItdevicesListPass
    {
        public int ItdeviceId { get; set; }
        public string? PartPass { get; set; }
        public DateTime? TimePass { get; set; }
        public string? IpPass { get; set; }
        public string? MacPass { get; set; }
        public int? Status { get; set; }
    }
}
