using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class QuitApply
    {
        public int QuitApplyId { get; set; }
        public string? Company { get; set; }
        public string? Department { get; set; }
        public string? ApplyPeople { get; set; }
        public string? CredNo { get; set; }
        public DateTime? ApplyDate { get; set; }
        public string? Annex { get; set; }
    }
}
