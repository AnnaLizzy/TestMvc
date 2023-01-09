using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class Form
    {
        public int FormId { get; set; }
        public int? FormType { get; set; }
        public string? FormName { get; set; }
        public string? FormTable { get; set; }
        public string? Url { get; set; }
        public string? KeyName { get; set; }
    }
}
