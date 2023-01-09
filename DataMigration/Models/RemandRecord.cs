using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class RemandRecord
    {
        public int RemandId { get; set; }
        public int? CardId { get; set; }
        public string? Dept { get; set; }
        public string? Phone { get; set; }
        public string? Reasons { get; set; }
        public DateTime? RemandTime { get; set; }
        public int AdminId { get; set; }
        public int? QuitApplyId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
