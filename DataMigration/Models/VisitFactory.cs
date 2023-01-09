using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class VisitFactory
    {
        public int FactId { get; set; }
        public int VisitCustId { get; set; }
        public string? FactoryName { get; set; }
        public bool? IsDeleted { get; set; }
        public string? Area { get; set; }
        public string? DetailAddress { get; set; }
        public string? Meno { get; set; }
        public int? Bgid { get; set; }
        public bool? IsControl { get; set; }
        public string? ControlMeno { get; set; }
    }
}
