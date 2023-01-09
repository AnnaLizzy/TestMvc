using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class TestTableSentdata1
    {
        public int Id { get; set; }
        public int? IsCoppy { get; set; }
        public string? Data { get; set; }
        public DateTime? DataDate { get; set; }
    }
}
