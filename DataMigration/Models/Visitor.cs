using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class Visitor
    {
        public int VisitorsId { get; set; }
        public int? TemporaryCredentialsId { get; set; }
        public string? VisitorsName { get; set; }
        public string? CredentialsType { get; set; }
        public string? CredentialsNumber { get; set; }
        public bool? Sex { get; set; }
        public string? Meno { get; set; }
        public string? CardNumber { get; set; }
        public DateTime? SendTime { get; set; }
        public DateTime? RemandTime { get; set; }
    }
}
