using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class PllistOut
    {
        public int Idlist { get; set; }
        public int? Idpl { get; set; }
        public int? Idcode { get; set; }
        public int? Weights { get; set; }
        public string? Image { get; set; }
        public DateTime? TimeUp { get; set; }
        public int? Type { get; set; }
        public string? BagId { get; set; }
        public string? WeightPerson { get; set; }
    }
}
