using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ViewSafeCheckHistoryCheck
    {
        public int Id { get; set; }
        public int? LocationId { get; set; }
        public int? Type { get; set; }
        public string? EmployeeId { get; set; }
        public DateTime? Time { get; set; }
        public int? Status { get; set; }
        public int? FrameTime { get; set; }
        public DateTime? Date { get; set; }
        public string? Notes { get; set; }
        public string? MacId { get; set; }
        public int? HistoryCheckbyplantId { get; set; }
        public string? Image { get; set; }
    }
}
