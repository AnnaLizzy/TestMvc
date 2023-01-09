using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ReceivingRecord
    {
        public int ReceiveId { get; set; }
        public int? CardId { get; set; }
        public string? ReceivePeople { get; set; }
        public string? Phone { get; set; }
        public DateTime? ReceiveTime { get; set; }
        public int? AdminId { get; set; }
        public string? CredentialsNumber { get; set; }
    }
}
