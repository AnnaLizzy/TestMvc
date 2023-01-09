using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class CarVip
    {
        public int CarVipId { get; set; }
        public string? SerialNumber { get; set; }
        public string? EmployeeNo { get; set; }
        public string? Name { get; set; }
        public string? CarNumber { get; set; }
        public int? CardType { get; set; }
        public int? BrushType { get; set; }
        public DateTime? CreateTime { get; set; }
        public string? Meno { get; set; }
        public string? TelePhone { get; set; }
        public string? DepartMent { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? EndTime { get; set; }
    }
}
