using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ImExPortProductProductInfor
    {
        public string ImExPortProductId { get; set; } = null!;
        public string? ProductType { get; set; }
        public int? Amounts { get; set; }
        public string? UnitType { get; set; }
        public string? ComporationId { get; set; }
    }
}
