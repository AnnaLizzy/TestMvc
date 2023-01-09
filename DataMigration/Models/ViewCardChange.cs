using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ViewCardChange
    {
        public int Id { get; set; }
        public int CredentialdelayNewId { get; set; }
        public string CardNumber { get; set; } = null!;
        public int? CardId { get; set; }
        public DateTime? EndTimeNew { get; set; }
        public string? Name { get; set; }
        public string? AreaCard { get; set; }
        public string? Applicant { get; set; }
        public DateTime? ApplicationTime { get; set; }
        public int? ContactPhoneNum { get; set; }
        public string? EmployeeName { get; set; }
    }
}
