using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ImExPortProduct
    {
        public int Id { get; set; }
        public string? ImExPortProductId { get; set; }
        public DateTime? DatetimeUse { get; set; }
        public string? Weights { get; set; }
        public string? CardId { get; set; }
        public int? Status { get; set; }
        public string? PartPass { get; set; }
        public int? Type { get; set; }
        public string? MacId { get; set; }
        public string? Ip { get; set; }
        public string? ComporationId { get; set; }
        public int? AreaId { get; set; }
        public string? Notes { get; set; }
    }
}
