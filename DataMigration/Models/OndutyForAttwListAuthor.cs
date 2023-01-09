using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class OndutyForAttwListAuthor
    {
        public int Id { get; set; }
        public string? EmpNo { get; set; }
        public string? EmpName { get; set; }
        public string? Notes { get; set; }
        public string? ParaCode { get; set; }
        public DateTime? DateCreate { get; set; }
        public int? IsDeleted { get; set; }
        public DateTime? DeleteTime { get; set; }
        public int? AreaId { get; set; }
        public int? Sort { get; set; }
    }
}
