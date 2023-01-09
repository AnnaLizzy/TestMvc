using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class VehiclePersonnel
    {
        public int VehiclePid { get; set; }
        public int? VehiclePermitId { get; set; }
        public int? Id { get; set; }
        public int? Type { get; set; }
        public DateTime? MatchTime { get; set; }
        public DateTime? RemoveTime { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual VehiclePermit? VehiclePermit { get; set; }
    }
}
