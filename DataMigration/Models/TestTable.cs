using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class TestTable
    {
        public int Id { get; set; }
        public int? Sdt { get; set; }
        public string? Mathe { get; set; }
        public DateTime? Thoigian { get; set; }
        public string? Diachi { get; set; }
        public string? Memo { get; set; }
    }
}
