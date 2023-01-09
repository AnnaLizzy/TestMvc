using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class OtherCarInfo
    {
        public string? Id { get; set; }
        public string? CompanyName { get; set; }
        public string? CarNumber { get; set; }
        public string? CarType { get; set; }
        public string? CarColor { get; set; }
        public string? DriverName { get; set; }
        public double? DriverPhone { get; set; }
        public string? DocumentsNum { get; set; }
    }
}
