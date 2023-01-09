using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class VisitCredential
    {
        public int ApplicationId { get; set; }
        public string? ApplicationName { get; set; }
        public string? ApplicationType { get; set; }
        public string? UnitVisit { get; set; }
        public int? Bgid { get; set; }
        public string? Bu { get; set; }
        public string? Dept { get; set; }
        public DateTime? ApplicationDate { get; set; }
        public string? StartTime { get; set; }
        public string? EndTime { get; set; }
        public string? ReceptionDept { get; set; }
        public string? ReceptionNo { get; set; }
        public string? ReceptionPeople { get; set; }
        public string? ReceptionExt { get; set; }
        public string? GuideNo { get; set; }
        public string? GuidePeople { get; set; }
        public string? GuideExt { get; set; }
        public string? ReasonVisit { get; set; }
        public int? AreaRegionId { get; set; }
        public string? Build { get; set; }
        public string? Floor { get; set; }
        public string? Office { get; set; }
        public int? Status { get; set; }
        public string? SignMemo { get; set; }
        public string? EmployeeNo { get; set; }
        public string? GuideNo1 { get; set; }
        public string? GuidePeople1 { get; set; }
        public string? GuideExt1 { get; set; }
        public string? CardNumber { get; set; }
        public string? Notes { get; set; }
        public string? Filelist { get; set; }
        public string? Number { get; set; }
    }
}
