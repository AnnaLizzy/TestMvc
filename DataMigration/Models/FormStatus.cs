using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class FormStatus
    {
        public int FormStatusId { get; set; }
        public int? FormId { get; set; }
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? FlowImage { get; set; }
        public string? Notes { get; set; }
        public int? Status { get; set; }
        public double? Leavel { get; set; }
        public string? FlowNum { get; set; }
        public DateTime? WorkTime { get; set; }
        public string? FormMeno { get; set; }
        public string? EmployeeNo { get; set; }
        public bool ToZc { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
