using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ChrEmpCardinfo
    {
        public string Empno { get; set; } = null!;
        public string? Cardid { get; set; }
        public string? Softno { get; set; }
        public string? Empmemo { get; set; }
    }
}
