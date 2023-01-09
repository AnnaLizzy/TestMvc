using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ScrapOut
    {
        public int Idpl { get; set; }
        public DateTime? ApplicationTime { get; set; }
        public int? Idin { get; set; }
        public string? ImageScrap { get; set; }
        public int? Status { get; set; }
        public int? IsDeleted { get; set; }
        public string? UserTime { get; set; }
        public string? Image1 { get; set; }
        public string? Image2 { get; set; }
        public string? Image3 { get; set; }
        public string? Image4 { get; set; }
        public string? FilePdf { get; set; }
        public DateTime? StartTimePutToScale { get; set; }
        public DateTime? EndTimePutToScalse { get; set; }
        public int? Type { get; set; }
    }
}
