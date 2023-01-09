using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class VipCard
    {
        public int VipCardId { get; set; }
        public string? CardNumber { get; set; }
        public string? SerialNumber { get; set; }
        public int? Type { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
