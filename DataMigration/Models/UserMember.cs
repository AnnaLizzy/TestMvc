using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class UserMember
    {
        public int UserMemberId { get; set; }
        public string? Name { get; set; }
        public string? EmployeeNo { get; set; }
        public string? Ext { get; set; }
        public string? Notes { get; set; }
        public string? Password { get; set; }
        public int? Bgid { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime RePwdTime { get; set; }
    }
}
