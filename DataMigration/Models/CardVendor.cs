using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class CardVendor
    {
        public int CardId { get; set; }
        public int? Id { get; set; }
        public int? CardType { get; set; }
        public int? Status { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? EndTime { get; set; }
        public string? CompanyName { get; set; }
        public string? CardNumber { get; set; }
        public int? AdminId { get; set; }
        public int? IsDeleted { get; set; }
        public int? WorkType { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? DateChange { get; set; }
        public string? FileBill { get; set; }
        public string? CardArea { get; set; }
    }
}
