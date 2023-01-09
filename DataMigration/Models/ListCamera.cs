using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ListCamera
    {
        public int? Id { get; set; }
        public int Idlist { get; set; }
        public string? Kvcc { get; set; }
        public string? Area { get; set; }
        public string? House { get; set; }
        public string? Floor { get; set; }
        public string? Position { get; set; }
        public string? Time { get; set; }
    }
}
