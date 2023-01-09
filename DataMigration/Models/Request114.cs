using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class Request114
    {
        public int Id { get; set; }
        public int? Type { get; set; }
        public string? EmpNoApp { get; set; }
        public string? EmpNameApp { get; set; }
        public string? UnitApp { get; set; }
        public string? ExTel { get; set; }
        public string? Mobile { get; set; }
        public string? NotesApp { get; set; }
        public string? Posision { get; set; }
        public string? BuCode { get; set; }
        public DateTime? ApplicationTime { get; set; }
        public int? AreaId { get; set; }
        public int? Bgid { get; set; }
        public string? ContentRequest { get; set; }
        public int? Status { get; set; }
    }
}
