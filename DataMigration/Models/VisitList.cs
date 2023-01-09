using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class VisitList
    {
        public int VisitId { get; set; }
        public string? VisitName { get; set; }
        public string? PeopleId { get; set; }
        public string? PhoneNumber { get; set; }
        public int? ApplicationId { get; set; }
        public string? NumberCar { get; set; }
        public string? CardNumer { get; set; }
        public DateTime? TimeIn { get; set; }
        public DateTime? TimeOut { get; set; }
        public string? EmpNo { get; set; }
        public string? Prc72 { get; set; }
        public string? PassPostId { get; set; }
        public string? LeciId { get; set; }
        public int? CountVisit { get; set; }
        public string? Supplie { get; set; }
        public string? ReasonSupp { get; set; }
        public string? FileSupplie { get; set; }
        public string? ImageVisit { get; set; }
        public int? Status { get; set; }
        public int? AreaId { get; set; }
    }
}
