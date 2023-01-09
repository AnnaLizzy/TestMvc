using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ScrapInconstantAuthor
    {
        public int Id { get; set; }
        public string? EmpNo { get; set; }
        public string? EmpName { get; set; }
        public string? Notes { get; set; }
        public string? Role { get; set; }
        public int? Isdeleted { get; set; }
        public DateTime? TimeAdd { get; set; }
        public DateTime? TimeDelete { get; set; }
        public int? Leavel { get; set; }
        public int? Sort { get; set; }
        public int? AreaId { get; set; }
        public int? Bgid { get; set; }
        public string? ParaCode { get; set; }
    }
}
