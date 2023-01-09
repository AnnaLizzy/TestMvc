using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class InteruptInfrared
    {
        public int Id { get; set; }
        public string? EmpIdcreate { get; set; }
        public string? SpecialPhone { get; set; }
        public string? ApplicationDepart { get; set; }
        public string? ActionDepartment { get; set; }
        public int? ContructionId { get; set; }
        public string? ActionLocation { get; set; }
        public string? ActionContent { get; set; }
        public string? FromDate { get; set; }
        public string? Todate { get; set; }
        public int? AreaId { get; set; }
        public string? Reason { get; set; }
        public string? ActionType { get; set; }
        public int? InfraredLampOff { get; set; }
        public string? ApplicantEmail { get; set; }
        public string? ApplicantExt { get; set; }
        public int? Isdeleted { get; set; }
        public int? IsDisplay { get; set; }
        public int? Status { get; set; }
        public int? OffCamera { get; set; }
    }
}
