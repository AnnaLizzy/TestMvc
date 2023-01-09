using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class HandleResult
    {
        public int Id { get; set; }
        public int? Idtrouble { get; set; }
        public string? Memo { get; set; }
        public string? ContentResult { get; set; }
        public int? Active { get; set; }
        public string? TimeHandle { get; set; }
    }
}
