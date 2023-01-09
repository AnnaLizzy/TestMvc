using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class TroubleType
    {
        public int Id { get; set; }
        public string? TroubleNameVn { get; set; }
        public string? TroubleNameCn { get; set; }
        public int? IsDeleted { get; set; }
    }
}
