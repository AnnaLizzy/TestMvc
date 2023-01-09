using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ControlCar
    {
        public int ControlCarId { get; set; }
        public string? CredentialsNumber { get; set; }
        public string? ControlName { get; set; }
        public string? CarNumber { get; set; }
        public string? Reason { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool IsDeleted { get; set; }
        public int? CardId { get; set; }
        public int? Creator { get; set; }
    }
}
