using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class AdminRole : IdentityRole<int>
    {
        public int AdminRoleId { get; set; }
        public string? RoleName { get; set; }
    }
}
