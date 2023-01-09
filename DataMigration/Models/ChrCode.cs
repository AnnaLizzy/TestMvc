using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ChrCode
    {
        public string CodeId { get; set; } = null!;
        public string? CodeDesc { get; set; }
        public string? CodeType { get; set; }
        public string? CodeStatus { get; set; }
        public string? CodeGroup { get; set; }
        public DateTime? Lasteditdt { get; set; }
        public string? Lasteditby { get; set; }
    }
}
