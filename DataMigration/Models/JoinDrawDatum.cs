using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class JoinDrawDatum
    {
        public int? VehiclePermitId { get; set; }
        public int? IsBeChecked { get; set; }
        public string? VehiclePeriodNo { get; set; }
    }
}
