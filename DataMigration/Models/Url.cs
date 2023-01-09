using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class Url
    {
        public int UrlLid { get; set; }
        public string? UrlTitel { get; set; }
        public string? Url1 { get; set; }
        public double? Arrangement { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
