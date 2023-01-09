using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class VwCarInfo
    {
        public string? CarBrand { get; set; }
        public string? CarColor { get; set; }
        public string? EmpName { get; set; }
        public string? CardType { get; set; }
        public int Controlstatus { get; set; }
        public string? CardNo { get; set; }
        public string? EmpTel { get; set; }
        public byte[]? EmpImage { get; set; }
        public string? CarNumber { get; set; }
        public int? Cardtype1 { get; set; }
    }
}
