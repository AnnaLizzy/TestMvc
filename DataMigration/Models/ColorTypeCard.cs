using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ColorTypeCard
    {
        public int Id { get; set; }
        public int? Idcard { get; set; }
        public int? TypeCard { get; set; }
        public int? ColorType { get; set; }
        public DateTime? DateUpdate { get; set; }
        public string? EmpNo { get; set; }
    }
}
