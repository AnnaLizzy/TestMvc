using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class VipCardReceive
    {
        public VipCardReceive()
        {
            VipCardNums = new HashSet<VipCardNum>();
        }

        public int VipCardId { get; set; }
        public string? Bg { get; set; }
        public string? ReceiveCards { get; set; }
        public DateTime? ReceiveTime { get; set; }
        public string? Extention { get; set; }
        public string? Tel { get; set; }
        public string? Notes { get; set; }
        public bool IsDeleted { get; set; }
        public int? CardNum { get; set; }

        public virtual ICollection<VipCardNum> VipCardNums { get; set; }
    }
}
