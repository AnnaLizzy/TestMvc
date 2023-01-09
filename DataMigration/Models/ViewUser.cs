using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ViewUser
    {
        public string? EmployeeNo { get; set; }
        public string? Password { get; set; }
        public int Type { get; set; }
        public string? Name { get; set; }
        public string? Notes { get; set; }
        public int? Bgid { get; set; }
    }
}
