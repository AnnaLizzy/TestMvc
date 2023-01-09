using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ViewControlPerson
    {
        public string? ControlName { get; set; }
        public string? CredentialsNumber { get; set; }
        public string? Reason { get; set; }
        public string? CreateTime { get; set; }
        public string? SourceTag { get; set; }
    }
}
