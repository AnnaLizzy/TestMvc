using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class UnderWriteModel
    {
        public int UnderWriteModelId { get; set; }
        public int UnderWriteFlowId { get; set; }
        public string? ModelName { get; set; }
        public string? ModeMeno { get; set; }
        public bool IsDeleted { get; set; }
    }
}
