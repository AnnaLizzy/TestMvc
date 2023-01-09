using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class Log
    {
        public int LogId { get; set; }
        public int? AdminId { get; set; }
        public string? TableName { get; set; }
        public int? Id { get; set; }
        public DateTime? OperTime { get; set; }
        public string? OperType { get; set; }
        public string? Old { get; set; }
        public string? New { get; set; }
        public string? Ip { get; set; }
        public string? Mac { get; set; }
    }
}
