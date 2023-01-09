using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class CheckTime
    {
        public int MerId { get; set; }
        public int? Id { get; set; }
        public DateTime? TimeOut { get; set; }
        public string? TimeIn { get; set; }
    }
}
