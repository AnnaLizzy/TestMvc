using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class CredentialContinu
    {
        public int CredentialContinuId { get; set; }
        public int CredentialId { get; set; }
        public int Type { get; set; }
        public DateTime? ApplyDate { get; set; }
        public string? Annex { get; set; }
        public int AdminId { get; set; }
    }
}
