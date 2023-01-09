using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class SecurityProcess
    {
        public int Idsol { get; set; }
        public int? Ider { get; set; }
        public string? SolutionName { get; set; }
        public string? Purpose { get; set; }
        public string? Forfeit { get; set; }
    }
}
