using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class TypeConfig
    {
        public int TypeConfigId { get; set; }
        public string? TypeConfigName { get; set; }
        public string? Type { get; set; }
        public string? Meno { get; set; }
    }
}
