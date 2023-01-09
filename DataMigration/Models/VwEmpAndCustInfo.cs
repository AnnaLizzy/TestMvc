using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class VwEmpAndCustInfo
    {
        public string? EmpNo { get; set; }
        public string? EmpName { get; set; }
        public string? EmpSex { get; set; }
        public string? Bg { get; set; }
        public string? Bu { get; set; }
        public string? Depart { get; set; }
        public string? Company { get; set; }
        public string? EnterReason { get; set; }
        public string? CarNo { get; set; }
        public string? CardNo { get; set; }
        public int Contrulstatus { get; set; }
        public string? Imagedata { get; set; }
        public string? CardId { get; set; }
        public string Type { get; set; } = null!;
    }
}
