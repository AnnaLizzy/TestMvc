using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class DiffTimeMore
    {
        public int? DiffTime { get; set; }
        public int? Type { get; set; }
        public int? Id { get; set; }
        public int? ReceiverId { get; set; }
        public string? Extention { get; set; }
        public string? ReceiveCards { get; set; }
        public string? Notes { get; set; }
        public string? VisitNumber { get; set; }
    }
}
