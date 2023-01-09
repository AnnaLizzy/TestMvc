using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class Message
    {
        public int MessageId { get; set; }
        public int? MessageTypeId { get; set; }
        public string? Title { get; set; }
        public string? Cotent { get; set; }
        public double? Arrangement { get; set; }
        public DateTime? CreatTime { get; set; }
        public bool? IsDeleted { get; set; }
        public int? Type { get; set; }
    }
}
