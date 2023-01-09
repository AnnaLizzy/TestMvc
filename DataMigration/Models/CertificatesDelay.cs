using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class CertificatesDelay
    {
        public int Id { get; set; }
        public string? CompanyName { get; set; }
        public string? ApplyPeople { get; set; }
        public int? TypeId { get; set; }
        public int? Status { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? DeDate { get; set; }
        public string? OnworkFile { get; set; }
    }
}
