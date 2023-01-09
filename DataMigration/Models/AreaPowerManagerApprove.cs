using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class AreaPowerManagerApprove
    {
        public int Id { get; set; }
        public string EmpNo { get; set; } = null!;
        public string EmpName { get; set; } = null!;
        public string Position { get; set; } = null!;
        public string? ExtTel { get; set; }
        public string Notes { get; set; } = null!;
        public string? AreaId { get; set; }
        public string? AreaName { get; set; }
        public string BuName { get; set; } = null!;
        public string BuCode { get; set; } = null!;
        public DateTime EndTime { get; set; }
        public int? IsDeleted { get; set; }
        public int? Job { get; set; }
        public int? Status { get; set; }
        public int? M01 { get; set; }
        public int? M02 { get; set; }
        public int? M03 { get; set; }
        public int? M04 { get; set; }
        public int? M05 { get; set; }
        public int? M06 { get; set; }
        public int? M07 { get; set; }
        public int? M08 { get; set; }
        public int? M09 { get; set; }
        public int? M02a { get; set; }
        public int? M02b { get; set; }
        public int? M02c { get; set; }
        public int? M02d { get; set; }
        public int? M02e { get; set; }
        public int? M02f { get; set; }
        public int? M02g { get; set; }
        public int? W01 { get; set; }
        public int? W01a { get; set; }
        public int? W01b { get; set; }
        public int? W01c { get; set; }
        public int? W01d { get; set; }
        public int? W02 { get; set; }
        public int? W02a { get; set; }
        public int? W02b { get; set; }
        public int? W02c { get; set; }
        public int? W02d { get; set; }
        public int? W02e { get; set; }
        public int? W03 { get; set; }
        public int? W03a { get; set; }
        public int? W03b { get; set; }
        public int? W04 { get; set; }
        public int? W05 { get; set; }
        public int? W06 { get; set; }
        public int? W07 { get; set; }
        public int? W08 { get; set; }
        public int? W09 { get; set; }
        public int? W10 { get; set; }
        public int? W11 { get; set; }
        public DateTime? CreateTime { get; set; }
        public int Bgid { get; set; }
        public int? ApplicationId { get; set; }
    }
}
