using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class CredentialDelaynewListCardNum
    {
        public int Id { get; set; }
        public int CredentialdelayNewId { get; set; }
        public string CardNumber { get; set; } = null!;
        public int? CardId { get; set; }
        public int? Status { get; set; }
        public DateTime? EndTimeNew { get; set; }
        public string? Name { get; set; }
        public string? AreaCard { get; set; }
        public DateTime? ApplicationTime { get; set; }
    }
}
