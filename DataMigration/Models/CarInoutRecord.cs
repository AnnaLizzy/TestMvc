using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class CarInoutRecord
    {
        public int? Id { get; set; }
        public string Stime { get; set; } = null!;
        public string CarNo { get; set; } = null!;
        public string Place { get; set; } = null!;
        public string SDir { get; set; } = null!;
        public string Style { get; set; } = null!;
        public string Imagepath { get; set; } = null!;
        public string? Bak { get; set; }
        public string? CarNum { get; set; }
    }
}
