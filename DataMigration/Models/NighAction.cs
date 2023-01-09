using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class NighAction
    {
        public int Idnight { get; set; }
        public int? Id { get; set; }
        public string? NameContrucs { get; set; }
        public string? NameVendor { get; set; }
        public string? UnitApplication { get; set; }
        public int? Area { get; set; }
        public string? ContenAction { get; set; }
        public string? Office { get; set; }
        public DateTime? TimeAplication { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string? EmpNoApp { get; set; }
        public string? EmpNameApp { get; set; }
        public string? NotesApp { get; set; }
        public string? ExtTel { get; set; }
        public string? UnitAuditNo { get; set; }
        public string? UnitAuditName { get; set; }
        public string? UnitAuditTc { get; set; }
        public string? UnitAuditTel { get; set; }
        public string? VendorAuditName { get; set; }
        public string? VendorAuditTc { get; set; }
        public string? VendorAuditTel { get; set; }
        public int? Status { get; set; }
        public int? IsDeleted { get; set; }
        public int? Zone { get; set; }
        public string? Normal { get; set; }
        public string? Special { get; set; }
        public string? NameRes { get; set; }
        public string? TelRes { get; set; }
        public int? IsAsse { get; set; }
    }
}
