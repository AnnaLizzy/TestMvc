using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ItDevice
    {
        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? RequirementType { get; set; }
        public int? AreaId { get; set; }
        public string? CreaterEmpId { get; set; }
        public string? CreaterName { get; set; }
        public string? CreaterDepartment { get; set; }
        public string? CreaterSpecialPhone { get; set; }
        public string? CreaterPhoneNum { get; set; }
        public string? CreaterEmail { get; set; }
        public int? ReasonType { get; set; }
        public string? LocationDetail { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string? UseEmpId { get; set; }
        public string? UseName { get; set; }
        public string? UseDepartment { get; set; }
        public string? UseSpecialPhone { get; set; }
        public string? UsePhoneNumber { get; set; }
        public string? UseEmail { get; set; }
        public int? Status { get; set; }
        public DateTime? UseTime { get; set; }
        public string? PartPass { get; set; }
        public string? IpPass { get; set; }
        public int? BgIduse { get; set; }
    }
}
