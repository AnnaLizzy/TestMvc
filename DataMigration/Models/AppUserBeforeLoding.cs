using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class AppUserBeforeLoding
    {
        public int AppUserBeforeLodingId { get; set; }
        public string EmployeeNo { get; set; } = null!;
        public string EmployeeName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public bool IsDeleted { get; set; }
        public DateTime? CreateTime { get; set; }
        public int Bgid { get; set; }
        public int Type { get; set; }
    }
}
