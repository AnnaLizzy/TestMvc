using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ChrInFactoryImage
    {
        public string? InFactoryNo { get; set; }
        public string? InFactoryName { get; set; }
        public string? InFactoryId { get; set; }
        public DateTime? CreateTime { get; set; }
        public string? Url { get; set; }
        public string? Md5val { get; set; }
        public int? IsImage { get; set; }
    }
}
