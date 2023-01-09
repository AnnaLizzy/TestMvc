using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ShuttleVisitor
    {
        public int ShuttleVisitorsId { get; set; }
        public int? VisitCustId { get; set; }
        public DateTime? ShuttleTime { get; set; }
        public DateTime? ShuttleStartTime { get; set; }
        public DateTime? ShuttleEndTime { get; set; }
        public string? StartJourney { get; set; }
        public string? Destination { get; set; }
        public string? ShuttlePeople { get; set; }
        public int? ShuttleNum { get; set; }
    }
}
