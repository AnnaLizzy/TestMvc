using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class CarVipProc
    {
        public int ProcId { get; set; }
        public int? Id { get; set; }
        public int? StatusId { get; set; }
        public DateTime? WorkDate { get; set; }
        public string? Act { get; set; }
        public string? Meno { get; set; }
    }
}
