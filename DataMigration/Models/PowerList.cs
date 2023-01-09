using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class PowerList
    {
        public int PowerListId { get; set; }
        public string? PowerName { get; set; }
        public string PowerNum { get; set; } = null!;
    }
}
