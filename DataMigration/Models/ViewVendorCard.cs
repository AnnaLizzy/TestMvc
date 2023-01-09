using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ViewVendorCard
    {
        public int CardId { get; set; }
        public int TableType { get; set; }
        public string TableName { get; set; } = null!;
        public string? CardNumber { get; set; }
        public int? CardType { get; set; }
        public int? Status { get; set; }
        public string? CompanyName { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? EndTime { get; set; }
        public string? CardArea { get; set; }
        public string? PersonName { get; set; }
        public string? PersonId { get; set; }
        public int? WorkType { get; set; }
        public string? CarNumber { get; set; }
        public int? IsDeleted { get; set; }
    }
}
