using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class FourCompanyAll
    {
        public int FormType { get; set; }
        public int VisitCustId { get; set; }
        public string? ApplicationUnit { get; set; }
        public DateTime? ApplicationTime { get; set; }
        public string? VisitUnits { get; set; }
        public int? Status { get; set; }
        public int BackstageStatus { get; set; }
        public string? ReceiverNo { get; set; }
        public int? VipCardId { get; set; }
        public string? Number { get; set; }
    }
}
