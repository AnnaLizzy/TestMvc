using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ViewOldNcomeuser
    {
        public string Cardno { get; set; } = null!;
        public string? Ecardno { get; set; }
        public string? CompanyName { get; set; }
        public string CardNumber { get; set; } = null!;
        public string Name { get; set; } = null!;
    }
}
