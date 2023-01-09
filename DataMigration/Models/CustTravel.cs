using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class CustTravel
    {
        public CustTravel()
        {
            CustTravelDetails = new HashSet<CustTravelDetail>();
        }

        public int CustTravelId { get; set; }
        public int? VisitCustId { get; set; }
        public string? StartPlace { get; set; }
        public DateTime? ArrivalTime { get; set; }
        public string? Flight { get; set; }
        public DateTime? LeaveTime { get; set; }
        public string? GoBackFlight { get; set; }

        public virtual ICollection<CustTravelDetail> CustTravelDetails { get; set; }
    }
}
