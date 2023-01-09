using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class VipCardNum
    {
        public int VipCardNumId { get; set; }
        public int VipCardId { get; set; }
        public string? StartNum { get; set; }
        public string? EndNum { get; set; }
        public int? Num { get; set; }
        public bool IsDeleted { get; set; }

        public virtual VipCardReceive VipCard { get; set; } = null!;
    }
}
