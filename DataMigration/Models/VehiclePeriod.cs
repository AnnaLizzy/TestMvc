using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class VehiclePeriod
    {
        public int VehiclePeriodId { get; set; }
        public string? VehiclePeriodNo { get; set; }
        public int? VehiclePermitId { get; set; }
        public int? AreaId { get; set; }
        public int? IsBeChecked { get; set; }
        public DateTime? LotNumberDate { get; set; }
        public int? Isdeleted { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
