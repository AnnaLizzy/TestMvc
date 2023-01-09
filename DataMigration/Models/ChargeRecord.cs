using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ChargeRecord
    {
        public int ChargeId { get; set; }
        public string? SenderUnit { get; set; }
        public string? SenderPeople { get; set; }
        public string? Receipts { get; set; }
        public int? Amount { get; set; }
        public DateTime? SenderTime { get; set; }
        public int? Type { get; set; }
        public int? Id { get; set; }
        public string? Meno { get; set; }
        public int AdminId { get; set; }
        public int IsCompensation { get; set; }
        public int Compensation { get; set; }
        public string Bill { get; set; } = null!;
        public string BillNumber { get; set; } = null!;
        public int BillAmountTotal { get; set; }
        public int? CardId { get; set; }
        public string? DamageCard { get; set; }
    }
}
