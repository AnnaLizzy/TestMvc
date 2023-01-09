using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class VipOutCall
    {
        public int CallId { get; set; }
        public int? FormId { get; set; }
        public int? TypeId { get; set; }
        public DateTime? CallTime { get; set; }
    }
}
