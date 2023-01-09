using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ViewOldNcomeuserTemp1
    {
        public int Cardno { get; set; }
        public string? Ecardno { get; set; }
        public string? CompanyName { get; set; }
        public string CardNumber { get; set; } = null!;
        public string Name { get; set; } = null!;
    }
}
