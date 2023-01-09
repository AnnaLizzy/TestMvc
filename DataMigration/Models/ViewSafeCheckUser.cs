using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ViewSafeCheckUser
    {
        public int Id { get; set; }
        public string? EmpNo { get; set; }
        public string? EmpName { get; set; }
        public string? Mail { get; set; }
        public string? Phone { get; set; }
        public int? UserType { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? EditTime { get; set; }
        public string? EmpNoCreate { get; set; }
        public string Password { get; set; } = null!;
        public int? Level { get; set; }
    }
}
