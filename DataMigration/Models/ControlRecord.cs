using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ControlRecord
    {
        public int ControlRecordId { get; set; }
        public int Id { get; set; }
        public int? Type { get; set; }
        public string? EmployeeNo { get; set; }
        public string? Name { get; set; }
        public string? Action { get; set; }
        public DateTime? CreateTime { get; set; }
        public string? ControlMsg { get; set; }
    }
}
