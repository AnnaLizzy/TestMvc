using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class SpareCar
    {
        public SpareCar()
        {
            DispatchRecords = new HashSet<DispatchRecord>();
            OilRecords = new HashSet<OilRecord>();
            SpareCarReports = new HashSet<SpareCarReport>();
        }

        public int SpareCarId { get; set; }
        public string? CarNumber { get; set; }
        public string? DriverName { get; set; }
        public string? Tel { get; set; }
        public bool? IsDeleted { get; set; }
        public int AreaId { get; set; }

        public virtual ICollection<DispatchRecord> DispatchRecords { get; set; }
        public virtual ICollection<OilRecord> OilRecords { get; set; }
        public virtual ICollection<SpareCarReport> SpareCarReports { get; set; }
    }
}
