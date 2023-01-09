using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ViewIntent
    {
        public int Typeid { get; set; }
        public int Ida { get; set; }
        public string? UnitApplication { get; set; }
        public string? NameVendor { get; set; }
        public string? NameConstruc { get; set; }
        public DateTime? TimeApplication { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? Area { get; set; }
        public string? Office { get; set; }
        public string? ContenAction { get; set; }
        public int? SendMess { get; set; }
        public string? Posision { get; set; }
        public string? EmpNameApp { get; set; }
        public string? NameAcc { get; set; }
        public DateTime? Timesign { get; set; }
        public int? ProType { get; set; }
        public string? AuditName { get; set; }
    }
}
