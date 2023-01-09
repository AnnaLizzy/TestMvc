using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class CustWorkValid
    {
        public int? CustWorkCredentialsId { get; set; }
        public int? CompanyId { get; set; }
        public int? CardId { get; set; }
        public string? Name { get; set; }
        public bool? Sex { get; set; }
        public DateTime? Birthday { get; set; }
        public string? CensusAddress { get; set; }
        public string? NowAddress { get; set; }
        public string? CredentialsNumber { get; set; }
        public string? Phone { get; set; }
        public string? EmergencyContact { get; set; }
        public string? EmergencyContactPhone { get; set; }
        public string? WorkType { get; set; }
        public string? WorkCaption { get; set; }
        public string? ContactUnit { get; set; }
        public int? Type { get; set; }
        public string? EmployeeNo { get; set; }
        public bool IsDeleted { get; set; }
        public string? Signoff { get; set; }
        public string? Signoff2 { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? Status { get; set; }
        public string? File { get; set; }
        public string? EmployeeName { get; set; }
        public int? ControlStatus { get; set; }
        public DateTime? InureStartDate { get; set; }
        public DateTime? InureEndDate { get; set; }
        public string? ContactUnitPerson { get; set; }
        public string? ContactUnitPhone { get; set; }
        public string? ContactUnitExtension { get; set; }
        public int? AreaId { get; set; }
        public string? AreaCard { get; set; }
        public string? NameCn { get; set; }
    }
}
