using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class WeightApi1
    {
        public int Id { get; set; }
        public int Idpl { get; set; }
        public DateTime? TimeWeight { get; set; }
        public string? ImageCar { get; set; }
        public string? CarNumber { get; set; }
        public int? Weight { get; set; }
        public string? UnitWeight { get; set; }
        public string? Status { get; set; }
        public string? ImagePerson { get; set; }
        public string? CardNumber { get; set; }
        public string? CarType { get; set; }
    }
}
