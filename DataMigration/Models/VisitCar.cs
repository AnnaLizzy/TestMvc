using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class VisitCar
    {
        public int VisitCarId { get; set; }
        public string? CarCode { get; set; }
        public int? CarType { get; set; }
        public string? CarColor { get; set; }
        public DateTime? CreatedTime { get; set; }
        public bool? IsDeleted { get; set; }
        public string? Name { get; set; }
        public int? PassType { get; set; }
        public string? PassNumber { get; set; }
        public string? Tel { get; set; }
        public int? Sex { get; set; }
        public int? FormId { get; set; }
        public int? ReportId { get; set; }
    }
}
