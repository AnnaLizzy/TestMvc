using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ToPrint
    {
        public int ToPrintId { get; set; }
        public int? TypeId { get; set; }
        public int? Id { get; set; }
        public int? Status { get; set; }
        public string? SignAction { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? SignDate { get; set; }
        public string? ApplyMeno { get; set; }
        public string? SignMeno { get; set; }
    }
}
