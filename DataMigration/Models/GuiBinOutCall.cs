using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class GuiBinOutCall
    {
        public string? VisitUnits { get; set; }
        public string? ApplicationUnit { get; set; }
        public DateTime? ApplicationTime { get; set; }
        public int? Status { get; set; }
        public DateTime? VisitStartTime { get; set; }
        public DateTime? VisitEndTime { get; set; }
        public string? ReceptionBg { get; set; }
        public string? ReceptionPeople { get; set; }
        public string? Extension { get; set; }
        public string? Tel { get; set; }
        public int? Type { get; set; }
        public int? Id { get; set; }
        public string? Bgname { get; set; }
        public int BackstageStatus { get; set; }
        public string? Number { get; set; }
        public int? Days { get; set; }
        public DateTime? Calldate { get; set; }
    }
}
