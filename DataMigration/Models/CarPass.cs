using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class CarPass
    {
        public int Idve { get; set; }
        public int? Id { get; set; }
        public string? CardArea { get; set; }
        public int? CompanyId { get; set; }
        public int? CarType { get; set; }
        public string? NameVn { get; set; }
        public string? NameCn { get; set; }
        public string? Idpeople { get; set; }
        public string? Idlicer { get; set; }
        public int? Type { get; set; }
        public string? CarNumber { get; set; }
        public string? CarColor { get; set; }
        public int? Weight { get; set; }
        public string? ImageCar { get; set; }
        public string? FileAddendum { get; set; }
        public int? Status { get; set; }
        public int? IsJob { get; set; }
        public DateTime? TimeApplication { get; set; }
        public DateTime? InureStartDate { get; set; }
        public DateTime? InureEndDate { get; set; }
        public int? CardId { get; set; }
        public int? NoExecl { get; set; }
        public string? MobileNumber { get; set; }
        public int? WeightReal { get; set; }
        public string? CarTypeOther { get; set; }
        public string? CapBac { get; set; }
        public string? PosisionCar { get; set; }
    }
}
