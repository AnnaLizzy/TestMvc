using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class WebVerson
    {
        public int WebVersonId { get; set; }
        public string? WebVersonName { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? DeleteTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
