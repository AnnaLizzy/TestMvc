using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ExemptionCar
    {
        public double? Id { get; set; }
        public string? Bgname { get; set; }
        public string? Name { get; set; }
        public string? CarNumber { get; set; }
        public string? CarType { get; set; }
        public string? CarColor { get; set; }
        public double? IsDeleteD { get; set; }
        public string? DeleteDdate { get; set; }
        public string? DeleteDseason { get; set; }
    }
}
