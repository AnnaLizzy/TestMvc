using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ScrapList
    {
        public int Idlist { get; set; }
        public int? Id { get; set; }
        public string? Plcode { get; set; }
        public string? Plname { get; set; }
        public string? Unit { get; set; }
    }
}
