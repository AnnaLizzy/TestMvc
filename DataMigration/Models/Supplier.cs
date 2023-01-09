using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class Supplier
    {
        public string? VendorCode { get; set; }
        public string? NChNname { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool? IsDeleted { get; set; }
        public byte[]? BitImage { get; set; }
    }
}
