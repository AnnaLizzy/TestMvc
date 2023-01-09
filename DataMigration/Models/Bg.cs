using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class Bg
    {
        public Bg()
        {
            SupplementaryInfos = new HashSet<SupplementaryInfo>();
        }

        public int Bgid { get; set; }
        public string? Bgname { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsAll { get; set; }

        public virtual ICollection<SupplementaryInfo> SupplementaryInfos { get; set; }
    }
}
