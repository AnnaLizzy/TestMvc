using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class PassForm
    {
        public int Id { get; set; }
        public int? FormId { get; set; }
        public string? PartPass { get; set; }
        public DateTime? PassTime { get; set; }
        public string? Ip { get; set; }
        public int? Sta { get; set; }
        public int? CategoryId { get; set; }
        public int? Type { get; set; }
    }
}
