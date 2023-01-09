using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ScrapCarIn
    {
        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public string? CreateEmpId { get; set; }
        public string? CreateName { get; set; }
        public string? CreateDepartment { get; set; }
        public string? CreaatePhoneNum { get; set; }
        public string? CreateEmail { get; set; }
        public DateTime? StartTimeValid { get; set; }
        public DateTime? EndTimeValid { get; set; }
        public int? AreaId { get; set; }
        public string? DetailLocation { get; set; }
        public string? CardNumber { get; set; }
        public string? CarNumber { get; set; }
        public string? DriverName { get; set; }
        public string? DriverId { get; set; }
        public string? Notes { get; set; }
        public int? Weights { get; set; }
        public int? WeightsOld { get; set; }
        public string? CardChange { get; set; }
        public string? CarImage01 { get; set; }
        public string? WeightsImage01 { get; set; }
        public DateTime? DatetimeUse { get; set; }
        public DateTime? DatetimeUpdate { get; set; }
        public int? Status { get; set; }
        public string? PartPass { get; set; }
        public int? Bgid { get; set; }
        public string? PartParaCode { get; set; }
        public int? HasRejected { get; set; }
        public int? DayType { get; set; }
        public int? ScrapCarContructorId { get; set; }
    }
}
