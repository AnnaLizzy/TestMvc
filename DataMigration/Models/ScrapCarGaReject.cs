using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ScrapCarGaReject
    {
        public int Id { get; set; }
        public int? Idpl { get; set; }
        public string? EmpNoId { get; set; }
        public string? Notes { get; set; }
        public string? Ip { get; set; }
        public DateTime? DateTime { get; set; }
    }
}
