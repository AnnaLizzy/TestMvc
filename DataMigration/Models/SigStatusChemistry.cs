using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class SigStatusChemistry
    {
        public int Id { get; set; }
        public int ChemistryFormId { get; set; }
        public int? Category { get; set; }
        public string? SignerId { get; set; }
        public string? Email { get; set; }
        public int? Status { get; set; }
        public double? LevelSigne { get; set; }
        public string? Meno { get; set; }
        public string? SignerName { get; set; }
        public DateTime? SignedStDate { get; set; }
        public string? SignerNameV { get; set; }
        public string? Ip { get; set; }
    }
}
