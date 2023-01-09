using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class CardChangeHistory
    {
        public int Id { get; set; }
        public string? CardNumber { get; set; }
        public int? CardId { get; set; }
        public int? CardChangeId { get; set; }
        public DateTime? TimeChange { get; set; }
    }
}
