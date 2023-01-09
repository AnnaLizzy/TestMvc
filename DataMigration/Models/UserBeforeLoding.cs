using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class UserBeforeLoding : IdentityUser<int>
    {
        public int UserBeforeLodingId { get; set; } 
        public string EmployeeNo { get; set; } = null!;
        public string EmployeeName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public bool IsDeleted { get; set; }
        public DateTime? CreateTime { get; set; }
        public string Notes { get; set; } = null!;
        public int Bgid { get; set; }
        public int Type { get; set; }
        public int? UserType { get; set; }
        public int? Area { get; set; }
        public string? Bucode { get; set; }
        public int? CheckDelete { get; set; }

    }
}
