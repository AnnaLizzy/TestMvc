using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class UnderWriteType
    {
        public int UnderWriteTypeId { get; set; }
        public string? UnderWriteTypeName { get; set; }
        public bool IsDeleted { get; set; }
    }
}
