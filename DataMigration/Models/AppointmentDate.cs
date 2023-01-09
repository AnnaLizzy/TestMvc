using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class AppointmentDate
    {
        public int AppointmentDateId { get; set; }
        public string AppointmentDateGuid { get; set; } = null!;
        public DateTime AppointmentDateName { get; set; }
        public bool IsDeleted { get; set; }
    }
}
