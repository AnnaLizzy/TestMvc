using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ParkProfileChart
    {
        public int ParkProfileId { get; set; }
        public string? ParkProfileName { get; set; }
        public string? ParkProfileArea { get; set; }
        public int? ParkProfileData { get; set; }
        public DateTime? ParkProfileTime { get; set; }
        public int? ParkprofileStandby { get; set; }
        public DateTime? ParkprofileCreateTime { get; set; }
    }
}
