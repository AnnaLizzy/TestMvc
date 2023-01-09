using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class VipcardApplication
    {
        public int Vipid { get; set; }
        public DateTime? VisitStartTime { get; set; }
        public DateTime? VisitEndTime { get; set; }
        public string? ReceptionBg { get; set; }
        public string? ReceptionDept { get; set; }
        public string? ReceptionPeople { get; set; }
        public string? Extension { get; set; }
        public string? Tel { get; set; }
        public int? Type { get; set; }
        public int? Id { get; set; }
        public int? ApplicationId { get; set; }
        public string? Reason { get; set; }
    }
}
