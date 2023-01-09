using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class Link
    {
        public int LinkId { get; set; }
        public string? LinkName { get; set; }
        public string? Url { get; set; }
        public double? Arrangement { get; set; }
        public DateTime? CreatTime { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
