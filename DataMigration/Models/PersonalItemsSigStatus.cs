using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class PersonalItemsSigStatus
    {
        public int Id { get; set; }
        public int? PersonalItemsFormId { get; set; }
        public string? SignerId { get; set; }
        public string? SignerName { get; set; }
        public string? Email { get; set; }
        public int? Status { get; set; }
        public double? LevelSigne { get; set; }
        public string? Meno { get; set; }
        public DateTime? TimeSigne { get; set; }
        public string? Ip { get; set; }
    }
}
