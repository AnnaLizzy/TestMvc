using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class EconConfig
    {
        public int EconConfigId { get; set; }
        public int AdminId { get; set; }
        public int Bgid { get; set; }
        public string? Code { get; set; }
        public bool IsDeleted { get; set; }
    }
}
