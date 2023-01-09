using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ViewOldZccard
    {
        public string Cardname { get; set; } = null!;
        public string? Idno { get; set; }
    }
}
