using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ViewCredentialListCardNumAll
    {
        public int Id { get; set; }
        public int TableType { get; set; }
        public int CredentialdelayNewId { get; set; }
        public string CardNumber { get; set; } = null!;
        public int? CardId { get; set; }
        public int? Status { get; set; }
        public int? FormType { get; set; }
        public DateTime? EndTimeNew { get; set; }
        public string? Name { get; set; }
        public string? AreaCard { get; set; }
        public DateTime? ApplicationTime { get; set; }
        public string? FileAttack { get; set; }
        public DateTime? ReceivedTime { get; set; }
        public string? ReceivedName { get; set; }
        public DateTime? AdminSignTime { get; set; }
        public DateTime? AdminCreateCardTime { get; set; }
        public string? NotesForSign { get; set; }
        public string? Signer { get; set; }
        public string? CompanyOldName { get; set; }
        public string? CompanyNewName { get; set; }
        public string? AreaCardNew { get; set; }
        public string? ImageFile { get; set; }
    }
}
