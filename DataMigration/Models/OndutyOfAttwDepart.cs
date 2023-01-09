using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class OndutyOfAttwDepart
    {
        public int Id { get; set; }
        public int? Type { get; set; }
        public DateTime? DateSing { get; set; }
        public int? Status { get; set; }
        public int? AreaId { get; set; }
        public string? EmpNo { get; set; }
        public string? EmpName { get; set; }
        public int? FrameTime { get; set; }
        public int? Isdeleted { get; set; }
    }
}
