using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class SpareCarReport
    {
        public int SpareCarReportId { get; set; }
        public int? SpareCarId { get; set; }
        public DateTime? CreatTime { get; set; }
        public bool? IsDeleted { get; set; }
        public int? Status { get; set; }

        public virtual SpareCar? SpareCar { get; set; }
    }
}
