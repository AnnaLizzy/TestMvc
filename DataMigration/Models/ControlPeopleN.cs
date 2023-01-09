using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ControlPeopleN
    {
        public int ControlPeopleNid { get; set; }
        public string? ControlName { get; set; }
        public string? CredentialsNumber { get; set; }
        public string? Reason { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsEffective { get; set; }
    }
}
