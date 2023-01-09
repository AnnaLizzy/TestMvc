using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class Gongyingshang
    {
        public string? VendorCode { get; set; }
        public string? CorpName { get; set; }
        public string? NChnname { get; set; }
        public string StatusId { get; set; } = null!;
        public DateTime? UpdateDate { get; set; }
    }
}
