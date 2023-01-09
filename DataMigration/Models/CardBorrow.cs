using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class CardBorrow
    {
        public int CardBorrowId { get; set; }
        public string? CardId { get; set; }
        public int? Type { get; set; }
        public string? Status { get; set; }
    }
}
