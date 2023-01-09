using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class CarPassBill
    {
        public int Idbill { get; set; }
        public int? Id { get; set; }
        public int? TypeId { get; set; }
        public int? Amount { get; set; }
        public string? FileBill { get; set; }
        public DateTime? CreateTime { get; set; }
        public int? AdminId { get; set; }
        public string? Memo { get; set; }
        public int? BillNumber { get; set; }
    }
}
