using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class VendorCardView
    {
        public string CertifiCateName { get; set; } = null!;
        public string? WorkTypeName { get; set; }
        public int TypeId { get; set; }
        public int Id { get; set; }
        public int? CompanyId { get; set; }
        public int? Status { get; set; }
        public int? CarType { get; set; }
        public string? EmpNo { get; set; }
        public string? EmpName { get; set; }
        public DateTime? TimeApplication { get; set; }
        public string? Idpeople { get; set; }
        public string? NameVn { get; set; }
        public string? NameCn { get; set; }
        public int? CardId { get; set; }
        public string? CardArea { get; set; }
        public DateTime? InureStartDate { get; set; }
        public DateTime? InureEndDate { get; set; }
        public string? CarNumber { get; set; }
        public string? Bill { get; set; }
        public int? WeightCar { get; set; }
        public string? CardNumber { get; set; }
        public int? AreaId { get; set; }
        public string? MobileNumber { get; set; }
        public string? CompanyName { get; set; }
        public string? NameAbbreviation { get; set; }
        public string? ExcTel { get; set; }
        public string? CarColor { get; set; }
        public int? RangeCar { get; set; }
        public string? CarTypeOther { get; set; }
        public string? ItemImage { get; set; }
    }
}
