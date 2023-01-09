using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ScrapContructorInListDriver
    {
        public int Id { get; set; }
        public int? ScrapContructorId { get; set; }
        public string? CarNumber { get; set; }
        public string? DriverName { get; set; }
        public string? DriverId { get; set; }
        public string? CardNumber { get; set; }
    }
}
