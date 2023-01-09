using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class Plapplication
    {
        public int Id { get; set; }
        public int? Bgid { get; set; }
        public int? AreaId { get; set; }
        public int? ApplicationTime { get; set; }
        public string? Bu { get; set; }
        public string? EmpNo { get; set; }
        public string? EmpName { get; set; }
        public string? Notes { get; set; }
        public string? PhoneNumber { get; set; }
        public int? Status { get; set; }
    }
}
