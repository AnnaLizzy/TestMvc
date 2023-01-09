using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ScrapCar
    {
        public int Id { get; set; }
        public DateTime? CreateTime { get; set; }
        public string? CreateEmpId { get; set; }
        public string? CreateName { get; set; }
        public int? BgId { get; set; }
        public string? CreatePhoneNum { get; set; }
        public DateTime? StartTimeValid { get; set; }
        public DateTime? EndTimeValid { get; set; }
        public int? AreaId { get; set; }
        public string? LocationDetail { get; set; }
        public string? CardNumber { get; set; }
        public string? CarNumber { get; set; }
        public string? DriverName { get; set; }
        public string? DriverId { get; set; }
        public string? Notes { get; set; }
        public int? CarWeightsOld { get; set; }
        public int? CarWeight { get; set; }
        public string? CardChange { get; set; }
        public DateTime? DateTimeIn { get; set; }
    }
}
