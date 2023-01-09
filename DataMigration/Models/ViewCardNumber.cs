using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ViewCardNumber
    {
        public string? MaDon { get; set; }
        public string Status { get; set; } = null!;
        public string? CarNumber { get; set; }
        public string? CardNumber { get; set; }
    }
}
