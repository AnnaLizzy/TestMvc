using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ViewOldNcomeuserTemp
    {
        public string? Cardno { get; set; }
        public string? Ecardno { get; set; }
        public string? Companyname { get; set; }
        public string Cardnumber { get; set; } = null!;
        public string Name { get; set; } = null!;
    }
}
