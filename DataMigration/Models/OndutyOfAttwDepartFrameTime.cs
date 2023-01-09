using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class OndutyOfAttwDepartFrameTime
    {
        public int FrameId { get; set; }
        public int? Type { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public DateTime? DatetimeUpdate { get; set; }
        public string? FrameTimeName { get; set; }
        public int? Isdeleted { get; set; }
    }
}
