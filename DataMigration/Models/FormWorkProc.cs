using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class FormWorkProc
    {
        public int FormWorkProcId { get; set; }
        public int? FormId { get; set; }
        public int? Id { get; set; }
        public int? FormStatusId { get; set; }
        public string? Act { get; set; }
        public DateTime? WorkDate { get; set; }
        public string? Meno { get; set; }
    }
}
