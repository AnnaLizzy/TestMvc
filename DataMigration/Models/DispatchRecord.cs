using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class DispatchRecord
    {
        public int DispatchRecordsId { get; set; }
        public int? SpareCarId { get; set; }
        public DateTime? LogDate { get; set; }
        public DateTime? OutTime { get; set; }
        public DateTime? BackTime { get; set; }
        public int? OutMileage { get; set; }
        public int? BackMileage { get; set; }
        public string? UsePeople { get; set; }
        public string? Destination { get; set; }
        public string? UseReason { get; set; }
        public string? Dispatcher { get; set; }
        public string? Meno { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual SpareCar? SpareCar { get; set; }
    }
}
