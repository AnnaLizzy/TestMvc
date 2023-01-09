using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class Car
    {
        public int CarId { get; set; }
        public int? VisitorsId { get; set; }
        public string? CarNumber { get; set; }
        public string? CarType { get; set; }
        public string? CarColor { get; set; }
        public string? CardNumber { get; set; }
        public DateTime? RemandTime { get; set; }
    }
}
