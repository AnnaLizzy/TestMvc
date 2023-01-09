using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class VisitCard
    {
        public int VisitorCardId { get; set; }
        public string? CardNum { get; set; }
        public string? EcardNum { get; set; }
        public int? CardStatus { get; set; }
        public int? IsDelete { get; set; }
        public DateTime? ReceiveTime { get; set; }
        public DateTime? ReturnTime { get; set; }
        public DateTime? Deleteddate { get; set; }
        public string? Deletedseason { get; set; }
    }
}
