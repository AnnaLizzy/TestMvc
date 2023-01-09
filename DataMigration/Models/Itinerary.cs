using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class Itinerary
    {
        public int ItineraryId { get; set; }
        public int VisitCustId { get; set; }
        public string? BriefType { get; set; }
        public string? BriefMeno { get; set; }
        public string? BriefAddress { get; set; }
        public string? Person { get; set; }
        public string? Phone { get; set; }
        public string? LtineraryStress { get; set; }
    }
}
