using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ViewOldClcard
    {
        public string Cardname { get; set; } = null!;
        public string? Idno { get; set; }
        public string? Carlicense { get; set; }
    }
}
