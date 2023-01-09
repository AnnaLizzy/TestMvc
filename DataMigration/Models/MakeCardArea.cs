using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class MakeCardArea
    {
        public int MakeCardAreaId { get; set; }
        public int? AreaId { get; set; }
        public bool IsDeleted { get; set; }
        public string? Meno { get; set; }
    }
}
