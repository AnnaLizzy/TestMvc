using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class SeMerTransfer
    {
        public int SeId { get; set; }
        public int? Id { get; set; }
        public string? EmpName { get; set; }
        public DateTime? TimeOut { get; set; }
        public DateTime? TimeIn { get; set; }
    }
}
