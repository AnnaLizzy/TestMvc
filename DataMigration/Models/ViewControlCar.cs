using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class ViewControlCar
    {
        public int? CredentialsNumber { get; set; }
        public string ControlName { get; set; } = null!;
        public string? CarNumber { get; set; }
        public string? Reason { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
