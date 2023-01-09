using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class MessageType
    {
        public int MessageTypeId { get; set; }
        public string? MessageType1 { get; set; }
        public bool? IsDleted { get; set; }
        public int? Type { get; set; }
    }
}
