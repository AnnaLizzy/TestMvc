using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class CarTypePass
    {
        public int CarType { get; set; }
        public string? TypeName { get; set; }
        public int? IsDeleted { get; set; }
        public int? Type { get; set; }
    }
}
