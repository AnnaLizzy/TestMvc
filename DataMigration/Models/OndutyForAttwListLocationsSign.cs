using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class OndutyForAttwListLocationsSign
    {
        public int Id { get; set; }
        public int? OndutyOfAttwDepartId { get; set; }
        public int? FrameTime { get; set; }
        public string? LocationId { get; set; }
        public string? Image { get; set; }
        public int? IsOke { get; set; }
        public string? Notes { get; set; }
        public DateTime? TimeCheck { get; set; }
        public int? Type { get; set; }
        public int? Isdelete { get; set; }
    }
}
