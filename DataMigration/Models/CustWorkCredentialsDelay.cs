using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class CustWorkCredentialsDelay
    {
        public int CustWorkCredentialId { get; set; }
        public int? Pid { get; set; }
        public int? Zid { get; set; }
        public int? TypeId { get; set; }
        public string? Phone { get; set; }
        public string? ContactUnitPersonName { get; set; }
        public string? ContactPersonEmployee { get; set; }
        public string? ContactUnitPersonphone { get; set; }
        public string? ContactUnitPersonBg { get; set; }
        public string? ContactUnitExtension { get; set; }
        public string? VeNumber { get; set; }
        public string? NewAddress { get; set; }
        public string? EmergencyContact { get; set; }
        public string? Emergencyphone { get; set; }
        public string? OnWorkFile { get; set; }
        public DateTime? IndureEndate { get; set; }
        public string? CompanyName { get; set; }
        public string? Name { get; set; }
        public int? Sex { get; set; }
        public string? Nation { get; set; }
        public string? WorkCaption { get; set; }
        public string? CredentialsNumber { get; set; }
        public string? SerialNumber { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? Status { get; set; }
        public DateTime? DelDate { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
