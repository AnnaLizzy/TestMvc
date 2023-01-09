using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class CarToStop
    {
        public string? CarCardNo { get; set; }
        public string CompanyName { get; set; } = null!;
        public string? CarNumber { get; set; }
        public string? CarBrand { get; set; }
        public string? CarType { get; set; }
        public string? Color { get; set; }
    }
}
