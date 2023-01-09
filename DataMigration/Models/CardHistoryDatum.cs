using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class CardHistoryDatum
    {
        public int CardHistoryDataId { get; set; }
        public string EcardNo { get; set; } = null!;
        public string Ip { get; set; } = null!;
        public string Mac { get; set; } = null!;
        public DateTime DataTime { get; set; }
        public string? CardStatus { get; set; }
        public string? Reason { get; set; }
        public DateTime TransferTime { get; set; }
    }
}
