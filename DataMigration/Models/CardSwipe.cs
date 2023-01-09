using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class CardSwipe
    {
        public int Id { get; set; }
        public string? EmpNo { get; set; }
        public string? EmpName { get; set; }
        public string? AreaId { get; set; }
        public DateTime? TimeSwipe { get; set; }
        public string? Notes { get; set; }
        public string? Images { get; set; }
        public int? Type { get; set; }
        public DateTime? DateSwipe { get; set; }
        public string? Latitude { get; set; }
        public string? Longtitude { get; set; }
    }
}
