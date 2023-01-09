using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class Help
    {
        public int HelpId { get; set; }
        public string? HelpTitle { get; set; }
        public string? HelpContent { get; set; }
        public double? Arrangement { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
