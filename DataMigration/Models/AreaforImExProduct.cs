using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class AreaforImExProduct
    {
        public int? AreaId { get; set; }
        public string? AreaName { get; set; }
        public string? AreaNameT { get; set; }
        public string? ShortName { get; set; }
        public bool? Isdeleted { get; set; }
    }
}
