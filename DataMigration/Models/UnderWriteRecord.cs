using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class UnderWriteRecord
    {
        public int UnderWriteRecordId { get; set; }
        public int UnderWriteFlowId { get; set; }
        public int TypeId { get; set; }
        public string? Result { get; set; }
        public DateTime? RecordDate { get; set; }
        public string? Meno { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsAvailability { get; set; }
    }
}
