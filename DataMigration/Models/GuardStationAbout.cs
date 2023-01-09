using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class GuardStationAbout
    {
        public int GuardStationAboutId { get; set; }
        public int GuardServerReportTwoId { get; set; }
        public string? Area { get; set; }
        public string? Region { get; set; }
        public string? Building { get; set; }
        public string? Floor { get; set; }
        public string? Azimuth { get; set; }
        public string? Place { get; set; }
        public string? StationType { get; set; }
        public string? Other { get; set; }
        public string? ClassType { get; set; }
        public int? PersonNum { get; set; }
        public bool? Isdeleted { get; set; }
        public string? StationLeavel { get; set; }
        public string? StationName { get; set; }
        public string? CompanyName { get; set; }
        public DateTime? ArriveTime { get; set; }
        public int? ArriveNum { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? OldId { get; set; }
        public int? Status { get; set; }
        public int? FirstId { get; set; }
        public bool? IsStationDelete { get; set; }
        public string? StationCode { get; set; }
        public string? StationMeno { get; set; }
        public string? PostAdminSelect { get; set; }
        public int? PostAdminId { get; set; }
    }
}
