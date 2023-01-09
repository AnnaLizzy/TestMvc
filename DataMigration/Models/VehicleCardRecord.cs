using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class VehicleCardRecord
    {
        public string? CarNumber { get; set; }
        public string? DriverName { get; set; }
        public string? CarBrand { get; set; }
        public string? CarType { get; set; }
        public string? Color { get; set; }
        public string Stime { get; set; } = null!;
        public string? Bak { get; set; }
    }
}
