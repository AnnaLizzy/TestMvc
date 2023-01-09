using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class DriverVehicleMatch
    {
        public int DriverVehicleMatchId { get; set; }
        public string VehicleDriverMatchGuid { get; set; } = null!;
        public int? DriverId { get; set; }
        public int? VehiclePermitId { get; set; }
        public DateTime? MatchDate { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string? DeleteMeno { get; set; }
    }
}
