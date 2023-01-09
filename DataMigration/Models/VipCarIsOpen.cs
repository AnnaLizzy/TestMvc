using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class VipCarIsOpen
    {
        public string? CarCode { get; set; }
        public int? CarType { get; set; }
        public string FormType { get; set; } = null!;
        public string Reason { get; set; } = null!;
        public int IsOpen { get; set; }
        public string? LastNo { get; set; }
        public int? LastMath { get; set; }
        public string IsLimit { get; set; } = null!;
        public int Longhua { get; set; }
        public int Guanlan { get; set; }
        public int IsMatch { get; set; }
    }
}
