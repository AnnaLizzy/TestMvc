using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class TtDichCorona2020
    {
        public int Id { get; set; }
        public string? Date { get; set; }
        public int? Nhiem { get; set; }
        public int? Sot { get; set; }
        public int? Namvien { get; set; }
        public int? Ravien { get; set; }
        public int? TheodoiKtx { get; set; }
        public int? RaKtx { get; set; }
        public int? AreaId { get; set; }
    }
}
