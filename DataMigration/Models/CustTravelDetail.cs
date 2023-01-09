using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class CustTravelDetail
    {
        public int CustTravelDetailId { get; set; }
        public int? CustTravelId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string? TravelAim { get; set; }

        public virtual CustTravel? CustTravel { get; set; }
    }
}
