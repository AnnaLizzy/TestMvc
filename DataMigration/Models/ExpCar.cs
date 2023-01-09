using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ExpCar
    {
        public int ExpCarid { get; set; }
        public string? Carnumber { get; set; }
        public DateTime? TravelStartTime { get; set; }
        public DateTime? TravelEndTime { get; set; }
        public int? Isdeleted { get; set; }
    }
}
