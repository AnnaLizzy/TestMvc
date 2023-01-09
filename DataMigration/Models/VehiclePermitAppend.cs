using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class VehiclePermitAppend
    {
        public DateTime? InsertDate { get; set; }
        public int? VehiclePermitId { get; set; }
        public int? CompanyId { get; set; }
        public int? CardId { get; set; }
        public string? CredentialsType { get; set; }
        public string? DriverName { get; set; }
        public string? CarBrand { get; set; }
        public string? CarType { get; set; }
        public string? Color { get; set; }
        public string? CarNumber { get; set; }
        public string? CredentialsNumber { get; set; }
        public string? Province { get; set; }
        public string? LicenseNumber { get; set; }
        public string? EmergencyContact { get; set; }
        public string? EmergencyContactPhone { get; set; }
        public string? WorkType { get; set; }
        public string? Caption { get; set; }
        public string? ContactUnit { get; set; }
        public string? EmployeeNo { get; set; }
        public bool IsDeleted { get; set; }
        public string? Signoff { get; set; }
        public string? Signoff2 { get; set; }
        public DateTime? CreateTime { get; set; }
        public int Status { get; set; }
        public string? File { get; set; }
        public int PhotoId { get; set; }
        public string? DriverEmployeeNo { get; set; }
        public string? Ext { get; set; }
        public int Bgid { get; set; }
        public bool IsFind { get; set; }
        public DateTime? ContractEndDate { get; set; }
        public string? EmployeeName { get; set; }
        public int ControlStatus { get; set; }
        public DateTime? InureStartDate { get; set; }
        public DateTime? InureEndDate { get; set; }
        public string? OrtherContact { get; set; }
        public string? ArrangeNo { get; set; }
        public string? ArrangeName { get; set; }
        public string? ArrangeTelephone { get; set; }
        public int? AreaId { get; set; }
    }
}
