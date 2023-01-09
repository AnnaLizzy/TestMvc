using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ElectricUse
    {
        public int ElecId { get; set; }
        public int? Id { get; set; }
        public string? UnitApplication { get; set; }
        public string? NameVendor { get; set; }
        public string? NameConstruc { get; set; }
        public DateTime? TimeAplication { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? Area { get; set; }
        public string? Office { get; set; }
        public string? ContentAction { get; set; }
        public string? EmpNoApp { get; set; }
        public string? EmpNameApp { get; set; }
        public string? NotesApp { get; set; }
        public int? Status { get; set; }
        public int? Bf1 { get; set; }
        public int? Bf2 { get; set; }
        public int? Bf3 { get; set; }
        public int? Bf4 { get; set; }
        public int? Bf5 { get; set; }
        public int? Bf6 { get; set; }
        public int? Bf7 { get; set; }
        public int? In1 { get; set; }
        public int? In2 { get; set; }
        public int? In3 { get; set; }
        public int? In4 { get; set; }
        public int? In5 { get; set; }
        public int? In6 { get; set; }
        public int? Af1 { get; set; }
        public int? Af2 { get; set; }
        public string? VendorAudit { get; set; }
        public string? FileVendor { get; set; }
        public string? FacAudit { get; set; }
        public string? FileFac { get; set; }
        public int? Spe1 { get; set; }
        public int? Spe2 { get; set; }
        public int? Spe3 { get; set; }
        public int? Spe4 { get; set; }
        public int? Spe5 { get; set; }
        public string? Defer { get; set; }
        public string? ActionMember { get; set; }
        public string? FileMember { get; set; }
        public string? ExtTel { get; set; }
        public int? Pec { get; set; }
        public string? Atld3 { get; set; }
        public string? FileClother { get; set; }
        public string? FileDevices { get; set; }
        public int? Assent { get; set; }
    }
}
