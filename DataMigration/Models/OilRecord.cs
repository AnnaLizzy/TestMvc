using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class OilRecord
    {
        public int OilRecordsId { get; set; }
        public int? SpareCarId { get; set; }
        public DateTime? FuelDate { get; set; }
        public string? FuelPeople { get; set; }
        public int? BeforeOilMileage { get; set; }
        public int? OilNum { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual SpareCar? SpareCar { get; set; }
    }
}
