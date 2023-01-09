using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class Admin : IdentityUser<int>
    {
        public int AdminId { get; set; }
        public int? AdminRoleId { get; set; }
        public string? EmployeeNo { get; set; }
        public string? Password { get; set; }
        public string? Name { get; set; }
        public string? Notes { get; set; }
        public int? PowerType { get; set; }
        public bool IsDeleted { get; set; }
        public int Bgid { get; set; }
        public string? Code { get; set; }
        public string? Ext { get; set; }
        public string? Annex { get; set; }
        public bool IsJudge { get; set; }
    }
}
