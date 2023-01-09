using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class SecurityError
    {
        public int Ider { get; set; }
        public int? Id { get; set; }
        public string? NameEr { get; set; }
        public DateTime? TimeEr { get; set; }
        public string? Type { get; set; }
        public int? Status { get; set; }
        public string? PeopleWork { get; set; }
        public string? PosisionErr { get; set; }
        public string? SecurityName { get; set; }
        public DateTime? ApplicationTime { get; set; }
    }
}
