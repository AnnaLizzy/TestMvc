using System;
using System.Collections.Generic;

namespace Data.Migration.Models
{
    public partial class AppointmentCount
    {
        public int AppointmentCountId { get; set; }
        public string AppointmentCountGuid { get; set; } = null!;
        public string AppointmentPeopleNo { get; set; } = null!;
        public int AppointmentCount1 { get; set; }
    }
}
