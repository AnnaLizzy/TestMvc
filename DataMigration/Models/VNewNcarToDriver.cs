using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class VNewNcarToDriver
    {
        public string? Usercardno { get; set; }
        public string? Usercardid { get; set; }
        public string? Carcardno { get; set; }
        public string? Carcardid { get; set; }
        public string? Drivername { get; set; }
        public string? Driveridno { get; set; }
        public string? Carlicense { get; set; }
        public int Flag { get; set; }
        public byte[]? Fp1 { get; set; }
        public byte[]? Fp2 { get; set; }
        public byte[]? Fp3 { get; set; }
        public int? Fp4 { get; set; }
    }
}
