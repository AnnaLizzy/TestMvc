using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ListMer
    {
        public int IdItem { get; set; }
        public int? Id { get; set; }
        public string? NameMer { get; set; }
        public string? Unit { get; set; }
        public int? Amount { get; set; }
        public string? Direct { get; set; }
        public string? Relation { get; set; }
        public string? Image { get; set; }
        public string? CarNumber { get; set; }
        public int? Weight { get; set; }
    }
}
