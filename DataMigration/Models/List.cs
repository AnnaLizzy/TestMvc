using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class List
    {
        public int ListId { get; set; }
        public string? ListName { get; set; }
        public string? File { get; set; }
        public double? Arrangement { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
